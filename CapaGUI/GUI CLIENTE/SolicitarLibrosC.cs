using CapaDTO;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class SolicitarLibrosC : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private Cliente auxclienteprestamo;
        
        public SolicitarLibrosC()
        {
            InitializeComponent();
        }

        public Cliente Auxclienteprestamo { get => auxclienteprestamo; set => auxclienteprestamo = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text.Length == 0)
                {
                    MessageBox.Show("ISBN no puede estar vacio", "Error de Sistema");
                }
                else
                {
                    NegocioPrestamo auxnegocioprestamo = new NegocioPrestamo();
                    
                    auxnegocioprestamo.AnadirPrestamo(Auxclienteprestamo.Rut, txtBuscar.Text);

                    NegocioLibro auxnegociolibro = new NegocioLibro();

                    auxnegociolibro.EliminarStock(txtBuscar.Text);

                    MessageBox.Show("Libro Solicitado!", "Mensaje de Sistema");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema" + ex.Message, "Error de Sistema");
               
            }
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
