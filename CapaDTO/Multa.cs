using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Multa
    {
        private int id_multa;
        private string fecha_multa;
        private bool pagada;

        public int Id_multa { get => id_multa; set => id_multa = value; }
        public string Fecha_multa { get => fecha_multa; set => fecha_multa = value; }
        public bool Pagada { get => pagada; set => pagada = value; }
    }
}
