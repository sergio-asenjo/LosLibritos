using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminMultasA : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public AdminMultasA()
        {
            InitializeComponent();
        }

        private void AdminMultasA_Load(object sender, EventArgs e)
        {
            var auxMulta = new NegocioMulta();
            GridAdminMultas.DataSource = auxMulta.mostrarTodasMultas();
            GridAdminMultas.DataMember = "Multa";
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
