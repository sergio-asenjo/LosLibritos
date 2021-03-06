//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceLibro {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLibro.WebServiceLibroSoap")]
    public interface WebServiceLibroSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAnadirLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webAnadirLibro(CapaGUI.ServiceLibro.Libro libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAnadirLibro", ReplyAction="*")]
        System.Threading.Tasks.Task webAnadirLibroAsync(CapaGUI.ServiceLibro.Libro libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webMostrarLibros", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webMostrarLibros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webMostrarLibros", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webMostrarLibrosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webFiltrarTitulo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webFiltrarTitulo(string titulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webFiltrarTitulo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webFiltrarTituloAsync(string titulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webFiltrarCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webFiltrarCategoria(string categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webFiltrarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webFiltrarCategoriaAsync(string categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webFiltrarAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webFiltrarAutor(string autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webFiltrarAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webFiltrarAutorAsync(string autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webEliminarStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webEliminarStock(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webEliminarStock", ReplyAction="*")]
        System.Threading.Tasks.Task webEliminarStockAsync(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAgregarStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webAgregarStock(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webAgregarStock", ReplyAction="*")]
        System.Threading.Tasks.Task webAgregarStockAsync(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webConsultarStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int webConsultarStock(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webConsultarStock", ReplyAction="*")]
        System.Threading.Tasks.Task<int> webConsultarStockAsync(string isbn);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Libro : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int id_libroField;
        
        private string tituloField;
        
        private string descripcionField;
        
        private string edicionField;
        
        private string idiomaField;
        
        private string isbnField;
        
        private int stockField;
        
        private string nombre_autorField;
        
        private string nombre_categoriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id_libro {
            get {
                return this.id_libroField;
            }
            set {
                this.id_libroField = value;
                this.RaisePropertyChanged("Id_libro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Titulo {
            get {
                return this.tituloField;
            }
            set {
                this.tituloField = value;
                this.RaisePropertyChanged("Titulo");
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Edicion {
            get {
                return this.edicionField;
            }
            set {
                this.edicionField = value;
                this.RaisePropertyChanged("Edicion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Idioma {
            get {
                return this.idiomaField;
            }
            set {
                this.idiomaField = value;
                this.RaisePropertyChanged("Idioma");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Isbn {
            get {
                return this.isbnField;
            }
            set {
                this.isbnField = value;
                this.RaisePropertyChanged("Isbn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int Stock {
            get {
                return this.stockField;
            }
            set {
                this.stockField = value;
                this.RaisePropertyChanged("Stock");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Nombre_autor {
            get {
                return this.nombre_autorField;
            }
            set {
                this.nombre_autorField = value;
                this.RaisePropertyChanged("Nombre_autor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Nombre_categoria {
            get {
                return this.nombre_categoriaField;
            }
            set {
                this.nombre_categoriaField = value;
                this.RaisePropertyChanged("Nombre_categoria");
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
    public interface WebServiceLibroSoapChannel : CapaGUI.ServiceLibro.WebServiceLibroSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceLibroSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceLibro.WebServiceLibroSoap>, CapaGUI.ServiceLibro.WebServiceLibroSoap {
        
        public WebServiceLibroSoapClient() {
        }
        
        public WebServiceLibroSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceLibroSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLibroSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLibroSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void webAnadirLibro(CapaGUI.ServiceLibro.Libro libro) {
            base.Channel.webAnadirLibro(libro);
        }
        
        public System.Threading.Tasks.Task webAnadirLibroAsync(CapaGUI.ServiceLibro.Libro libro) {
            return base.Channel.webAnadirLibroAsync(libro);
        }
        
        public System.Data.DataSet webMostrarLibros() {
            return base.Channel.webMostrarLibros();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webMostrarLibrosAsync() {
            return base.Channel.webMostrarLibrosAsync();
        }
        
        public System.Data.DataSet webFiltrarTitulo(string titulo) {
            return base.Channel.webFiltrarTitulo(titulo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webFiltrarTituloAsync(string titulo) {
            return base.Channel.webFiltrarTituloAsync(titulo);
        }
        
        public System.Data.DataSet webFiltrarCategoria(string categoria) {
            return base.Channel.webFiltrarCategoria(categoria);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webFiltrarCategoriaAsync(string categoria) {
            return base.Channel.webFiltrarCategoriaAsync(categoria);
        }
        
        public System.Data.DataSet webFiltrarAutor(string autor) {
            return base.Channel.webFiltrarAutor(autor);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webFiltrarAutorAsync(string autor) {
            return base.Channel.webFiltrarAutorAsync(autor);
        }
        
        public void webEliminarStock(string isbn) {
            base.Channel.webEliminarStock(isbn);
        }
        
        public System.Threading.Tasks.Task webEliminarStockAsync(string isbn) {
            return base.Channel.webEliminarStockAsync(isbn);
        }
        
        public void webAgregarStock(string isbn) {
            base.Channel.webAgregarStock(isbn);
        }
        
        public System.Threading.Tasks.Task webAgregarStockAsync(string isbn) {
            return base.Channel.webAgregarStockAsync(isbn);
        }
        
        public int webConsultarStock(string isbn) {
            return base.Channel.webConsultarStock(isbn);
        }
        
        public System.Threading.Tasks.Task<int> webConsultarStockAsync(string isbn) {
            return base.Channel.webConsultarStockAsync(isbn);
        }
    }
}
