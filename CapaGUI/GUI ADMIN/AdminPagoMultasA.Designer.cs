
namespace CapaGUI.GUI_ADMIN
{
    partial class AdminPagoMultasA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIdMulta = new System.Windows.Forms.Label();
            this.txtIdMulta = new System.Windows.Forms.TextBox();
            this.lblDiasAtraso = new System.Windows.Forms.Label();
            this.txtDiasAtrasados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(103, 162);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 40);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(223, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIdMulta
            // 
            this.lblIdMulta.AutoSize = true;
            this.lblIdMulta.Location = new System.Drawing.Point(59, 42);
            this.lblIdMulta.Name = "lblIdMulta";
            this.lblIdMulta.Size = new System.Drawing.Size(50, 13);
            this.lblIdMulta.TabIndex = 2;
            this.lblIdMulta.Text = "ID Multa:";
            // 
            // txtIdMulta
            // 
            this.txtIdMulta.Enabled = false;
            this.txtIdMulta.Location = new System.Drawing.Point(115, 39);
            this.txtIdMulta.Name = "txtIdMulta";
            this.txtIdMulta.Size = new System.Drawing.Size(54, 20);
            this.txtIdMulta.TabIndex = 3;
            // 
            // lblDiasAtraso
            // 
            this.lblDiasAtraso.AutoSize = true;
            this.lblDiasAtraso.Location = new System.Drawing.Point(26, 78);
            this.lblDiasAtraso.Name = "lblDiasAtraso";
            this.lblDiasAtraso.Size = new System.Drawing.Size(83, 13);
            this.lblDiasAtraso.TabIndex = 4;
            this.lblDiasAtraso.Text = "Días Atrasados:";
            // 
            // txtDiasAtrasados
            // 
            this.txtDiasAtrasados.Enabled = false;
            this.txtDiasAtrasados.Location = new System.Drawing.Point(114, 75);
            this.txtDiasAtrasados.Name = "txtDiasAtrasados";
            this.txtDiasAtrasados.Size = new System.Drawing.Size(55, 20);
            this.txtDiasAtrasados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Monto a Pagar:";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Enabled = false;
            this.txtMontoPago.Location = new System.Drawing.Point(114, 112);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPago.TabIndex = 7;
            // 
            // AdminPagoMultasA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 267);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiasAtrasados);
            this.Controls.Add(this.lblDiasAtraso);
            this.Controls.Add(this.txtIdMulta);
            this.Controls.Add(this.lblIdMulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagar);
            this.Name = "AdminPagoMultasA";
            this.Text = "AdminPagoMultasA";
            this.Load += new System.EventHandler(this.AdminPagoMultasA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIdMulta;
        private System.Windows.Forms.TextBox txtIdMulta;
        private System.Windows.Forms.Label lblDiasAtraso;
        private System.Windows.Forms.TextBox txtDiasAtrasados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoPago;
    }
}