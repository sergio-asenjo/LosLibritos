using CapaDTO;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class NegocioLibro : Negocio
    {
        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirLibro(Libro libro)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} " +
                                "(titulo, descripcion, edicion, idioma, isbn, stock, id_autor, id_categoria) VALUES" +
                               $"('{libro.Titulo}','{libro.Descripcion}','{libro.Edicion}','{libro.Idioma}','{libro.Isbn}', {libro.Stock}," +
                               $"(SELECT id_autor FROM autor WHERE nombre = '{libro.Nombre_autor}') , " +
                               $"(SELECT id_categoria FROM categoria WHERE nombre_genero = '{libro.Nombre_categoria}') );";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
        public DataSet mostrarLibros()
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"Select lb.titulo as Titulo, au.nombre as Nombre_Autor, ca.nombre_genero as Genero, lb.descripcion as Descripcion, lb.edicion as Edicion, lb.idioma as Idioma, lb.isbn as ISBN, lb.stock as Stock " +
                               $"From Libro lb join Categoria ca "+
                               $"on lb.id_categoria = ca.id_categoria "+
                               $"join Autor au "+
                               $"on lb.id_autor = au.id_autor;";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet FiltrarTitulo(string titulo)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"SELECT titulo AS Título, descripcion as Descripción, edicion as Edición, idioma as Idioma, isbn as ISBN, stock as Stock FROM {Conec1.NombreTabla} " +
                               $"WHERE titulo LIKE '%{titulo}%';";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet FiltrarCategoria(string categoria)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"SELECT {Conec1.NombreTabla}.titulo AS Título, {Conec1.NombreTabla}.descripcion as Descripción, {Conec1.NombreTabla}.edicion as Edición, {Conec1.NombreTabla}.idioma as Idioma, {Conec1.NombreTabla}.isbn as ISBN, {Conec1.NombreTabla}.stock as Stock FROM {Conec1.NombreTabla} " +
                               $"JOIN Categoria ON {Conec1.NombreTabla}.id_categoria = Categoria.id_categoria WHERE Categoria.nombre_genero LIKE '%{categoria}%';";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet FiltrarAutor(string autor)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"SELECT Autor.nombre as 'Nombre Autor', {Conec1.NombreTabla}.titulo AS Título, {Conec1.NombreTabla}.descripcion as Descripción, {Conec1.NombreTabla}.edicion as Edición, {Conec1.NombreTabla}.idioma as Idioma, {Conec1.NombreTabla}.isbn as ISBN, {Conec1.NombreTabla}.stock as Stock FROM {Conec1.NombreTabla} " +
                               $"JOIN Autor ON {Conec1.NombreTabla}.id_autor = Autor.id_autor WHERE Autor.nombre LIKE '%{autor}%';";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }
        public void EliminarStock(string isbn)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"UPDATE libro set stock = stock -1 where isbn = '{isbn}';";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
        public void AgregarStock(string isbn)
        {
            ConfigurarConexion("libro");
            Conec1.CadenaSQL = $"UPDATE libro set stock = stock +1 where isbn = '{isbn}';";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
