namespace CapaDTO
{
    public class Libro
    {
        private int id_libro;
        private string titulo;
        private string descripcion;
        private string edicion;
        private string idioma;
        private string isbn;
        private int stock;
        private string nombre_autor;
        private string nombre_categoria;

        public int Id_libro { get => id_libro; set => id_libro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Edicion { get => edicion; set => edicion = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Nombre_autor { get => nombre_autor; set => nombre_autor = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }
    }
}
