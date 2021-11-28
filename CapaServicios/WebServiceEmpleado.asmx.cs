using CapaDTO;
using CapaNegocio;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceEmpleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceEmpleado : WebService
    {

        [WebMethod]
        public void webAnadirEmpleado(Empleado empleado)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();
            auxEmpleado.AnadirEmpleado(empleado);
        }
    }
}
