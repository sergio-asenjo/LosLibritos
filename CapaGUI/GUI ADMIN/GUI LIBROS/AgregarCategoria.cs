using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN.GUI_LIBROS
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCategoria.TextLength == 0)
                {
                    MessageBox.Show("Autor Vacio.", "Error de Sistema.");
                }
                else
                {
                    ServiceCategoria.Categoria auxCategoria = new ServiceCategoria.Categoria();
                    auxCategoria.Nombre_genero = txtCategoria.Text;
                    auxCategoria.Descripcion = txtDescripcion.Text;

                    ServiceCategoria.WebServiceCategoriaSoapClient auxServiceCategoria = new ServiceCategoria.WebServiceCategoriaSoapClient();
                    auxServiceCategoria.webAnadirCategoria(auxCategoria);

                    MessageBox.Show("¡Categoria Agregada!", "Confirmación de Sistema.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos Erroneos. " + ex.Message, "Mensaje de Sistema.");
            }
        }
    }
}
