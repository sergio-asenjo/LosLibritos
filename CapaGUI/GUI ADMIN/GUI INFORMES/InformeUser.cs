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
    public partial class InformeUser : Form
    {
        public InformeUser()
        {
            InitializeComponent();
        }

        private void InformeUser_Load(object sender, EventArgs e)
        {
            NegocioCliente auxnegociousuario = new NegocioCliente();
            GridCliente.DataSource = auxnegociousuario.mostrarTodosClientes();
            GridCliente.DataMember = "Usuario";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            NegocioCliente auxnegociousuario = new NegocioCliente();
            GridCliente.DataSource = auxnegociousuario.mostrarClienteFiltro(txtFiltro.Text);
            GridCliente.DataMember = "Usuario";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Dispose();
        }
    }
}
