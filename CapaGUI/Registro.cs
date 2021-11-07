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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario auxusuario = new Usuario();

                auxusuario.Nombre = txtNombre.Text;
                auxusuario.Apaterno = txtAPaterno.Text;
                auxusuario.Amaterno = txtAMaterno.Text;
                auxusuario.Rut = txtRut.Text;
                auxusuario.Fecha_nacimiento = dateFechaNacimiento.Text;
                auxusuario.Username = txtUser.Text;
                auxusuario.Contrasena = txtContra.Text;
                auxusuario.Email = txtEmail.Text;
                auxusuario.Direccion = txtDireccion.Text;
                auxusuario.Ciudad = txtCiudad.Text;
                auxusuario.Numero_telefono = txtTelefono.Text;
            }

            catch (Exception ex)
            {

            }
            
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
