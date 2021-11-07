using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Categoria
    {
        private int id_categoria;
        private string nombre_genero;
        private string descripcion;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_genero { get => nombre_genero; set => nombre_genero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
