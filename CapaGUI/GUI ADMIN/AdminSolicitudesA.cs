using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminSolicitudesA : Form
    {
        private string auxestadopago;
        private string auxisbn;

        public string Auxestadopago { get => auxestadopago; set => auxestadopago = value; }
        public string Auxisbn { get => auxisbn; set => auxisbn = value; }

        private const int CP_NOCLOSE_BUTTON = 0x200;

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
            ServicePrestamo.WebServicePrestamoSoapClient auxnegocioprestamo = new ServicePrestamo.WebServicePrestamoSoapClient();

            GridPrestamos.DataSource = auxnegocioprestamo.webMostrarPrestamosGeneral();
            GridPrestamos.DataMember = "Prestamo";
        }

        private void btnFinalizarPrestamo_Click(object sender, EventArgs e)
        {
            ServicePrestamo.WebServicePrestamoSoapClient auxnegocioprestamo = new ServicePrestamo.WebServicePrestamoSoapClient();


            if (Auxestadopago == "Falta Pago")
            {
                MessageBox.Show("Falta Pago para completar la solicitud", "Error de Sistema");
            }
            else
            {
                NegocioLibro auxnegociolibro = new NegocioLibro();

                auxnegocioprestamo.webFinalizarPrestamo(int.Parse(txtIdAPagar.Text));
                auxnegociolibro.AgregarStock(Auxisbn);
                MessageBox.Show("Prestamo Finalizado", "Mensaje de Sistema");
                AdminSolicitudesA_Load(sender, e);
            }
            
        }

        private void GridPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPrestamos.Rows[e.RowIndex];
                txtIdAPagar.Text = row.Cells["ID"].Value.ToString();
                Auxestadopago = row.Cells["Pendiente de Pago"].Value.ToString();
                Auxisbn = row.Cells["ISBN"].Value.ToString();
            }
        }

        private void GridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPrestamos.Rows[e.RowIndex];
                txtIdAPagar.Text = row.Cells["ID"].Value.ToString();
                Auxestadopago = row.Cells["Pendiente de Pago"].Value.ToString();
                Auxisbn = row.Cells["ISBN"].Value.ToString();
            }
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
