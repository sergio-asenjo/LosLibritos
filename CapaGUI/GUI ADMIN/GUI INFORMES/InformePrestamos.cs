using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN.GUI_INFORMES
{
    public partial class InformePrestamos : Form
    {
        public InformePrestamos()
        {
            InitializeComponent();
        }

        private void InformePrestamos_Load(object sender, EventArgs e)
        {
            ServicePrestamo.WebServicePrestamoSoapClient auxnegocioprestamo = new ServicePrestamo.WebServicePrestamoSoapClient();
            
            dataGridView1.DataSource = auxnegocioprestamo.webMostrarPrestamosTotal();
            dataGridView1.DataMember = "Prestamo";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
