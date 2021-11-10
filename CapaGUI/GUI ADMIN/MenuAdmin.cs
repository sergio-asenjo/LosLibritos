using CapaGUI.GUI_ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MenuAdmin : Form
    {
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
    }
}
