using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_CLIENTE.GUI_INFORMES
{
    public partial class MultaSemana : Form
    {
        public MultaSemana()
        {
            InitializeComponent();
        }

        private void MultaSemana_Load(object sender, EventArgs e)
        {
            NegocioMulta negocioMulta = new NegocioMulta();
            gridMulta.DataSource = negocioMulta.mostrarMultaSemana();
            gridMulta.DataMember = "Multa";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
