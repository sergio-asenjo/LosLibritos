using CapaConexion;

namespace CapaNegocio
{
    class NegocioAutor : Negocio
    {

        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirAutor(int idAutor, string nombreAutor)
        {
            ConfigurarConexion("autor");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (id_autor, nombre) VALUES ({idAutor},'{nombreAutor}');";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
