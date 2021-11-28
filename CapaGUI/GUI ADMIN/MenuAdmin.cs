using CapaGUI.GUI_ADMIN;
using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MenuAdmin : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public ServiceEmpleado.Empleado AuxEmpleado { get; set; }

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnAdminLibros_Click(object sender, EventArgs e)
        {
            AdminLibrosA menuadmin = new AdminLibrosA();
            menuadmin.ShowDialog();
        }

        private void btnAdminSoli_Click(object sender, EventArgs e)
        {
            AdminSolicitudesA soliadmin = new AdminSolicitudesA();
            soliadmin.ShowDialog();
        }

        private void btnAdminMultas_Click(object sender, EventArgs e)
        {
            AdminMultasA adminmul = new AdminMultasA();
            adminmul.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            SolicitarInformesA soliinfo = new SolicitarInformesA();
            soliinfo.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
            var menuLogin = new Login();
            GC.Collect();
            menuLogin.Show();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            lblUsuarioLogged.Text = AuxEmpleado.Username;
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
