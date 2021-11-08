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
    }
}
