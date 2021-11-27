using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class NegocioPrestamo : Negocio
    {
        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirPrestamo(string rut, string isbn)
        {
            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (fecha_prestamo, fecha_devolucion, activo, pendiente_pago, id_cliente, id_libro, id_multa) VALUES" +
                               $"(GETDATE(), (GETDATE() + 3), 1, 0, " +
                               $"(SELECT id_cliente FROM Usuario WHERE rut = '{rut}') , " +
                               $"(SELECT id_libro FROM Libro WHERE isbn = '{isbn}') , null);";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
        public DataSet mostrarPrestamos(string rut)
        {
            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $"SELECT li.titulo as Titulo, mu.fecha_prestamo as 'Fecha Prestamo', mu.fecha_devolucion as 'Fecha Devolucion'," +
                               $"CASE WHEN mu.activo = 1 THEN 'Activo' WHEN mu.activo = 0 THEN 'Pagado' END as 'Estado Solicitud'," +
                               $"CASE WHEN mu.pendiente_pago = 1 THEN 'Falta Pago' WHEN mu.pendiente_pago = 0 THEN 'No' END as 'Pendiente de Pago '" +
                               $"FROM Prestamo mu JOIN Usuario us ON mu.id_cliente = us.id_cliente " +
                               $"JOIN Libro li ON mu.id_libro = li.id_libro WHERE us.rut = '{rut}';";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }
        public DataSet mostrarPrestamosGeneral()
        {
            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $"SELECT us.nombre + ' ' +  us.apellido_paterno + ' ' + us.apellido_materno,li.isbn as ISBN , li.titulo as Titulo, mu.fecha_prestamo as 'Fecha Prestamo', mu.fecha_devolucion as 'Fecha Devolucion', mu.id_prestamo as 'ID', " +
                               $"CASE WHEN mu.activo = 1 THEN 'Activo' WHEN mu.activo = 0 THEN 'Pagado' END as 'Estado Solicitud'," +
                               $"CASE WHEN mu.pendiente_pago = 1 THEN 'Falta Pago' WHEN mu.pendiente_pago = 0 THEN 'No' END as 'Pendiente de Pago' " +
                               $"FROM Prestamo mu JOIN Usuario us ON mu.id_cliente = us.id_cliente " +
                               $"JOIN Libro li ON mu.id_libro = li.id_libro WHERE mu.activo = '1';";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet mostrarPrestamosTotal()
        {
            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $"SELECT us.nombre + ' ' +  us.apellido_paterno + ' ' + us.apellido_materno,li.isbn as ISBN , li.titulo as Titulo, mu.fecha_prestamo as 'Fecha Prestamo', mu.fecha_devolucion as 'Fecha Devolucion', mu.id_prestamo as 'ID', " +
                               $"CASE WHEN mu.activo = 1 THEN 'Activo' WHEN mu.activo = 0 THEN 'Pagado' END as 'Estado Solicitud'," +
                               $"CASE WHEN mu.pendiente_pago = 1 THEN 'Falta Pago' WHEN mu.pendiente_pago = 0 THEN 'No' END as 'Pendiente de Pago' " +
                               $"FROM Prestamo mu JOIN Usuario us ON mu.id_cliente = us.id_cliente " +
                               $"JOIN Libro li ON mu.id_libro = li.id_libro;";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public void finalizarPrestamo(int id)
        {
            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $"UPDATE Prestamo SET activo = 0 WHERE id_prestamo = {id};";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }

        public DataSet VerificarEstadoPrestamos(string rut)
        {
            ConfigurarConexion("Cliente");
            Conec1.CadenaSQL = $"SELECT Cliente.cantidad_prestados, Cliente.multa_vigente FROM {Conec1.NombreTabla} JOIN Usuario ON " +
                               $"Cliente.id_cliente = Usuario.id_cliente WHERE Usuario.rut = '{rut}';";
            Conec1.EsSelect = true;
            Conec1.conectar();
            DataSet ds = Conec1.DbDataSet;
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ds;
            }
        }
    }
}
