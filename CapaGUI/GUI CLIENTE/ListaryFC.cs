using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class ListaryFC : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public ListaryFC()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = txtBusqueda.Text;
                var nLibro = new ServiceLibro.WebServiceLibroSoapClient();

                if (rdoTitulo.Checked)
                {
                    gridLibros.DataSource = nLibro.webFiltrarTitulo(busqueda);
                    gridLibros.DataMember = "Libro";
                }
                else if (rdoAutor.Checked)
                {
                    gridLibros.DataSource = nLibro.webFiltrarAutor(busqueda);
                    gridLibros.DataMember = "Libro";
                }
                else if (rdoCategoria.Checked)
                {
                    gridLibros.DataSource = nLibro.webFiltrarCategoria(busqueda);
                    gridLibros.DataMember = "Libro";
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show("Datos Erroneos. " + ex.Message, "Mensaje de sistema");
            }
        }

        private void ListaryFC_Load(object sender, EventArgs e)
        {
            ServiceLibro.WebServiceLibroSoapClient auxServiceLibro = new ServiceLibro.WebServiceLibroSoapClient();
            this.gridLibros.DataSource = auxServiceLibro.webMostrarLibros();
            this.gridLibros.DataMember = "Libro";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            GC.Collect();
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
