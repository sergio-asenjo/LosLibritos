using CapaDTO;
using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MenuCliente : Form
    {
        private Cliente auxclientemenu;
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public Cliente Auxclientemenu { get => auxclientemenu; set => auxclientemenu = value; }

        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnSolicitarL_Click(object sender, EventArgs e)
        {
            SolicitarLibrosC soli1 = new SolicitarLibrosC();
            soli1.Auxclienteprestamo = Auxclientemenu;
            soli1.ShowDialog();
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListaryFC listar1 = new ListaryFC();
            listar1.ShowDialog();
        }

        private void btnAdminUser_Click(object sender, EventArgs e)
        {
            
            AdminUsuarioC admin1 = new AdminUsuarioC();
            admin1.Auxclienteadmin = Auxclientemenu;
            admin1.ShowDialog();
            
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            lblUsuarioLogged.Text = Auxclientemenu.Username;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
            var menuLogin = new Login();
            GC.Collect();
            menuLogin.Show();
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

        private void lblUsuarioLogged_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarioCon_Click(object sender, EventArgs e)
        {

        }
    }
}
