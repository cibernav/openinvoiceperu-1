using System;
using System.Collections.Generic;
using OpenInvoicePeru.Comun;
using OpenInvoicePeru.Comun.Dto.Contratos;
using OpenInvoicePeru.Comun.Dto.Modelos;
using OpenInvoicePeru.Estructuras.CommonAggregateComponents;
using OpenInvoicePeru.Estructuras.CommonBasicComponents;
using OpenInvoicePeru.Estructuras.CommonExtensionComponents;
using OpenInvoicePeru.Estructuras.EstandarUbl;
using OpenInvoicePeru.Estructuras.SunatAggregateComponents;

namespace OpenInvoicePeru.Xml
{
    public class NotaCreditoXml : IDocumentoXml
    {
        IEstructuraXml IDocumentoXml.Generar(IDocumentoElectronico request)
        {
            var documento = (DocumentoElectronico)request;
            documento.MontoEnLetras = Conversion.Enletras(documento.TotalVenta);
            var creditNote = new CreditNote
            {
                UblExtensions = new UblExtensions
                {
                    Extension2 = new UblExtension
                    {
                        ExtensionContent = new ExtensionContent
                        {
                            AdditionalInformation = new AdditionalInformation
                            {
                                AdditionalMonetaryTotals = new List<AdditionalMonetaryTotal>()
                                {
                                    new AdditionalMonetaryTotal()
                                    {
                                        Id ="1001",
                                        PayableAmount = new PayableAmount()
                                        {
                                            CurrencyId = documento.Moneda,
                                            Value = documento.Gravadas
                                        }
                                    }
                                },
                                AdditionalProperties = new List<AdditionalProperty>()
                                {
                                    new AdditionalProperty
                                    {
                                        Id = "1000",
                                        Value = documento.MontoEnLetras
                                    }
                                }
                            }
                        }
                    }
                },
                Id = documento.IdDocumento,
                IssueDate = DateTime.Parse(documento.FechaEmision),
                IssueTime = DateTime.Parse(documento.HoraEmision),
                DocumentCurrencyCode = documento.Moneda,
                Signature = new SignatureCac
                {
                    Id = documento.IdDocumento,
                    SignatoryParty = new SignatoryParty
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            Id = new PartyIdentificationId
                            {
                                Value = documento.Emisor.NroDocumento
                            }
                        },
                        PartyName = new PartyName
                        {
                            Name = documento.Emisor.NombreLegal
                        }
                    },
                    DigitalSignatureAttachment = new DigitalSignatureAttachment
                    {
                        ExternalReference = new ExternalReference
                        {
                            Uri = $"{documento.Emisor.NroDocumento}-{documento.IdDocumento}"
                        }
                    }
                },
                AccountingSupplierParty = new AccountingSupplierParty
                {
                    PartyTaxScheme = new PartyTaxScheme
                    {
                        RegistrationName = documento.Emisor.NombreLegal,
                        CompanyId = new CompanyId
                        {
                            SchemeId = documento.Emisor.TipoDocumento,
                            Value = documento.Emisor.NroDocumento
                        }
                    },
                    Party = new Party
                    {
                        PartyName = new PartyName
                        {
                            Name = documento.Emisor.NombreComercial
                        },
                        PartyLegalEntity = new PartyLegalEntity
                        {
                            RegistrationAddress = new RegistrationAddress
                            {
                                AddressTypeCode = documento.Emisor.CodigoAnexo
                            }
                        }
                    }
                },
                AccountingCustomerParty = new AccountingSupplierParty
                {
                    PartyTaxScheme = new PartyTaxScheme
                    {
                        RegistrationName = documento.Receptor.NombreLegal,
                        CompanyId = new CompanyId
                        {
                            SchemeId = documento.Receptor.TipoDocumento,
                            Value = documento.Receptor.NroDocumento
                        }
                    }
                },
                LegalMonetaryTotal = new LegalMonetaryTotal
                {
                    PayableAmount = new PayableAmount
                    {
                        CurrencyId = documento.Moneda,
                        Value = documento.TotalVenta
                    },
                    AllowanceTotalAmount = new PayableAmount
                    {
                        CurrencyId = documento.Moneda,
                        Value = documento.DescuentoGlobal
                    }
                },
                TaxTotals = new List<TaxTotal>
                {
                    new TaxTotal
                    {
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalIgv
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxableAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalVenta
                            },
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalIgv,
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxScheme = new TaxScheme
                                {
                                    Id = "1000",
                                    Name = "IGV",
                                    TaxTypeCode = "VAT"
                                }
                            }
                        }
                    }
                }
            };

            if (!string.IsNullOrEmpty(documento.FechaVencimiento))
                creditNote.DueDate = DateTime.Parse(documento.FechaVencimiento);

            foreach (var discrepancia in documento.Discrepancias)
            {
                creditNote.DiscrepancyResponses.Add(new DiscrepancyResponse
                {
                    ReferenceId = discrepancia.NroReferencia,
                    ResponseCode = discrepancia.Tipo,
                    Description = discrepancia.Descripcion
                });
            }

            foreach (var relacionado in documento.Relacionados)
            {
                creditNote.BillingReferences.Add(new BillingReference
                {
                    InvoiceDocumentReference = new InvoiceDocumentReference
                    {
                        Id = relacionado.NroDocumento,
                        DocumentTypeCode = relacionado.TipoDocumento
                    }
                });
            }

            foreach (var relacionado in documento.OtrosDocumentosRelacionados)
            {
                creditNote.AdditionalDocumentReferences.Add(new InvoiceDocumentReference
                {
                    DocumentTypeCode = relacionado.TipoDocumento,
                    Id = relacionado.NroDocumento
                });
            }

            foreach (var detalleDocumento in documento.Items)
            {
                var linea = new InvoiceLine
                {
                    Id = detalleDocumento.Id,
                    CreditedQuantity = new InvoicedQuantity
                    {
                        UnitCode = detalleDocumento.UnidadMedida,
                        Value = detalleDocumento.Cantidad
                    },
                    LineExtensionAmount = new PayableAmount
                    {
                        CurrencyId = documento.Moneda,
                        Value = detalleDocumento.TotalVenta
                    },
                    PricingReference = new PricingReference
                    {
                        AlternativeConditionPrices = new List<AlternativeConditionPrice>()
                    },
                    Item = new Item
                    {
                        Description = detalleDocumento.Descripcion,
                        SellersItemIdentification = new SellersItemIdentification
                        {
                            Id = detalleDocumento.CodigoItem
                        }
                    },
                    Price = new Price
                    {
                        PriceAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.PrecioUnitario
                        }
                    },
                };
                /* 16 - Afectaci�n al IGV por �tem */
                linea.TaxTotals.Add(new TaxTotal
                {
                    TaxAmount = new PayableAmount
                    {
                        CurrencyId = documento.Moneda,
                        Value = detalleDocumento.Impuesto
                    },
                    TaxSubtotal = new TaxSubtotal
                    {
                        TaxableAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.TotalVenta
                        },
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.Impuesto
                        },
                        TaxCategory = new TaxCategory
                        {
                            Percent = AfectacionImpuesto.ObtenerTasa(detalleDocumento.TipoImpuesto),
                            TaxExemptionReasonCode = detalleDocumento.TipoImpuesto,
                            TaxScheme = new TaxScheme()
                            {
                                Id = AfectacionImpuesto.ObtenerCodigoTributo(detalleDocumento.TipoImpuesto),
                                Name = AfectacionImpuesto.ObtenerDescripcionTributo(detalleDocumento.TipoImpuesto),
                                TaxTypeCode = AfectacionImpuesto.ObtenerCodigoTipoTributo(detalleDocumento.TipoImpuesto)
                            }
                        }
                    }
                });
                creditNote.CreditNoteLines.Add(linea);
            }

            return creditNote;
        }
    }
}