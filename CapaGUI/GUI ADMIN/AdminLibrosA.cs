using CapaDTO;
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
                if (txtISBN.Text.Length == 0)
                {
                    MessageBox.Show("ISBN Vacio", "Mensaje de Sistema");
                }
                else if (txtTitulo.Text.Length == 0)
                {
                    MessageBox.Show("Titulo Vacio", "Mensaje de Sistema");
                }
                else if (txtEdicion.Text.Length == 0)
                {
                    MessageBox.Show("Edicion Vacio", "Mensaje de Sistema");
                }
                else if (txtIdioma.Text.Length == 0)
                {
                    MessageBox.Show("Idioma Vacio", "Mensaje de Sistema");
                }
                else if (txtStock.Text.Length == 0)
                {
                    MessageBox.Show("Stock Vacio", "Mensaje de Sistema");
                }
                else if (txtDescripcion.Text.Length == 0)
                {
                    MessageBox.Show("Descripcion Vacia", "Mensaje de Sistema");
                }
                else
                {
                    Libro auxLibro = new Libro();

                    auxLibro.Isbn = txtISBN.Text;
                    auxLibro.Titulo = txtTitulo.Text;
                    auxLibro.Edicion = txtEdicion.Text;
                    auxLibro.Idioma = txtIdioma.Text;
                    auxLibro.Stock = int.Parse(txtStock.Text);
                    auxLibro.Descripcion = txtDescripcion.Text;
                    auxLibro.Nombre_autor = comboAutor.Text;
                    auxLibro.Nombre_categoria = comboCategoria.Text;

                    NegocioLibro auxNegocioLibro = new NegocioLibro();

                    auxNegocioLibro.AnadirLibro(auxLibro);
                    MessageBox.Show("Libro Guardado", "Mensaje de Sistema");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message, "Mensaje de Sistema");
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
            comboAutor.Text = "Selecciona Autor";
            comboCategoria.Text = "Selecciona Categoria";
            for (int i = 0; i <= auxAutor.mostrarListadoAutor().Tables.Count ; i++)
            {
                comboAutor.Items.Add(auxAutor.mostrarListadoAutor().Tables[0].Rows[i]["nombre"].ToString());
            }

            NegocioCategoria auxCategoria = new NegocioCategoria();

            for (int i = 0; i < auxCategoria.mostrarListadoCategoria().Tables.Count; i++)
            {
                comboCategoria.Items.Add(auxCategoria.mostrarListadoCategoria().Tables[0].Rows[i]["nombre_genero"].ToString());
            }
            

        }
    }
}
