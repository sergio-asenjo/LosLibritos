using System;
using System.Data;
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
                ServiceCliente.WebServiceClienteSoapClient auxNegocioCliente = new ServiceCliente.WebServiceClienteSoapClient();

                DataSet usuario = auxNegocioCliente.webIniciarSesionCliente(txtUsuario.Text);
                string id = usuario.Tables[0].Rows[0]["id_empleado"].ToString();

                if (usuario.Tables[0].Rows[0]["usuario"].ToString() == txtUsuario.Text
                    && usuario.Tables[0].Rows[0]["contrasena"].ToString() == txtContra.Text
                    && id.Length > 0)
                {
                    MenuAdmin menu2 = new MenuAdmin();

                    ServiceEmpleado.Empleado auxEmpleado = new ServiceEmpleado.Empleado
                    {
                        Nombre = usuario.Tables[0].Rows[0]["nombre"].ToString(),
                        Apaterno = usuario.Tables[0].Rows[0]["apellido_paterno"].ToString(),
                        Amaterno = usuario.Tables[0].Rows[0]["apellido_materno"].ToString(),
                        Rut = usuario.Tables[0].Rows[0]["rut"].ToString(),
                        Fecha_nacimiento = usuario.Tables[0].Rows[0]["fecha_nacimiento"].ToString(),
                        Username = usuario.Tables[0].Rows[0]["usuario"].ToString(),
                        Contrasena = usuario.Tables[0].Rows[0]["contrasena"].ToString(),
                        Email = usuario.Tables[0].Rows[0]["email"].ToString(),
                        Direccion = usuario.Tables[0].Rows[0]["direccion"].ToString(),
                        Ciudad = usuario.Tables[0].Rows[0]["ciudad"].ToString(),
                        Numero_telefono = int.Parse(usuario.Tables[0].Rows[0]["numero_telefono"].ToString()),
                        Fecha_creacion = usuario.Tables[0].Rows[0]["fecha_creacion"].ToString(),
                        Administrador = true,
                        Estado = true,
                        Fecha_ingreso = new DateTime().Date.ToString(),
                        Tipo_empleado = "Administrador"
                    };

                    menu2.AuxEmpleado = auxEmpleado;
                    menu2.Show();
                    Hide();
                }

                else if (usuario.Tables[0].Rows[0]["usuario"].ToString() == txtUsuario.Text
                         && usuario.Tables[0].Rows[0]["contrasena"].ToString() == txtContra.Text)
                {
                    MenuCliente menu1 = new MenuCliente();

                    ServiceCliente.Cliente auxcliente = new ServiceCliente.Cliente
                    {
                        Nombre = usuario.Tables[0].Rows[0]["nombre"].ToString(),
                        Apaterno = usuario.Tables[0].Rows[0]["apellido_paterno"].ToString(),
                        Amaterno = usuario.Tables[0].Rows[0]["apellido_materno"].ToString(),
                        Rut = usuario.Tables[0].Rows[0]["rut"].ToString(),
                        Fecha_nacimiento = usuario.Tables[0].Rows[0]["fecha_nacimiento"].ToString(),
                        Username = usuario.Tables[0].Rows[0]["usuario"].ToString(),
                        Contrasena = usuario.Tables[0].Rows[0]["contrasena"].ToString(),
                        Email = usuario.Tables[0].Rows[0]["email"].ToString(),
                        Direccion = usuario.Tables[0].Rows[0]["direccion"].ToString(),
                        Ciudad = usuario.Tables[0].Rows[0]["ciudad"].ToString(),
                        Numero_telefono = int.Parse(usuario.Tables[0].Rows[0]["numero_telefono"].ToString()),
                        Fecha_creacion = usuario.Tables[0].Rows[0]["fecha_creacion"].ToString(),
                        Cant_prestamos = 0,
                        Multa_vigente = false,
                        Miembro = false
                    };

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
