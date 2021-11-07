using CapaDTO;
using System;

namespace CapaNegocio
{
    class MainNegocio
    {
        static void Main()
        {

            var autor = new Autor();
            autor.Id_autor = 0;
            autor.Nombre = "Juanito";

            var nAutor = new NegocioAutor();
            nAutor.AnadirAutor(autor);

        }
    }
}
