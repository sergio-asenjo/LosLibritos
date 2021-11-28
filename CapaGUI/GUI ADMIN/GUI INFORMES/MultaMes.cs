using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN.GUI_INFORMES
{
    public partial class MultaMes : Form
    {
        public MultaMes()
        {
            InitializeComponent();
        }

        private void MultaMes_Load(object sender, EventArgs e)
        {
            NegocioMulta negocioMulta = new NegocioMulta();
            gridMulta.DataSource = negocioMulta.mostrarMultaMes();
            gridMulta.DataMember = "Multa";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
