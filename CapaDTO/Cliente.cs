namespace CapaDTO
{
    public class Cliente : Usuario
    {
        private int cant_prestamos;
        private bool multa_vigente;
        private bool miembro;

        public int Cant_prestamos { get => cant_prestamos; set => cant_prestamos = value; }
        public bool Multa_vigente { get => multa_vigente; set => multa_vigente = value; }
        public bool Miembro { get => miembro; set => miembro = value; }
    }
}