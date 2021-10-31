
namespace CapaGUI
{
    partial class MenuCliente
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
            this.btnSolicitarL = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAdminUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolicitarL
            // 
            this.btnSolicitarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarL.Location = new System.Drawing.Point(106, 28);
            this.btnSolicitarL.Name = "btnSolicitarL";
            this.btnSolicitarL.Size = new System.Drawing.Size(184, 34);
            this.btnSolicitarL.TabIndex = 0;
            this.btnSolicitarL.Text = "Solicitar Libros";
            this.btnSolicitarL.UseVisualStyleBackColor = true;
            this.btnSolicitarL.Click += new System.EventHandler(this.btnSolicitarL_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(106, 92);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(184, 34);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Lista de Libros";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAdminUser
            // 
            this.btnAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUser.Location = new System.Drawing.Point(106, 156);
            this.btnAdminUser.Name = "btnAdminUser";
            this.btnAdminUser.Size = new System.Drawing.Size(184, 34);
            this.btnAdminUser.TabIndex = 2;
            this.btnAdminUser.Text = "Administrar Usuario";
            this.btnAdminUser.UseVisualStyleBackColor = true;
            this.btnAdminUser.Click += new System.EventHandler(this.btnAdminUser_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 241);
            this.Controls.Add(this.btnAdminUser);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSolicitarL);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitarL;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAdminUser;
    }
}