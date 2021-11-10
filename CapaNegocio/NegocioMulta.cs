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
    }
}
