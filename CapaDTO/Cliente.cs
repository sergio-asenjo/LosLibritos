namespace CapaDTO
{
    public class Cliente
    {
        private int id_cliente;
        private int cant_prestamos;
        private bool multa_vigente;
        private bool miembro;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Cant_prestamos { get => cant_prestamos; set => cant_prestamos = value; }
        public bool Multa_vigente { get => multa_vigente; set => multa_vigente = value; }
        public bool Miembro { get => miembro; set => miembro = value; }
    }
}