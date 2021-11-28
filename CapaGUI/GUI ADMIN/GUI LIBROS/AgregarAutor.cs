using System;
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
                    MessageBox.Show("¡Autor Vacio", "Error de Sistema.");
                }
                else
                {
                    ServiceAutor.WebServiceAutorSoapClient auxServiceAutor = new ServiceAutor.WebServiceAutorSoapClient();
                    ServiceAutor.Autor auxAutor = new ServiceAutor.Autor();
                    
                    auxAutor.Nombre = txtAutor.Text;
                    auxServiceAutor.webAnadirAutor(auxAutor);

                    MessageBox.Show("¡Autor Agregado!", "Confirmación de Sistema.");
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
