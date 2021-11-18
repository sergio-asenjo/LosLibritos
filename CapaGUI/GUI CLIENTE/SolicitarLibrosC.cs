using CapaDTO;
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

namespace CapaGUI
{
    public partial class SolicitarLibrosC : Form
    {
        private Cliente auxclienteprestamo;
        public SolicitarLibrosC()
        {
            InitializeComponent();
        }

        public Cliente Auxclienteprestamo { get => auxclienteprestamo; set => auxclienteprestamo = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text.Length == 0)
                {
                    MessageBox.Show("ISBN no puede estar vacio", "Error de sistema");
                }
                else
                {
                    NegocioPrestamo auxnegocioprestamo = new NegocioPrestamo();
                    
                    auxnegocioprestamo.AnadirPrestamo(Auxclienteprestamo.Rut, txtBuscar.Text);

                    NegocioLibro auxnegociolibro = new NegocioLibro();

                    auxnegociolibro.EliminarStock(txtBuscar.Text);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema" + ex.Message, "Error de sistema");
               
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            GC.Collect();
        }
    }
}
