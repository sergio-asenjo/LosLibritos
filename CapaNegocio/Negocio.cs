using CapaConexion;

namespace CapaNegocio
{
    public class Negocio
    {
        protected Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void ConfigurarConexion(string nombreTabla)
        {
            this.Conec1 = new Conexion
            {
                NombreBaseDeDatos = "loslibritos",
                NombreTabla = nombreTabla,
                CadenaConexion = "Data Source=localhost;Initial Catalog=loslibritos;Integrated Security=True"
            };
        }
    }
}
