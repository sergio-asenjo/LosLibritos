
namespace CapaGUI.GUI_ADMIN
{
    partial class SolicitarInformesA
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
            this.btnMultaSemana = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMultaMes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultaSemana
            // 
            this.btnMultaSemana.Location = new System.Drawing.Point(74, 40);
            this.btnMultaSemana.Name = "btnMultaSemana";
            this.btnMultaSemana.Size = new System.Drawing.Size(146, 37);
            this.btnMultaSemana.TabIndex = 0;
            this.btnMultaSemana.Text = "Informe de Multas Semanales";
            this.btnMultaSemana.UseVisualStyleBackColor = true;
            this.btnMultaSemana.Click += new System.EventHandler(this.btnMultaSemana_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Informe de Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Informe de Solicitudes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMultaMes
            // 
            this.btnMultaMes.Location = new System.Drawing.Point(74, 104);
            this.btnMultaMes.Name = "btnMultaMes";
            this.btnMultaMes.Size = new System.Drawing.Size(146, 37);
            this.btnMultaMes.TabIndex = 3;
            this.btnMultaMes.Text = "Informe de Multas Mensuales";
            this.btnMultaMes.UseVisualStyleBackColor = true;
            this.btnMultaMes.Click += new System.EventHandler(this.btnMultaMes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(108, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SolicitarInformesA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 384);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMultaMes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMultaSemana);
            this.Name = "SolicitarInformesA";
            this.Text = "Informes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMultaSemana;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMultaMes;
        private System.Windows.Forms.Button btnSalir;
    }
}