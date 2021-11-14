using CapaGUI.GUI_ADMIN.GUI_LIBROS;
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

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminLibrosA : Form
    {
        public AdminLibrosA()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show("Datos Erroneos. " + ex.Message, "Mensaje de sistema");
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria cate1 = new AgregarCategoria();

            cate1.ShowDialog();

        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            AgregarAutor autor1 = new AgregarAutor();

            autor1.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AdminLibrosA_Load(object sender, EventArgs e)
        {
            NegocioAutor auxAutor = new NegocioAutor();
            dataGrid1.DataSource = auxAutor.mostrarListado();
            dataGrid1.DataMember = "Autor";

            

        }
    }
}
