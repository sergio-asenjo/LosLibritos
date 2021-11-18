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

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminSolicitudesA : Form
    {
        private string auxestadopago;
        private string auxisbn;

        public string Auxestadopago { get => auxestadopago; set => auxestadopago = value; }
        public string Auxisbn { get => auxisbn; set => auxisbn = value; }

        public AdminSolicitudesA()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AdminSolicitudesA_Load(object sender, EventArgs e)
        {
            NegocioPrestamo auxnegocioprestamo = new NegocioPrestamo();

            GridPrestamos.DataSource = auxnegocioprestamo.mostrarPrestamosGeneral();
            GridPrestamos.DataMember = "Prestamo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NegocioPrestamo auxnegocioprestamo = new NegocioPrestamo();


            if (Auxestadopago == "Falta Pago")
            {
                MessageBox.Show("Falta Pago para completar la solicitud", "Error de Sistema");
            }
            else
            {
                NegocioLibro auxnegociolibro = new NegocioLibro();

                auxnegocioprestamo.finalizarPrestamo(int.Parse(txtPrueba.Text));
                auxnegociolibro.AgregarStock(Auxisbn);
                MessageBox.Show("Prestamo Finalizado", "Mensaje de Sistema");
                GridPrestamos.Update();
            }
            
        }

        private void GridPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPrestamos.Rows[e.RowIndex];
                txtPrueba.Text = row.Cells["ID"].Value.ToString();
                Auxestadopago = row.Cells["Pendiente de Pago"].Value.ToString();
                Auxisbn = row.Cells["ISBN"].Value.ToString();
            }
        }

        private void GridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPrestamos.Rows[e.RowIndex];
                txtPrueba.Text = row.Cells["ID"].Value.ToString();
                Auxestadopago = row.Cells["Pendiente de Pago"].Value.ToString();
                Auxisbn = row.Cells["ISBN"].Value.ToString();
            }
        }
    }
}
