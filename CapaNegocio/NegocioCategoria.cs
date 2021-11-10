using CapaDTO;

namespace CapaNegocio
{
    public class NegocioCategoria : Negocio
    {
        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirCategoria(Categoria categoria)
        {
            ConfigurarConexion("categoria");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (nombre_genero, descripcion) VALUES" +
                               $"('{categoria.Nombre_genero}','{categoria.Descripcion}');";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
