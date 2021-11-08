using System;
using CapaConexion;

namespace CapaNegocio
{
    class Negocio
    {
        protected Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void ConfigurarConexion(string nombreTabla)
        {
            Conec1 = new Conexion();
            Conec1.NombreBaseDeDatos = "loslibritos";
            Conec1.NombreTabla = nombreTabla;
            Conec1.CadenaConexion = $"Data Source = {Environment.GetEnvironmentVariable("DB_HOST")}; " +
                                    $"Network Library = DBMSSOCN; " +
                                    $"Initial Catalog = {Conec1.NombreBaseDeDatos}; " +
                                    $"User ID = {Environment.GetEnvironmentVariable("DB_USER")}; " +
                                    $"Password = {Environment.GetEnvironmentVariable("DB_PASS")}";
        }
    }
}
