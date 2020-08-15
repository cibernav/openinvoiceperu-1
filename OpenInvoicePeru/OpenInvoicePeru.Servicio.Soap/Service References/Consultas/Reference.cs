﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenInvoicePeru.Servicio.Soap.Consultas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe/")]
    public partial class SOAPException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class StatusCdr : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string numeroComprobanteField;
        
        private string rucComprobanteField;
        
        private string serieComprobanteField;
        
        private string tipoComprobanteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string numeroComprobante {
            get {
                return this.numeroComprobanteField;
            }
            set {
                this.numeroComprobanteField = value;
                this.RaisePropertyChanged("numeroComprobante");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string rucComprobante {
            get {
                return this.rucComprobanteField;
            }
            set {
                this.rucComprobanteField = value;
                this.RaisePropertyChanged("rucComprobante");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string serieComprobante {
            get {
                return this.serieComprobanteField;
            }
            set {
                this.serieComprobanteField = value;
                this.RaisePropertyChanged("serieComprobante");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string tipoComprobante {
            get {
                return this.tipoComprobanteField;
            }
            set {
                this.tipoComprobanteField = value;
                this.RaisePropertyChanged("tipoComprobante");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.sunat.gob.pe/", ConfigurationName="Consultas.BizlinksOSE")]
    public interface BizlinksOSE {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://service.sunat.gob.pe) of message getStatusCdr does not match the default value (http://service.sunat.gob.pe/)
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(OpenInvoicePeru.Servicio.Soap.Consultas.SOAPException), Action="urn:getStatusCdr", Name="SOAPException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdrResponse getStatusCdr(OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdrResponse> getStatusCdrAsync(OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://service.sunat.gob.pe) of message sendPack does not match the default value (http://service.sunat.gob.pe/)
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendPack", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(OpenInvoicePeru.Servicio.Soap.Consultas.SOAPException), Action="urn:sendPack", Name="SOAPException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OpenInvoicePeru.Servicio.Soap.Consultas.sendPackResponse sendPack(OpenInvoicePeru.Servicio.Soap.Consultas.sendPack request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendPack", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendPackResponse> sendPackAsync(OpenInvoicePeru.Servicio.Soap.Consultas.sendPack request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://service.sunat.gob.pe) of message sendBill does not match the default value (http://service.sunat.gob.pe/)
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendBill", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(OpenInvoicePeru.Servicio.Soap.Consultas.SOAPException), Action="urn:sendBill", Name="SOAPException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OpenInvoicePeru.Servicio.Soap.Consultas.sendBillResponse sendBill(OpenInvoicePeru.Servicio.Soap.Consultas.sendBill request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendBill", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendBillResponse> sendBillAsync(OpenInvoicePeru.Servicio.Soap.Consultas.sendBill request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://service.sunat.gob.pe) of message getStatus does not match the default value (http://service.sunat.gob.pe/)
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(OpenInvoicePeru.Servicio.Soap.Consultas.SOAPException), Action="urn:getStatus", Name="SOAPException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OpenInvoicePeru.Servicio.Soap.Consultas.getStatusResponse getStatus(OpenInvoicePeru.Servicio.Soap.Consultas.getStatus request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.getStatusResponse> getStatusAsync(OpenInvoicePeru.Servicio.Soap.Consultas.getStatus request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://service.sunat.gob.pe) of message sendSummary does not match the default value (http://service.sunat.gob.pe/)
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendSummary", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(OpenInvoicePeru.Servicio.Soap.Consultas.SOAPException), Action="urn:sendSummary", Name="SOAPException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OpenInvoicePeru.Servicio.Soap.Consultas.sendSummaryResponse sendSummary(OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendSummary", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendSummaryResponse> sendSummaryAsync(OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdr", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdr {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OpenInvoicePeru.Servicio.Soap.Consultas.StatusCdr statusCdr;
        
        public getStatusCdr() {
        }
        
        public getStatusCdr(OpenInvoicePeru.Servicio.Soap.Consultas.StatusCdr statusCdr) {
            this.statusCdr = statusCdr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdrResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] document;
        
        public getStatusCdrResponse() {
        }
        
        public getStatusCdrResponse(byte[] document) {
            this.document = document;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendPack", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendPack {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] contentFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partyType;
        
        public sendPack() {
        }
        
        public sendPack(string fileName, byte[] contentFile, string partyType) {
            this.fileName = fileName;
            this.contentFile = contentFile;
            this.partyType = partyType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendPackResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendPackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        public sendPackResponse() {
        }
        
        public sendPackResponse(string ticket) {
            this.ticket = ticket;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendBill", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendBill {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] contentFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partyType;
        
        public sendBill() {
        }
        
        public sendBill(string fileName, byte[] contentFile, string partyType) {
            this.fileName = fileName;
            this.contentFile = contentFile;
            this.partyType = partyType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendBillResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendBillResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] applicationResponse;
        
        public sendBillResponse() {
        }
        
        public sendBillResponse(byte[] applicationResponse) {
            this.applicationResponse = applicationResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatus", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatus {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        public getStatus() {
        }
        
        public getStatus(string ticket) {
            this.ticket = ticket;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OpenInvoicePeru.Servicio.Soap.Consultas.statusResponse status;
        
        public getStatusResponse() {
        }
        
        public getStatusResponse(OpenInvoicePeru.Servicio.Soap.Consultas.statusResponse status) {
            this.status = status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSummary", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendSummary {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] contentFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partyType;
        
        public sendSummary() {
        }
        
        public sendSummary(string fileName, byte[] contentFile, string partyType) {
            this.fileName = fileName;
            this.contentFile = contentFile;
            this.partyType = partyType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSummaryResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendSummaryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        public sendSummaryResponse() {
        }
        
        public sendSummaryResponse(string ticket) {
            this.ticket = ticket;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BizlinksOSEChannel : OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BizlinksOSEClient : System.ServiceModel.ClientBase<OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE>, OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE {
        
        public BizlinksOSEClient() {
        }
        
        public BizlinksOSEClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BizlinksOSEClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BizlinksOSEClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BizlinksOSEClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdrResponse OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.getStatusCdr(OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr request) {
            return base.Channel.getStatusCdr(request);
        }
        
        public byte[] getStatusCdr(OpenInvoicePeru.Servicio.Soap.Consultas.StatusCdr statusCdr) {
            OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr();
            inValue.statusCdr = statusCdr;
            OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdrResponse retVal = ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).getStatusCdr(inValue);
            return retVal.document;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdrResponse> OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.getStatusCdrAsync(OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr request) {
            return base.Channel.getStatusCdrAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdrResponse> getStatusCdrAsync(OpenInvoicePeru.Servicio.Soap.Consultas.StatusCdr statusCdr) {
            OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.getStatusCdr();
            inValue.statusCdr = statusCdr;
            return ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).getStatusCdrAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenInvoicePeru.Servicio.Soap.Consultas.sendPackResponse OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.sendPack(OpenInvoicePeru.Servicio.Soap.Consultas.sendPack request) {
            return base.Channel.sendPack(request);
        }
        
        public string sendPack(string fileName, byte[] contentFile, string partyType) {
            OpenInvoicePeru.Servicio.Soap.Consultas.sendPack inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.sendPack();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            OpenInvoicePeru.Servicio.Soap.Consultas.sendPackResponse retVal = ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).sendPack(inValue);
            return retVal.ticket;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendPackResponse> OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.sendPackAsync(OpenInvoicePeru.Servicio.Soap.Consultas.sendPack request) {
            return base.Channel.sendPackAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendPackResponse> sendPackAsync(string fileName, byte[] contentFile, string partyType) {
            OpenInvoicePeru.Servicio.Soap.Consultas.sendPack inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.sendPack();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            return ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).sendPackAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenInvoicePeru.Servicio.Soap.Consultas.sendBillResponse OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.sendBill(OpenInvoicePeru.Servicio.Soap.Consultas.sendBill request) {
            return base.Channel.sendBill(request);
        }
        
        public byte[] sendBill(string fileName, byte[] contentFile, string partyType) {
            OpenInvoicePeru.Servicio.Soap.Consultas.sendBill inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.sendBill();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            OpenInvoicePeru.Servicio.Soap.Consultas.sendBillResponse retVal = ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).sendBill(inValue);
            return retVal.applicationResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendBillResponse> OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.sendBillAsync(OpenInvoicePeru.Servicio.Soap.Consultas.sendBill request) {
            return base.Channel.sendBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendBillResponse> sendBillAsync(string fileName, byte[] contentFile, string partyType) {
            OpenInvoicePeru.Servicio.Soap.Consultas.sendBill inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.sendBill();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            return ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).sendBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenInvoicePeru.Servicio.Soap.Consultas.getStatusResponse OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.getStatus(OpenInvoicePeru.Servicio.Soap.Consultas.getStatus request) {
            return base.Channel.getStatus(request);
        }
        
        public OpenInvoicePeru.Servicio.Soap.Consultas.statusResponse getStatus(string ticket) {
            OpenInvoicePeru.Servicio.Soap.Consultas.getStatus inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.getStatus();
            inValue.ticket = ticket;
            OpenInvoicePeru.Servicio.Soap.Consultas.getStatusResponse retVal = ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).getStatus(inValue);
            return retVal.status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.getStatusResponse> OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.getStatusAsync(OpenInvoicePeru.Servicio.Soap.Consultas.getStatus request) {
            return base.Channel.getStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.getStatusResponse> getStatusAsync(string ticket) {
            OpenInvoicePeru.Servicio.Soap.Consultas.getStatus inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.getStatus();
            inValue.ticket = ticket;
            return ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).getStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenInvoicePeru.Servicio.Soap.Consultas.sendSummaryResponse OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.sendSummary(OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary request) {
            return base.Channel.sendSummary(request);
        }
        
        public string sendSummary(string fileName, byte[] contentFile, string partyType) {
            OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            OpenInvoicePeru.Servicio.Soap.Consultas.sendSummaryResponse retVal = ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).sendSummary(inValue);
            return retVal.ticket;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendSummaryResponse> OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE.sendSummaryAsync(OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary request) {
            return base.Channel.sendSummaryAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.Servicio.Soap.Consultas.sendSummaryResponse> sendSummaryAsync(string fileName, byte[] contentFile, string partyType) {
            OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary inValue = new OpenInvoicePeru.Servicio.Soap.Consultas.sendSummary();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            return ((OpenInvoicePeru.Servicio.Soap.Consultas.BizlinksOSE)(this)).sendSummaryAsync(inValue);
        }
    }
}
