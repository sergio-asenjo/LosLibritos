using CapaDTO;
using CapaNegocio;
using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceCategoria
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceCategoria : WebService
    {

        [WebMethod]
        public void webAnadirCategoria(Categoria categoria)
        {
            NegocioCategoria auxCategoria = new NegocioCategoria();
            auxCategoria.AnadirCategoria(categoria);
        }

        [WebMethod]
        public DataSet webMostrarListadoCategoria()
        {
            NegocioCategoria auxCategoria = new NegocioCategoria();
            return auxCategoria.mostrarListadoCategoria();
        }
    }
}
