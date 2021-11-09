using CapaDTO;

namespace CapaNegocio
{
    class NegocioCliente : Negocio
    {
        public void AnadirCliente(Cliente cliente)
        {
            ConfigurarConexion("Cliente");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (cantidad_prestados, multa_vigente, miembro) VALUES " +
                               $"(0, 0, 0);";
            Conec1.EsSelect = false;
            Conec1.conectar();
            ConfigurarConexion("Usuario");
            Conec1.CadenaSQL = $"INSTERT INTO {Conec1.NombreTabla} (nombre, apellido_paterno, apellido_materno, rut, fecha_nacimiento, usuario, contrasena, email, direccion, ciudad, numero_telefono, fecha_creacion, id_cliente) VALUES " +
                               $"('{cliente.Nombre}','{cliente.Apaterno}','{cliente.Amaterno}','{cliente.Rut}','{cliente.Fecha_nacimiento}','{cliente.Username}','{cliente.Contrasena}','{cliente.Email}','{cliente.Direccion}','{cliente.Ciudad}',{cliente.Numero_telefono},'{cliente.Fecha_creacion}', " +
                               $"(SELECT TOP 1 * FROM Cliente ORDER BY ID DESC) );";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
