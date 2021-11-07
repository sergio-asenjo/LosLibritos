using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int id_autor;
        private int id_categoria;

        public int Id_libro { get => id_libro; set => id_libro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Edicion { get => edicion; set => edicion = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id_autor { get => id_autor; set => id_autor = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
    }
}
