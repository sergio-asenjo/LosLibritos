using CapaDTO;
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
    public partial class MenuCliente : Form
    {
        private Cliente auxclientemenu;

        public Cliente Auxclientemenu { get => auxclientemenu; set => auxclientemenu = value; }

        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnSolicitarL_Click(object sender, EventArgs e)
        {
            SolicitarLibrosC soli1 = new SolicitarLibrosC();
            soli1.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListaryFC listar1 = new ListaryFC();
            listar1.Show();
        }

        private void btnAdminUser_Click(object sender, EventArgs e)
        {
            
            AdminUsuarioC admin1 = new AdminUsuarioC();
            admin1.Auxclienteadmin = Auxclientemenu;
            admin1.Show();
            
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
