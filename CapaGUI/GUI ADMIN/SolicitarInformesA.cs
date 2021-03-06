using CapaGUI.GUI_ADMIN.GUI_INFORMES;
using CapaGUI.GUI_CLIENTE.GUI_INFORMES;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN
{
    public partial class SolicitarInformesA : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public SolicitarInformesA()
        {
            InitializeComponent();
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

        private void btnMultaSemana_Click(object sender, EventArgs e)
        {
            MultaSemana menusemana = new MultaSemana();
            menusemana.ShowDialog();

        }

        private void btnMultaMes_Click(object sender, EventArgs e)
        {
            MultaMes menumes = new MultaMes();
            menumes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformeUser menuuser = new InformeUser();
            menuuser.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformePrestamos menuprestamos = new InformePrestamos();
            menuprestamos.ShowDialog();
        }
    }
}
