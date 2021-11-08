namespace CapaDTO
{
    public class Prestamo
    {
        private int id_prestamo;
        private string fecha_prestamo;
        private string fecha_devolucion;
        private bool activo;
        private bool pendiente_pago;
        private int id_cliente;
        private int id_libro;
        private int id_multa;

        public int Id_prestamo { get => id_prestamo; set => id_prestamo = value; }
        public string Fecha_prestamo { get => fecha_prestamo; set => fecha_prestamo = value; }
        public string Fecha_devolucion { get => fecha_devolucion; set => fecha_devolucion = value; }
        public bool Activo { get => activo; set => activo = value; }
        public bool Pendiente_pago { get => pendiente_pago; set => pendiente_pago = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_libro { get => id_libro; set => id_libro = value; }
        public int Id_multa { get => id_multa; set => id_multa = value; }
    }
}
