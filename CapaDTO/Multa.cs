namespace CapaDTO
{
    public class Multa
    {
        private int id_multa;
        private string fecha_multa;
        private bool pagada;
        private int dias_atraso;
        private int monto_pago;

        public int Id_multa { get => id_multa; set => id_multa = value; }
        public string Fecha_multa { get => fecha_multa; set => fecha_multa = value; }
        public bool Pagada { get => pagada; set => pagada = value; }
        public int Monto_pago { get => monto_pago; set => monto_pago = value; }
        public int Dias_atraso { get => dias_atraso; set =>  dias_atraso = value; }
    }
}
