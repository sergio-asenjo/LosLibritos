using CapaNegocio;
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

namespace CapaGUI.GUI_ADMIN.GUI_LIBROS
{
    public partial class AgregarAutor : Form
    {
        public AgregarAutor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAutor.TextLength == 0)
                {
                    MessageBox.Show("Autor Vacio", "Error de Sistema");
                }
                else
                {
                    Autor auxAutor = new Autor();
                    auxAutor.Nombre = txtAutor.Text;

                    NegocioAutor auxNegocioAutor = new NegocioAutor();
                    auxNegocioAutor.AnadirAutor(auxAutor);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Datos Erroneos. " + ex.Message, "Mensaje de sistema");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
