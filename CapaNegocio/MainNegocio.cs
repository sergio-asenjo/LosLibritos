using CapaDTO;
using System;

namespace CapaNegocio
{
    class MainNegocio
    {
        static void Main()
        {
            try
            {
                var libro = new Libro(
                    2,
                    "Algun libro",
                    "Este es un libro",
                    "Edicion Libro",
                    "Espanich",
                    "19283912",
                    1,
                    "Guru",
                    "Ciencia");

                var nLibro = new NegocioLibro();
                nLibro.AnadirLibro(libro);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
