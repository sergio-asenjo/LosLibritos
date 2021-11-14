using CapaNegocio;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro reg1 = new Registro();
            reg1.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioCliente auxNegocioCliente = new NegocioCliente();
                string usuario = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["usuario"].ToString();
                string contra = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["contrasena"].ToString();

                if (usuario == txtUsuario.Text && contra == txtContra.Text)
                {

                }
            }

            catch(Exception ex)
            {

            }
            MenuAdmin menu1 = new MenuAdmin();
            menu1.ShowDialog();
        }
    }
}
