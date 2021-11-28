using CapaNegocio;
using CapaDTO;
using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceMulta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceMulta : WebService
    {

        [WebMethod]
        public void webAnadirMulta()
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            auxnegociomulta.AnadirMulta();
        }

        [WebMethod]
        public DataSet webmostrarTodasMultasCliente(string rut)
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            return auxnegociomulta.mostrarTodasMultasCliente(rut);
        }

        [WebMethod]
        public DataSet webMostrarTodasMultas()
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            return auxnegociomulta.mostrarTodasMultas();
        }

        [WebMethod]
        public DataSet webMostrarMultaCliente(string id_multa)
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            return auxnegociomulta.mostrarMultaCliente(id_multa);
        }

        [WebMethod]
        public DataSet webMostrarMultaSemana()
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            return auxnegociomulta.mostrarMultaSemana();
        }

        [WebMethod]
        public DataSet webMostrarMultaMes()
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            return auxnegociomulta.mostrarMultaMes();
        }

        [WebMethod]
        public void webPagarMulta(int id_multa)
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            auxnegociomulta.pagarMulta(id_multa);
        }

        [WebMethod]
        public void webActualizarMultasImpagas()
        {
            NegocioMulta auxnegociomulta = new NegocioMulta();
            auxnegociomulta.actualizarMultasImpagas();
        }
    }
}
