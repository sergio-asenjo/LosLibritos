using CapaDTO;

namespace CapaNegocio
{
    class MainNegocio
    {
        static void Main()
        {
            var prestamo = new Prestamo();

            var nPrestamo = new NegocioPrestamo();
            nPrestamo.AnadirPrestamo("1-0", "Pinocho");

        }
    }
}
