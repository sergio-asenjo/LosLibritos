using CapaGUI.GUI_ADMIN.GUI_LIBROS;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminLibrosA : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public AdminLibrosA()
        {
            InitializeComponent();
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
                    ServiceLibro.Libro auxLibro = new ServiceLibro.Libro(); 
                    

                    auxLibro.Isbn = txtISBN.Text;
                    auxLibro.Titulo = txtTitulo.Text;
                    auxLibro.Edicion = txtEdicion.Text;
                    auxLibro.Idioma = txtIdioma.Text;
                    auxLibro.Stock = int.Parse(txtStock.Text);
                    auxLibro.Descripcion = txtDescripcion.Text;
                    auxLibro.Nombre_autor = comboAutor.Text;
                    auxLibro.Nombre_categoria = comboCategoria.Text;

                    ServiceLibro.WebServiceLibroSoapClient auxNegocioLibro = new ServiceLibro.WebServiceLibroSoapClient();
                    

                    auxNegocioLibro.webAnadirLibro(auxLibro);
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
            AdminLibrosA_Load(sender, e);
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            AgregarAutor autor1 = new AgregarAutor();

            autor1.ShowDialog();

            AdminLibrosA_Load(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AdminLibrosA_Load(object sender, EventArgs e)
        {
            ServiceAutor.WebServiceAutorSoapClient auxAutor = new ServiceAutor.WebServiceAutorSoapClient();
            ServiceCategoria.WebServiceCategoriaSoapClient auxCategoria = new ServiceCategoria.WebServiceCategoriaSoapClient();
            comboAutor.Text = "Selecciona Autor";
            comboCategoria.Text = "Selecciona Categoria";
            DataSet listadoAutores = auxAutor.webMostrarListadoAutor();
            DataSet listadoCategorias = auxCategoria.webMostrarListadoCategoria();

            comboAutor.Items.Clear();
            comboCategoria.Items.Clear();

            for (int i = 0; i < listadoAutores.Tables[0].Rows.Count ; i++)
            {
                comboAutor.Items.Add(listadoAutores.Tables[0].Rows[i]["nombre"].ToString());
            }


            for (int i = 0; i < listadoCategorias.Tables[0].Rows.Count; i++)
            {
                comboCategoria.Items.Add(listadoCategorias.Tables[0].Rows[i]["nombre_genero"].ToString());
            }
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
