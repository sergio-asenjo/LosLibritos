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
    public partial class MultaMes : Form
    {
        public MultaMes()
        {
            InitializeComponent();
        }

        private void MultaMes_Load(object sender, EventArgs e)
        {
            ServiceMulta.WebServiceMultaSoapClient auxServiceMulta = new ServiceMulta.WebServiceMultaSoapClient();
            gridMulta.DataSource = auxServiceMulta.webMostrarMultaMes();
            gridMulta.DataMember = "Multa";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
