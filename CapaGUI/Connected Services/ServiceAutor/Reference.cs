﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceAutor {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAutor.WebServiceAutorSoap")]
    public interface WebServiceAutorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAnadirAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webAnadirAutor(CapaGUI.ServiceAutor.Autor autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAnadirAutor", ReplyAction="*")]
        System.Threading.Tasks.Task webAnadirAutorAsync(CapaGUI.ServiceAutor.Autor autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webMostrarListadoAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webMostrarListadoAutor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webMostrarListadoAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webMostrarListadoAutorAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Autor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int id_autorField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id_autor {
            get {
                return this.id_autorField;
            }
            set {
                this.id_autorField = value;
                this.RaisePropertyChanged("Id_autor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
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
    public interface WebServiceAutorSoapChannel : CapaGUI.ServiceAutor.WebServiceAutorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAutorSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceAutor.WebServiceAutorSoap>, CapaGUI.ServiceAutor.WebServiceAutorSoap {
        
        public WebServiceAutorSoapClient() {
        }
        
        public WebServiceAutorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAutorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAutorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAutorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void webAnadirAutor(CapaGUI.ServiceAutor.Autor autor) {
            base.Channel.webAnadirAutor(autor);
        }
        
        public System.Threading.Tasks.Task webAnadirAutorAsync(CapaGUI.ServiceAutor.Autor autor) {
            return base.Channel.webAnadirAutorAsync(autor);
        }
        
        public System.Data.DataSet webMostrarListadoAutor() {
            return base.Channel.webMostrarListadoAutor();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webMostrarListadoAutorAsync() {
            return base.Channel.webMostrarListadoAutorAsync();
        }
    }
}