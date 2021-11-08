using CapaDTO;

namespace CapaNegocio
{
    public class NegocioAutor : Negocio
    {

        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirAutor(Autor autor)
        {
            ConfigurarConexion("autor");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (nombre) VALUES ('{autor.Nombre}');";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
