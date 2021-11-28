using CapaDTO;
using CapaNegocio;
using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceLibro
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceLibro : WebService
    {

        [WebMethod]
        public void webAnadirLibro(Libro libro)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            auxnegociolibro.AnadirLibro(libro);
        }

        [WebMethod]
        public DataSet webMostrarLibros()
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            return auxnegociolibro.mostrarLibros();
        }

        [WebMethod]
        public DataSet webFiltrarTitulo(string titulo)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            return auxnegociolibro.FiltrarTitulo(titulo);
        }

        [WebMethod]
        public DataSet webFiltrarCategoria(string categoria)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            return auxnegociolibro.FiltrarCategoria(categoria); 
        }

        [WebMethod]
        public DataSet webFiltrarAutor(string autor)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            return auxnegociolibro.FiltrarAutor(autor);
        }

        [WebMethod]
        public void webEliminarStock(string isbn)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            auxnegociolibro.EliminarStock(isbn);
        }

        [WebMethod]
        public void webAgregarStock(string isbn)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            auxnegociolibro.AgregarStock(isbn);
        }

        [WebMethod]
        public int webConsultarStock(string isbn)
        {
            NegocioLibro auxnegociolibro = new NegocioLibro();
            return auxnegociolibro.ConsultarStock(isbn);
        }
    }
}
