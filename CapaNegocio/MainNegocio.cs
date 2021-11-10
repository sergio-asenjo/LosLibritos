using CapaDTO;

namespace CapaNegocio
{
    class MainNegocio
    {
        static void Main()
        {
            var cliente = new Cliente
            {
                Nombre = "Juan",
                Apaterno = "And",
                Amaterno = "Asd",
                Ciudad = "Santiago",
                Direccion = "Avenida",
                Email = "email@email.com",
                Fecha_nacimiento = "1998-12-24",
                Fecha_creacion = "2021-11-10",
                Miembro = false,
                Numero_telefono = 912345678,
                Rut = "1-0",
                Username = "user",
                Contrasena = "pass",
                Cant_prestamos = 0,
                Multa_vigente = false
            };

            var empleado = new Empleado
            {
                Nombre = "Juan",
                Apaterno = "And",
                Amaterno = "Asd",
                Ciudad = "Santiago",
                Direccion = "Avenida",
                Email = "email@email.com",
                Fecha_nacimiento = "1998-12-24",
                Fecha_creacion = "2021-11-10",
                Numero_telefono = 912345678,
                Rut = "1-0",
                Username = "user",
                Contrasena = "pass",
                Administrador = true,
                Estado = false,
                Fecha_ingreso = "",
                Tipo_empleado = "Admin"
            };

            //var nCliente = new NegocioCliente();
            //nCliente.AnadirCliente(cliente);
            var nEmpleado = new NegocioEmpleado();
            nEmpleado.AnadirEmpleado(empleado);
            
        }
    }
}
