
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
            this.lblUsuarioCon = new System.Windows.Forms.Label();
            this.lblUsuarioLogged = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
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
            this.btnAdminUser.Text = "Perfil de Usuario";
            this.btnAdminUser.UseVisualStyleBackColor = true;
            this.btnAdminUser.Click += new System.EventHandler(this.btnAdminUser_Click);
            // 
            // lblUsuarioCon
            // 
            this.lblUsuarioCon.AutoSize = true;
            this.lblUsuarioCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCon.Location = new System.Drawing.Point(12, 253);
            this.lblUsuarioCon.Name = "lblUsuarioCon";
            this.lblUsuarioCon.Size = new System.Drawing.Size(119, 13);
            this.lblUsuarioCon.TabIndex = 3;
            this.lblUsuarioCon.Text = "Usuario Conectado:";
            // 
            // lblUsuarioLogged
            // 
            this.lblUsuarioLogged.AutoSize = true;
            this.lblUsuarioLogged.Location = new System.Drawing.Point(128, 253);
            this.lblUsuarioLogged.Name = "lblUsuarioLogged";
            this.lblUsuarioLogged.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioLogged.TabIndex = 4;
            this.lblUsuarioLogged.Text = "Usuario";
            this.lblUsuarioLogged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(293, 247);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(106, 24);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 280);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblUsuarioLogged);
            this.Controls.Add(this.lblUsuarioCon);
            this.Controls.Add(this.btnAdminUser);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSolicitarL);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitarL;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAdminUser;
        private System.Windows.Forms.Label lblUsuarioCon;
        private System.Windows.Forms.Label lblUsuarioLogged;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}