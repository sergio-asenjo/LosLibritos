
namespace CapaGUI.GUI_ADMIN
{
    partial class AdminSolicitudesA
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
            this.GridPrestamos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarPrestamo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtIdAPagar = new System.Windows.Forms.TextBox();
            this.lblIdMulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos";
            // 
            // GridPrestamos
            // 
            this.GridPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPrestamos.Location = new System.Drawing.Point(13, 32);
            this.GridPrestamos.Name = "GridPrestamos";
            this.GridPrestamos.ReadOnly = true;
            this.GridPrestamos.Size = new System.Drawing.Size(566, 150);
            this.GridPrestamos.TabIndex = 1;
            this.GridPrestamos.TabStop = false;
            this.GridPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPrestamos_CellClick);
            this.GridPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPrestamos_CellContentClick);
            // 
            // btnFinalizarPrestamo
            // 
            this.btnFinalizarPrestamo.Location = new System.Drawing.Point(627, 62);
            this.btnFinalizarPrestamo.Name = "btnFinalizarPrestamo";
            this.btnFinalizarPrestamo.Size = new System.Drawing.Size(109, 34);
            this.btnFinalizarPrestamo.TabIndex = 2;
            this.btnFinalizarPrestamo.Text = "Finalizar Prestamo";
            this.btnFinalizarPrestamo.UseVisualStyleBackColor = true;
            this.btnFinalizarPrestamo.Click += new System.EventHandler(this.btnFinalizarPrestamo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(627, 148);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtIdAPagar
            // 
            this.txtIdAPagar.Location = new System.Drawing.Point(659, 32);
            this.txtIdAPagar.Name = "txtIdAPagar";
            this.txtIdAPagar.Size = new System.Drawing.Size(77, 20);
            this.txtIdAPagar.TabIndex = 4;
            // 
            // lblIdMulta
            // 
            this.lblIdMulta.AutoSize = true;
            this.lblIdMulta.Location = new System.Drawing.Point(629, 35);
            this.lblIdMulta.Name = "lblIdMulta";
            this.lblIdMulta.Size = new System.Drawing.Size(24, 13);
            this.lblIdMulta.TabIndex = 5;
            this.lblIdMulta.Text = "ID: ";
            // 
            // AdminSolicitudesA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 199);
            this.Controls.Add(this.lblIdMulta);
            this.Controls.Add(this.txtIdAPagar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFinalizarPrestamo);
            this.Controls.Add(this.GridPrestamos);
            this.Controls.Add(this.label1);
            this.Name = "AdminSolicitudesA";
            this.Text = "Administrar Solicitudes";
            this.Load += new System.EventHandler(this.AdminSolicitudesA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridPrestamos;
        private System.Windows.Forms.Button btnFinalizarPrestamo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdAPagar;
        private System.Windows.Forms.Label lblIdMulta;
    }
}