using CapaDTO;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro reg1 = new Registro();
            reg1.Show();
            
        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioCliente auxNegocioCliente = new NegocioCliente();
                              
                if (txtUsuario.Text == "admin" && txtContra.Text == "admin")
                {
                    MenuAdmin menu2 = new MenuAdmin();
                    menu2.ShowDialog();
                }

                else if (auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["usuario"].ToString() == txtUsuario.Text && auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["contrasena"].ToString() == txtContra.Text)
                {
                    MenuCliente menu1 = new MenuCliente();

                    Cliente auxcliente = new Cliente();
                    
                    auxcliente.Nombre = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["nombre"].ToString();
                    auxcliente.Apaterno = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["apellido_paterno"].ToString();
                    auxcliente.Amaterno = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["apellido_materno"].ToString();
                    auxcliente.Rut = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["rut"].ToString();
                    auxcliente.Fecha_nacimiento = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["fecha_nacimiento"].ToString();
                    auxcliente.Username = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["usuario"].ToString();
                    auxcliente.Contrasena = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["contrasena"].ToString();
                    auxcliente.Email = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["email"].ToString();
                    auxcliente.Direccion = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["direccion"].ToString();
                    auxcliente.Ciudad = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["ciudad"].ToString();
                    auxcliente.Numero_telefono = int.Parse(auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["numero_telefono"].ToString());
                    auxcliente.Fecha_creacion = auxNegocioCliente.iniciarSesionCliente(txtUsuario.Text).Tables[0].Rows[0]["fecha_creacion"].ToString();
                    auxcliente.Cant_prestamos = 0;
                    auxcliente.Multa_vigente = false;
                    auxcliente.Miembro = false;

                    menu1.Auxclientemenu = auxcliente;
                    menu1.Show();

                    Hide();
                }

                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos ingrese nuevamente. ", "Mensaje de sistema");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Usuario o Contraseña incorrectos ingrese nuevamente. " + ex.Message , "Mensaje de sistema");
            }
            
        }

        private void chkBoxContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxContrasena.Checked == true)
            {
                if (txtContra.PasswordChar == '*')
                {
                    txtContra.PasswordChar = '\0';
                }
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIniciarS_Click(sender, e);
            }
        }
    }
}
