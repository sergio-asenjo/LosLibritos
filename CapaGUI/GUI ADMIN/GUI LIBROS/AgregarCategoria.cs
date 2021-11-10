using CapaDTO;
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
                    MessageBox.Show("Autor Vacio", "Error de Sistema");
                }
                else
                {
                    Categoria auxCategoria = new Categoria();
                    auxCategoria.Nombre_genero = txtCategoria.Text;
                    auxCategoria.Descripcion = txtDescripcion.Text;

                    NegocioCategoria auxNegocioCategoria = new NegocioCategoria();
                    auxNegocioCategoria.AnadirCategoria(auxCategoria);

                    MessageBox.Show("Categoria Agregada!", "Confirmacion de Sistema");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos Erroneos. " + ex.Message, "Mensaje de sistema");
            }
        }
    }
}
