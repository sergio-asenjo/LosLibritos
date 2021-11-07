using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Usuario
    {
        private int id_usuario;
        private String nombre;
        private String apaterno;
        private String amaterno;
        private String rut;
        private String fecha_nacimiento;
        private String username;
        private String contrasena;
        private String email;
        private String direccion;
        private String ciudad;
        private String numero_telefono;
        private String fecha_creacion;
        private int id_empleado;
        private int id_cliente;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apaterno { get => apaterno; set => apaterno = value; }
        public string Amaterno { get => amaterno; set => amaterno = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Username { get => username; set => username = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Numero_telefono { get => numero_telefono; set => numero_telefono = value; }
        public string Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
    }
}
