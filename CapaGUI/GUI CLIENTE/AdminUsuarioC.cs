using CapaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminUsuarioC_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Auxclienteadmin.Nombre;
            txtDireccion.Text = Auxclienteadmin.Direccion;
            txtEmail.Text = Auxclienteadmin.Email;
            txtFecha.Text = Auxclienteadmin.Fecha_nacimiento;
            txtRut.Text = Auxclienteadmin.Rut;
            txtTelefono.Text = Auxclienteadmin.Numero_telefono.ToString();
        }
    }
}
