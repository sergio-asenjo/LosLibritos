namespace CapaDTO
{
    public class Empleado : Usuario
    {

        private string fecha_ingreso;
        private string tipo_empleado;
        private bool estado;
        private bool administrador;

        public string Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string Tipo_empleado { get => tipo_empleado; set => tipo_empleado = value; }
        public bool Estado { get => estado; set => estado = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
    }
}
