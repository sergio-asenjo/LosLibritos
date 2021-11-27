using CapaDTO;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaGUI.GUI_ADMIN
{
    public partial class AdminPagoMultasA : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public Multa AuxMulta { get; set; }

        public AdminPagoMultasA()
        {
            InitializeComponent();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        private void AdminPagoMultasA_Load(object sender, EventArgs e)
        {
            txtIdMulta.Text = Convert.ToString(AuxMulta.Id_multa);
            txtDiasAtrasados.Text = Convert.ToString(AuxMulta.Dias_atraso);
            txtMontoPago.Text = Convert.ToString(AuxMulta.Monto_pago);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var auxNegocioMulta = new NegocioMulta();
            try
            {
                auxNegocioMulta.pagarMulta(AuxMulta.Id_multa);
                MessageBox.Show("¡Multa pagada!", "Mensaje del Sistema.");
                Dispose();
                GC.Collect();
            }
            catch
            {
                MessageBox.Show("Error al pagar multa", "Mensaje del Sistema.");
            }
        }
    }
}
