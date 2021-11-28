using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN.GUI_INFORMES
{
    public partial class InformeUser : Form
    {
        public InformeUser()
        {
            InitializeComponent();
        }

        private void InformeUser_Load(object sender, EventArgs e)
        {
            ServiceCliente.WebServiceClienteSoapClient auxnegociousuario = new ServiceCliente.WebServiceClienteSoapClient();
            GridCliente.DataSource = auxnegociousuario.webMostrarTodosClientes();
            GridCliente.DataMember = "Usuario";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ServiceCliente.WebServiceClienteSoapClient auxnegociousuario = new ServiceCliente.WebServiceClienteSoapClient();
            GridCliente.DataSource = auxnegociousuario.webMostrarClienteFiltro(txtFiltro.Text);
            GridCliente.DataMember = "Usuario";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
