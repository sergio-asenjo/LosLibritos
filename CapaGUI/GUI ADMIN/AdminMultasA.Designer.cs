
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
            this.lblIdMulta = new System.Windows.Forms.Label();
            this.txtIdMulta = new System.Windows.Forms.TextBox();
            this.btnProcesarMultas = new System.Windows.Forms.Button();
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
            this.GridAdminMultas.ReadOnly = true;
            this.GridAdminMultas.Size = new System.Drawing.Size(437, 187);
            this.GridAdminMultas.TabIndex = 1;
            this.GridAdminMultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAdminMultas_CellClick);
            // 
            // btnPagoMulta
            // 
            this.btnPagoMulta.Location = new System.Drawing.Point(478, 62);
            this.btnPagoMulta.Name = "btnPagoMulta";
            this.btnPagoMulta.Size = new System.Drawing.Size(93, 38);
            this.btnPagoMulta.TabIndex = 2;
            this.btnPagoMulta.Text = "Pagar Multa";
            this.btnPagoMulta.UseVisualStyleBackColor = true;
            this.btnPagoMulta.Click += new System.EventHandler(this.btnPagoMulta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(478, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIdMulta
            // 
            this.lblIdMulta.AutoSize = true;
            this.lblIdMulta.Location = new System.Drawing.Point(475, 39);
            this.lblIdMulta.Name = "lblIdMulta";
            this.lblIdMulta.Size = new System.Drawing.Size(21, 13);
            this.lblIdMulta.TabIndex = 4;
            this.lblIdMulta.Text = "ID:";
            // 
            // txtIdMulta
            // 
            this.txtIdMulta.Enabled = false;
            this.txtIdMulta.Location = new System.Drawing.Point(502, 36);
            this.txtIdMulta.Name = "txtIdMulta";
            this.txtIdMulta.Size = new System.Drawing.Size(69, 20);
            this.txtIdMulta.TabIndex = 5;
            // 
            // btnProcesarMultas
            // 
            this.btnProcesarMultas.Location = new System.Drawing.Point(478, 124);
            this.btnProcesarMultas.Name = "btnProcesarMultas";
            this.btnProcesarMultas.Size = new System.Drawing.Size(93, 29);
            this.btnProcesarMultas.TabIndex = 6;
            this.btnProcesarMultas.Text = "Procesar Multas";
            this.btnProcesarMultas.UseVisualStyleBackColor = true;
            this.btnProcesarMultas.Click += new System.EventHandler(this.btnProcesarMultas_Click);
            // 
            // AdminMultasA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 244);
            this.Controls.Add(this.btnProcesarMultas);
            this.Controls.Add(this.txtIdMulta);
            this.Controls.Add(this.lblIdMulta);
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
        private System.Windows.Forms.Label lblIdMulta;
        private System.Windows.Forms.TextBox txtIdMulta;
        private System.Windows.Forms.Button btnProcesarMultas;
    }
}