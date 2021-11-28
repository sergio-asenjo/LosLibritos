using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class SolicitarLibrosC : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private ServiceCliente.Cliente auxclienteprestamo;
        
        public SolicitarLibrosC()
        {
            InitializeComponent();
        }

        public ServiceCliente.Cliente Auxclienteprestamo { get => auxclienteprestamo; set => auxclienteprestamo = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text.Length == 0)
                {
                    MessageBox.Show("ISBN no puede estar vacio.", "Error del Sistema.");
                }
                else if (Auxclienteprestamo.Multa_vigente)
                {
                    MessageBox.Show("¡No puede solicitar libros si tiene multa vigente!", "Error del Sistema.");
                }
                else if (Auxclienteprestamo.Cant_prestamos >= 3)
                {
                    MessageBox.Show("¡No puede solicitar más de 3 libros al mismo tiempo!", "Error del Sistema.");
                }
                else
                {
                    ServiceLibro.WebServiceLibroSoapClient auxServiceLibro = new ServiceLibro.WebServiceLibroSoapClient();
                    ServicePrestamo.WebServicePrestamoSoapClient auxServicePrestamo = new ServicePrestamo.WebServicePrestamoSoapClient();

                    ServiceCliente.WebServiceClienteSoapClient auxCliente = new ServiceCliente.WebServiceClienteSoapClient();

                    if (auxServiceLibro.webConsultarStock(txtBuscar.Text) > 0)
                    {
                        auxServicePrestamo.webAnadirPrestamo(Auxclienteprestamo.Rut, txtBuscar.Text);
                        auxServiceLibro.webEliminarStock(txtBuscar.Text);
                        MessageBox.Show("¡Libro Solicitado!", "Mensaje del Sistema.");
                        auxCliente.webActualizarPrestamosMultas(Auxclienteprestamo.Rut);
                    }
                    else
                    {
                        MessageBox.Show("¡No hay stock de este libro!", "Mensaje del Sistema.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema: " + ex.Message, "Error del Sistema.");
               
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
