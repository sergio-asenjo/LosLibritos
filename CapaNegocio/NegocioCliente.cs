using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class NegocioCliente : Negocio
    {
        public void AnadirCliente(Cliente cliente)
        {
            ConfigurarConexion("Cliente");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (cantidad_prestados, multa_vigente, miembro) VALUES " +
                               $"(0, 0, 0);";
            Conec1.EsSelect = false;
            Conec1.conectar();
            ConfigurarConexion("Usuario");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (nombre, apellido_paterno, apellido_materno, rut, fecha_nacimiento, usuario, contrasena, email, direccion, ciudad, numero_telefono, fecha_creacion, id_cliente) VALUES " +
                               $"('{cliente.Nombre}','{cliente.Apaterno}','{cliente.Amaterno}','{cliente.Rut}','{cliente.Fecha_nacimiento}','{cliente.Username}','{cliente.Contrasena}','{cliente.Email}','{cliente.Direccion}','{cliente.Ciudad}',{cliente.Numero_telefono},'{cliente.Fecha_creacion}', " +
                               $"(SELECT IDENT_CURRENT('Cliente')) );";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }

        public DataSet mostrarDatosCliente(string rut)
        {
            ConfigurarConexion("Cliente");
            Conec1.CadenaSQL = $"SELECT * FROM  {Conec1.NombreTabla} WHERE rut='{rut}'";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet iniciarSesionCliente(string usuario)
        {
            ConfigurarConexion("Usuario");
            Conec1.CadenaSQL = $"SELECT * FROM  {Conec1.NombreTabla} WHERE usuario='{usuario}'";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }
        public DataSet mostrarTodosClientes()
        {
            ConfigurarConexion("Usuario");
            Conec1.CadenaSQL = $"SELECT nombre  + ' ' + apellido_paterno + ' ' + apellido_materno as 'Nombre Completo', rut as 'Rut', fecha_nacimiento as 'Fecha Nacimiento', usuario as 'Usuario', " +
                               $"email as 'Email', direccion as 'Dirección', ciudad as 'Ciudad', numero_telefono as 'Telefono', " +
                               $"CASE WHEN id_empleado is NULL THEN 'NO' ELSE 'SI' END as 'Empleado', " +
                               $"CASE WHEN id_cliente is NULL THEN 'NO' ELSE 'SI' END as 'Cliente' " +
                               $"FROM USUARIO;";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet mostrarClienteFiltro(string filtro)
        {
            ConfigurarConexion("Usuario");
            Conec1.CadenaSQL = $"SELECT nombre  + ' ' + apellido_paterno + ' ' + apellido_materno as 'Nombre Completo', rut as 'Rut', fecha_nacimiento as 'Fecha Nacimiento', usuario as 'Usuario', " +
                               $"email as 'Email', direccion as 'Dirección', ciudad as 'Ciudad', numero_telefono as 'Telefono', " +
                               $"CASE WHEN id_empleado is NULL THEN 'NO' ELSE 'SI'END as 'Empleado', " +
                               $"CASE WHEN id_cliente is NULL THEN 'NO' ELSE 'SI' END as 'Cliente' " +
                               $"FROM USUARIO WHERE Nombre LIKE '%{filtro}%'; ";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }
    }
}
