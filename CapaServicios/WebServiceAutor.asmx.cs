using CapaNegocio;
using CapaDTO;
using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceAutor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceAutor : WebService
    {

        [WebMethod]
        public void webAnadirAutor(Autor autor)
        {
            NegocioAutor auxAutor = new NegocioAutor();
            auxAutor.AnadirAutor(autor);
        }

        [WebMethod]
        public DataSet webMostrarListadoAutor()
        {
            NegocioAutor auxAutor = new NegocioAutor();
            return auxAutor.mostrarListadoAutor();
        }
    }
}
