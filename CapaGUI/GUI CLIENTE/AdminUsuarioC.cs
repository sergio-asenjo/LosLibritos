using CapaDTO;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class AdminUsuarioC : Form
    {
        private Cliente auxclienteadmin;
        public Cliente Auxclienteadmin { get => auxclienteadmin; set => auxclienteadmin = value; }

        public AdminUsuarioC()
        {
            InitializeComponent();
        }

        private void AdminUsuarioC_Load(object sender, EventArgs e)
        {
            NegocioPrestamo auxprestamo = new NegocioPrestamo();

            this.GridPrestamos.DataSource = auxprestamo.mostrarPrestamos(auxclienteadmin.Rut);
            this.GridPrestamos.DataMember = "Prestamo";

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
    }
}
