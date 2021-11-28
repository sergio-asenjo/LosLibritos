using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class NegocioMulta : Negocio
    {
        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirMulta()
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (fecha_multa, pagada) VALUES " +
                               $"(GETDATE(), 0);";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }

        public DataSet mostrarTodasMultasCliente(string rut)
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $@"SELECT 
    	                            Libro.titulo as 'Titulo',
	                                CASE WHEN Multa.pagada = 0 THEN 'Pendiente Pago'
		                                 WHEN Multa.pagada = 1 THEN 'Pagada' END as 'Estado',
	                                Prestamo.fecha_prestamo as 'Fecha Prestado',
	                                Prestamo.fecha_devolucion as 'Fecha Devolucion'
	                                FROM Usuario
		                            JOIN Prestamo ON Usuario.id_cliente = Prestamo.id_cliente
		                            JOIN Libro ON Prestamo.id_libro = Libro.id_libro
		                            JOIN Multa ON Prestamo.id_multa = Multa.id_multa
		                            WHERE Usuario.rut = '{rut}'
		                            ORDER BY Multa.pagada ASC;";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet mostrarTodasMultas()
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $@"SELECT Usuario.usuario AS 'Nombre Usuario',
	                                Libro.titulo AS 'Libro',
                                    Multa.id_multa as 'ID',
	                                CASE WHEN Prestamo.pendiente_pago = 1 THEN 'Si' END AS 'Pendiente Pago',
	                                Prestamo.fecha_prestamo AS 'Fecha Prestado',
	                                Prestamo.fecha_devolucion AS 'Fecha Devolucion',
                                    CASE WHEN Prestamo.pendiente_pago = 1 THEN DATEDIFF(day, Prestamo.fecha_devolucion, GETDATE())
                                         END AS 'Dias Atraso'
	                                FROM Usuario 
	                                    JOIN Prestamo ON Usuario.id_cliente = Prestamo.id_cliente
	                                    JOIN Libro ON Prestamo.id_libro = Libro.id_libro
	                                    JOIN Multa ON Prestamo.id_multa = Multa.id_multa
                                    WHERE Prestamo.pendiente_pago = 1
	                                ORDER BY Prestamo.activo DESC";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet mostrarMultaCliente(string id_multa)
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $"SELECT * FROM {Conec1.NombreTabla} WHERE id_multa='{id_multa}'";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet mostrarMultaSemana()
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $"SELECT fecha_multa as 'Fecha Multa', pagada as 'Estado de Pago' FROM Multa " +
                               $"WHERE fecha_multa >= DATEADD(day, -7, GETDATE()) " +
                               $"order by[Fecha Multa]ASC;";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public DataSet mostrarMultaMes()
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $"SELECT fecha_multa as 'Fecha Multa', pagada as 'Estado de Pago' FROM Multa " +
                               $"WHERE fecha_multa >= DATEADD(day, -31, GETDATE()) " +
                               $"order by[Fecha Multa]ASC;";
            Conec1.EsSelect = true;
            Conec1.conectar();
            return Conec1.DbDataSet;
        }

        public void pagarMulta(Multa multa)
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $@"UPDATE {Conec1.NombreTabla}
                                    SET pagada = 1
                                    WHERE id_multa = {multa.Id_multa};";
            Conec1.EsSelect = false;
            Conec1.conectar();

            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $@"UPDATE {Conec1.NombreTabla}
                                    SET pendiente_pago = 0
                                    WHERE id_multa = {multa.Id_multa};";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }

        public void actualizarMultasImpagas()
        {
            ConfigurarConexion("Multa");
            Conec1.CadenaSQL = $@"BEGIN
	                                DECLARE @Id INT
	                                DECLARE @FechaDevolucion DATE
	                                DECLARE @IdMulta INT
	                                WHILE EXISTS (SELECT id_prestamo, fecha_devolucion FROM Prestamo WHERE activo = 1 AND pendiente_pago = 0 AND(DATEDIFF(day, fecha_devolucion, GETDATE()) > 0))
	                                BEGIN
		                                SELECT TOP 1 @Id = id_prestamo, @FechaDevolucion = fecha_devolucion FROM Prestamo
		                                WHERE activo = 1 AND (DATEDIFF(day, fecha_devolucion, GETDATE()) > 0);
		
		                                INSERT INTO Multa VALUES (DATEADD(day, +1, @FechaDevolucion), 0)
		                                SELECT @IdMulta = @@IDENTITY;

		                                UPDATE Prestamo
			                                SET id_multa = @IdMulta,
				                                pendiente_pago = 1
			                                WHERE id_prestamo = @Id;
	                                END
                                END";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}
    