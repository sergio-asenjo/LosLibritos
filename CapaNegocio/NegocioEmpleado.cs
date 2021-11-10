using CapaDTO;

namespace CapaNegocio
{
    public class NegocioEmpleado : Negocio
    {

        public void AnadirEmpleado(Empleado empleado)
        {
            ConfigurarConexion("Empleado");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (fecha_ingreso, tipo_empleado, estado, administrador) VALUES " +
                                   $"(GETDATE(), 'Admin', 0, 1);";
            Conec1.EsSelect = false;
            Conec1.conectar();
            ConfigurarConexion("Usuario");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (nombre, apellido_paterno, apellido_materno, rut, fecha_nacimiento, usuario, contrasena, email, direccion, ciudad, numero_telefono, fecha_creacion, id_empleado) VALUES " +
                                   $"('{empleado.Nombre}','{empleado.Apaterno}','{empleado.Amaterno}','{empleado.Rut}','{empleado.Fecha_nacimiento}','{empleado.Username}','{empleado.Contrasena}','{empleado.Email}','{empleado.Direccion}','{empleado.Ciudad}',{empleado.Numero_telefono},'{empleado.Fecha_creacion}', " +
                                   $"(SELECT IDENT_CURRENT('Empleado')) );";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
