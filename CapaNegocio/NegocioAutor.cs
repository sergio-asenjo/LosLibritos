using CapaDTO;
using System.Collections.Generic;
using System.Data;

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
        public DataSet mostrarListado()
        {
            ConfigurarConexion("autor");
            Conec1.CadenaSQL = $"SELECT nombre FROM {Conec1.NombreTabla}";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }
    }
}
