using CapaDTO;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class NegocioLibro : Negocio
    {
        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirLibro(Libro libro)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} " +
                                "(id_libro, titulo, descripcion, edicion, idioma, isbn, stock, id_autor, id_categoria) VALUES" +
                               $"({libro.Id_libro},'{libro.Titulo}','{libro.Descripcion}','{libro.Edicion}','{libro.Idioma}','{libro.Isbn}', {libro.Stock}," +
                               $"(SELECT id_autor FROM autor WHERE nombre = '{libro.Nombre_autor}') , " +
                               $"(SELECT id_categoria FROM categoria WHERE nombre_genero = '{libro.Nombre_categoria}') );";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
