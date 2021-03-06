//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceCategoria {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCategoria.WebServiceCategoriaSoap")]
    public interface WebServiceCategoriaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAnadirCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webAnadirCategoria(CapaGUI.ServiceCategoria.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAnadirCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task webAnadirCategoriaAsync(CapaGUI.ServiceCategoria.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webMostrarListadoCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webMostrarListadoCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webMostrarListadoCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webMostrarListadoCategoriaAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Categoria : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int id_categoriaField;
        
        private string nombre_generoField;
        
        private string descripcionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id_categoria {
            get {
                return this.id_categoriaField;
            }
            set {
                this.id_categoriaField = value;
                this.RaisePropertyChanged("Id_categoria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre_genero {
            get {
                return this.nombre_generoField;
            }
            set {
                this.nombre_generoField = value;
                this.RaisePropertyChanged("Nombre_genero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("Descripcion");
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
    public interface WebServiceCategoriaSoapChannel : CapaGUI.ServiceCategoria.WebServiceCategoriaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceCategoriaSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceCategoria.WebServiceCategoriaSoap>, CapaGUI.ServiceCategoria.WebServiceCategoriaSoap {
        
        public WebServiceCategoriaSoapClient() {
        }
        
        public WebServiceCategoriaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceCategoriaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceCategoriaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceCategoriaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void webAnadirCategoria(CapaGUI.ServiceCategoria.Categoria categoria) {
            base.Channel.webAnadirCategoria(categoria);
        }
        
        public System.Threading.Tasks.Task webAnadirCategoriaAsync(CapaGUI.ServiceCategoria.Categoria categoria) {
            return base.Channel.webAnadirCategoriaAsync(categoria);
        }
        
        public System.Data.DataSet webMostrarListadoCategoria() {
            return base.Channel.webMostrarListadoCategoria();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webMostrarListadoCategoriaAsync() {
            return base.Channel.webMostrarListadoCategoriaAsync();
        }
    }
}
