
namespace CapaGUI.GUI_ADMIN
{
    partial class AdminMultasA
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
            this.label1 = new System.Windows.Forms.Label();
            this.GridAdminMultas = new System.Windows.Forms.DataGridView();
            this.btnPagoMulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdminMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multas";
            // 
            // GridAdminMultas
            // 
            this.GridAdminMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdminMultas.Location = new System.Drawing.Point(13, 31);
            this.GridAdminMultas.Name = "GridAdminMultas";
            this.GridAdminMultas.Size = new System.Drawing.Size(402, 150);
            this.GridAdminMultas.TabIndex = 1;
            // 
            // btnPagoMulta
            // 
            this.btnPagoMulta.Location = new System.Drawing.Point(454, 48);
            this.btnPagoMulta.Name = "btnPagoMulta";
            this.btnPagoMulta.Size = new System.Drawing.Size(93, 38);
            this.btnPagoMulta.TabIndex = 2;
            this.btnPagoMulta.Text = "Pagar Multa";
            this.btnPagoMulta.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(454, 110);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AdminMultasA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 206);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagoMulta);
            this.Controls.Add(this.GridAdminMultas);
            this.Controls.Add(this.label1);
            this.Name = "AdminMultasA";
            this.Text = "Administrar Multas";
            this.Load += new System.EventHandler(this.AdminMultasA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdminMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAdminMultas;
        private System.Windows.Forms.Button btnPagoMulta;
        private System.Windows.Forms.Button btnSalir;
    }
}