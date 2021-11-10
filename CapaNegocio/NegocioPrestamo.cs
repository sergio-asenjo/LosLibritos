﻿using CapaDTO;

namespace CapaNegocio
{
    public class NegocioPrestamo : Negocio
    {
        // Hereda de "Negocio", por lo que ya tiene el atributo Conec1 y el método ConfigurarConexión.

        public void AnadirPrestamo(Prestamo prestamo, string rut, string titulo)
        {
            ConfigurarConexion("Prestamo");
            Conec1.CadenaSQL = $"INSERT INTO {Conec1.NombreTabla} (fecha_prestamo, fecha_devolucion, activo, pendiente_pago, id_cliente, id_libro, id_multa) VALUES" +
                               $"(GETDATE(), (GETDATE() + 3), 1, 0, " +
                               $"(SELECT id_cliente FROM Usuario WHERE rut = '{rut}') , " +
                               $"(SELECT id_libro FROM Libro WHERE titulo = '{titulo}') , null);";
            Conec1.EsSelect = false;
            Conec1.conectar();
        }
    }
}