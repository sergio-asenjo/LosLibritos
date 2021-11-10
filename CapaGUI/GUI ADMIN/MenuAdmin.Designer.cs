
namespace CapaGUI
{
    partial class MenuAdmin
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
            this.btnAdminMultas = new System.Windows.Forms.Button();
            this.btnAdminSoli = new System.Windows.Forms.Button();
            this.btnAdminLibros = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminMultas
            // 
            this.btnAdminMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMultas.Location = new System.Drawing.Point(146, 176);
            this.btnAdminMultas.Name = "btnAdminMultas";
            this.btnAdminMultas.Size = new System.Drawing.Size(205, 34);
            this.btnAdminMultas.TabIndex = 5;
            this.btnAdminMultas.Text = "Administrar Multas";
            this.btnAdminMultas.UseVisualStyleBackColor = true;
            this.btnAdminMultas.Click += new System.EventHandler(this.btnAdminMultas_Click);
            // 
            // btnAdminSoli
            // 
            this.btnAdminSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSoli.Location = new System.Drawing.Point(146, 114);
            this.btnAdminSoli.Name = "btnAdminSoli";
            this.btnAdminSoli.Size = new System.Drawing.Size(205, 34);
            this.btnAdminSoli.TabIndex = 4;
            this.btnAdminSoli.Text = "Administrar Solicitudes";
            this.btnAdminSoli.UseVisualStyleBackColor = true;
            this.btnAdminSoli.Click += new System.EventHandler(this.btnAdminSoli_Click);
            // 
            // btnAdminLibros
            // 
            this.btnAdminLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLibros.Location = new System.Drawing.Point(146, 52);
            this.btnAdminLibros.Name = "btnAdminLibros";
            this.btnAdminLibros.Size = new System.Drawing.Size(205, 34);
            this.btnAdminLibros.TabIndex = 3;
            this.btnAdminLibros.Text = "Administrar Libros";
            this.btnAdminLibros.UseVisualStyleBackColor = true;
            this.btnAdminLibros.Click += new System.EventHandler(this.btnAdminLibros_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Location = new System.Drawing.Point(146, 238);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(205, 34);
            this.btnInformes.TabIndex = 6;
            this.btnInformes.Text = "Solicitar Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 339);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnAdminMultas);
            this.Controls.Add(this.btnAdminSoli);
            this.Controls.Add(this.btnAdminLibros);
            this.Name = "MenuAdmin";
            this.Text = "Menu Administración";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminMultas;
        private System.Windows.Forms.Button btnAdminSoli;
        private System.Windows.Forms.Button btnAdminLibros;
        private System.Windows.Forms.Button btnInformes;
    }
}