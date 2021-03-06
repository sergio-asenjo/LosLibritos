using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MenuCliente : Form
    {
        private ServiceCliente.Cliente auxclientemenu;
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public ServiceCliente.Cliente Auxclientemenu { get => auxclientemenu; set => auxclientemenu = value; }

        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnSolicitarL_Click(object sender, EventArgs e)
        {
            SolicitarLibrosC soli1 = new SolicitarLibrosC();
            soli1.Auxclienteprestamo = Auxclientemenu;
            soli1.ShowDialog();
            MenuCliente_Load(sender, e);
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
            ServicePrestamo.WebServicePrestamoSoapClient auxPrestamo = new ServicePrestamo.WebServicePrestamoSoapClient();
            ServiceCliente.WebServiceClienteSoapClient auxCliente = new ServiceCliente.WebServiceClienteSoapClient();
            auxCliente.webActualizarPrestamosMultas(Auxclientemenu.Rut);
            var dataSetPrestamos = auxPrestamo.webVerificarEstadoPrestamos(Auxclientemenu.Rut);
            if (dataSetPrestamos != null)
            {
                Auxclientemenu.Cant_prestamos = Convert.ToInt32(dataSetPrestamos.Tables[0].Rows[0]["cantidad_prestados"].ToString());
                Auxclientemenu.Multa_vigente =  (bool) dataSetPrestamos.Tables[0].Rows[0]["multa_vigente"];
            }
            lblUsuarioLogged.Text = Auxclientemenu.Username;
            lblMultaActiva.Text = Auxclientemenu.Multa_vigente ? "Multa Pendiente" : "Sin Multa Pendiente.";
            lblPrestamosActivos.Text = Auxclientemenu.Cant_prestamos.ToString();
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
    }
}
