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
            NegocioPrestamo auxnegocioprestamo = new NegocioPrestamo();
            
            dataGridView1.DataSource = auxnegocioprestamo.mostrarPrestamosTotal();
            dataGridView1.DataMember = "Prestamo";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
