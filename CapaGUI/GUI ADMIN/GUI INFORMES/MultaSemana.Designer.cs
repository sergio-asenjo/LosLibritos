namespace CapaGUI.GUI_CLIENTE.GUI_INFORMES
{
    partial class MultaSemana
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
            this.gridMulta = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMulta
            // 
            this.gridMulta.AllowUserToAddRows = false;
            this.gridMulta.AllowUserToDeleteRows = false;
            this.gridMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMulta.Location = new System.Drawing.Point(12, 12);
            this.gridMulta.Name = "gridMulta";
            this.gridMulta.ReadOnly = true;
            this.gridMulta.Size = new System.Drawing.Size(238, 240);
            this.gridMulta.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(293, 118);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MultaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 265);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridMulta);
            this.Name = "MultaSemana";
            this.Text = "Multa Semana";
            this.Load += new System.EventHandler(this.MultaSemana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMulta;
        private System.Windows.Forms.Button btnSalir;
    }
}