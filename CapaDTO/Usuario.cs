namespace CapaDTO
{
    public class Usuario
    {
        protected string nombre;
        protected string apaterno;
        protected string amaterno;
        protected string rut;
        protected string fecha_nacimiento;
        protected string username;
        protected string contrasena;
        protected string email;
        protected string direccion;
        protected string ciudad;
        protected int numero_telefono;
        protected string fecha_creacion;

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
        public int Numero_telefono { get => numero_telefono; set => numero_telefono = value; }
        public string Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
    }
}
