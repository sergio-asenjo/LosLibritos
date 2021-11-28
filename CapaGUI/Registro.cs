using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class Registro : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength == 0)
                {
                    MessageBox.Show("Nombre Vacio", "Error de Sistema");
                }
                else if (txtAPaterno.TextLength == 0)
                {
                    MessageBox.Show("Apellido Paterno Vacio", "Error de Sistema");
                }
                else if (txtAMaterno.TextLength == 0)
                {
                    MessageBox.Show("Apellido Materno Vacio", "Error de Sistema");
                }
                else if (txtRut.TextLength == 0)
                {
                    MessageBox.Show("Rut Vacio", "Error de Sistema");
                }
                else if (txtUser.TextLength == 0)
                {
                    MessageBox.Show("Usuario Vacio", "Error de Sistema");
                }
                else if (txtContra.TextLength == 0)
                {
                    MessageBox.Show("Contraseña Vacia", "Error de Sistema");
                }
                else if (txtEmail.TextLength == 0)
                {
                    MessageBox.Show("Correo Vacio", "Error de Sistema");
                }
                else if (txtDireccion.TextLength == 0)
                {
                    MessageBox.Show("Direccion Vacia", "Error de Sistema");
                }
                else if (txtCiudad.TextLength == 0)
                {
                    MessageBox.Show("Ciudad en Blanco", "Error de Sistema");
                }
                else if (txtTelefono.TextLength < 9)
                {
                    MessageBox.Show("Telefono tiene que contener 9 digitos ", "Error de Sistema");
                }
                else
                {
                    
                    ServiceCliente.Cliente auxcliente = new ServiceCliente.Cliente();

                    auxcliente.Nombre = txtNombre.Text;
                    auxcliente.Apaterno = txtAPaterno.Text;
                    auxcliente.Amaterno = txtAMaterno.Text;
                    auxcliente.Rut = txtRut.Text;
                    auxcliente.Fecha_nacimiento = dateFechaNacimiento.Text;
                    auxcliente.Username = txtUser.Text;
                    auxcliente.Contrasena = txtContra.Text;
                    auxcliente.Email = txtEmail.Text;
                    auxcliente.Direccion = txtDireccion.Text;
                    auxcliente.Ciudad = txtCiudad.Text;
                    auxcliente.Numero_telefono = int.Parse(txtTelefono.Text);
                    auxcliente.Cant_prestamos = 0;
                    auxcliente.Multa_vigente = false;
                    auxcliente.Miembro = true;

                    ServiceCliente.WebServiceClienteSoapClient auxServicioCliente = new ServiceCliente.WebServiceClienteSoapClient();
                    auxServicioCliente.webAnadirCliente(auxcliente);

                    MessageBox.Show("Usuario Registrado", "Confirmacion de Sistema");

                    Dispose();
                    GC.Collect();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Datos Erroneos. " + ex.Message, "Mensaje de sistema");
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            dateFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dateFechaNacimiento.CustomFormat = "yyyy-MM-dd";
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
