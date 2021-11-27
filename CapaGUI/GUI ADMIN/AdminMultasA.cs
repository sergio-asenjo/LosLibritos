using CapaNegocio;
using CapaDTO;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminMultasA : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        
        public int Dias_atraso { get; set; }

        public AdminMultasA()
        {
            InitializeComponent();
        }

        private void AdminMultasA_Load(object sender, EventArgs e)
        {
            var auxMulta = new NegocioMulta();
            GridAdminMultas.DataSource = auxMulta.mostrarTodasMultas();
            GridAdminMultas.DataMember = "Multa";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            GC.Collect();
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

        private void btnPagoMulta_Click(object sender, EventArgs e)
        {
            if (txtIdMulta.Text != "Pagada" && txtIdMulta.Text != "")
            {
                var auxMulta = new Multa();
                auxMulta.Id_multa = Convert.ToInt32(txtIdMulta.Text);
                auxMulta.Dias_atraso = Dias_atraso;

                var auxPagoMultas = new AdminPagoMultasA();
                auxPagoMultas.AuxMulta = auxMulta;
                auxPagoMultas.ShowDialog();
                AdminMultasA_Load(sender, e);
            }
            else
            {
                MessageBox.Show("¡Multa ya pagada!", "Mensaje del Sistema.");
            }
        }

        private void GridAdminMultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridAdminMultas.Rows[e.RowIndex];
                if (row.Cells["Pendiente Pago"].Value.ToString() == "Si")
                {
                    txtIdMulta.Text = row.Cells["ID"].Value.ToString();
                    Dias_atraso = Convert.ToInt32(row.Cells["Dias Atraso"].Value.ToString());
                }
                else if (row.Cells["Pendiente Pago"].Value.ToString() == "No")
                {
                    txtIdMulta.Text = "Pagada";
                }
            }
        }
    }
}
