using CapaDTO;
using CapaNegocio;
using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceCliente : WebService
    {

        [WebMethod]
        public void webAnadirCliente(Cliente cliente)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            auxCliente.AnadirCliente(cliente);
        }

        [WebMethod]
        public DataSet webMostrarDatosCliente(string rut)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.mostrarDatosCliente(rut);
        }

        [WebMethod]
        public DataSet webIniciarSesionCliente(string usuario)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.iniciarSesionCliente(usuario);
        }

        [WebMethod]
        public DataSet webMostrarTodosClientes()
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.mostrarTodosClientes();
        }

        [WebMethod]
        public DataSet webMostrarClienteFiltro(string filtro)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.mostrarClienteFiltro(filtro);
        }

        [WebMethod]
        public void webActualizarPrestamosMultas(string rut)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            auxCliente.ActualizarPrestamosMultas(rut);
        }
    }
}
