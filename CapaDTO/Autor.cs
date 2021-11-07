using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Autor
    {
        private int id_autor;
        private string nombre;

        public int Id_autor { get => id_autor; set => id_autor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
