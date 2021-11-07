using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Negocio
    {
        private Conexion conec1;
        public Conexion Conec1 { get => conec1; set => conec1 = value; }
        public void configurarConexion()
        {
            this.Conec1 = new Conexion();
            this.Conec1.NombreBaseDeDatos = "prueba";
            this.Conec1.NombreTabla = "transaccion";
            this.Conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=Prueba;Integrated Security=True";
        }
        public void guardarPrestamo(Prestamo prestamo)
        {
            this.configurarConexion();

        }
    }
}
