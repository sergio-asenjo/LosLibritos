using CapaDTO;
using CapaNegocio;
using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServicePrestamo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServicePrestamo : WebService
    {

        [WebMethod]
        public void webAnadirPrestamo(string rut, string isbn)
        {
            NegocioPrestamo auxPrestamo = new NegocioPrestamo();
            auxPrestamo.AnadirPrestamo(rut, isbn);
        }

        [WebMethod]
        public DataSet webMostrarPrestamos(string rut)
        {
            NegocioPrestamo auxPrestamo = new NegocioPrestamo();
            return auxPrestamo.mostrarPrestamos(rut);
        }

        [WebMethod]
        public DataSet webMostrarPrestamosGeneral()
        {
            NegocioPrestamo auxPrestamo = new NegocioPrestamo();
            return auxPrestamo.mostrarPrestamosGeneral();
        }

        [WebMethod]
        public DataSet webMostrarPrestamosTotal()
        {
            NegocioPrestamo auxPrestamo = new NegocioPrestamo();
            return auxPrestamo.mostrarPrestamosTotal();
        }

        [WebMethod]
        public void webFinalizarPrestamo(int id)
        {
            NegocioPrestamo auxPrestamo = new NegocioPrestamo();
            auxPrestamo.finalizarPrestamo(id);
        }

        [WebMethod]
        public DataSet webVerificarEstadoPrestamos(string rut)
        {
            NegocioPrestamo auxPrestamo = new NegocioPrestamo();
            return auxPrestamo.VerificarEstadoPrestamos(rut);
        }
    }
}
