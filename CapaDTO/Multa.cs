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
        public int Dias_atraso
        {
            get => dias_atraso;
            set
            {
                dias_atraso = value;
                if (dias_atraso > 0 && dias_atraso < 4)
                {
                    Monto_pago = 1000;
                }
                else if (dias_atraso >= 4 && dias_atraso < 8)
                {
                    Monto_pago = 2000;
                }
                else if (dias_atraso >= 8 && dias_atraso < 12)
                {
                    Monto_pago = 3000;
                }
                else if (dias_atraso >= 12 && dias_atraso < 16)
                {
                    Monto_pago = 4000;
                }
                else if (dias_atraso >= 16)
                {
                    Monto_pago = 5000;
                }
            }
        }
    }
}
