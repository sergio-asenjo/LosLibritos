using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class AdminUsuarioC : Form
    {
        private ServiceCliente.Cliente auxclienteadmin;
        public ServiceCliente.Cliente Auxclienteadmin { get => auxclienteadmin; set => auxclienteadmin = value; }

        private const int CP_NOCLOSE_BUTTON = 0x200;

        public AdminUsuarioC()
        {
            InitializeComponent();
        }

        private void AdminUsuarioC_Load(object sender, EventArgs e)
        {
            ServicePrestamo.WebServicePrestamoSoapClient auxPrestamo = new ServicePrestamo.WebServicePrestamoSoapClient();
            NegocioMulta auxMulta = new NegocioMulta();

            this.GridPrestamos.DataSource = auxPrestamo.webMostrarPrestamos(Auxclienteadmin.Rut);
            this.GridPrestamos.DataMember = "Prestamo";

            this.GridMultas.DataSource = auxMulta.mostrarTodasMultasCliente(Auxclienteadmin.Rut);
            this.GridMultas.DataMember = "Multa";

            txtNombre.Text = Auxclienteadmin.Nombre;
            txtDireccion.Text = Auxclienteadmin.Direccion;
            txtEmail.Text = Auxclienteadmin.Email;
            txtFecha.Text = Auxclienteadmin.Fecha_nacimiento;
            txtRut.Text = Auxclienteadmin.Rut;
            txtTelefono.Text = Auxclienteadmin.Numero_telefono.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
