
namespace CapaGUI
{
    partial class ListaryFC
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gridLibros = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdoAutor = new System.Windows.Forms.RadioButton();
            this.rdoCategoria = new System.Windows.Forms.RadioButton();
            this.rdoTitulo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Búsqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(111, 21);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(389, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(528, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gridLibros
            // 
            this.gridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLibros.Location = new System.Drawing.Point(15, 101);
            this.gridLibros.Name = "gridLibros";
            this.gridLibros.Size = new System.Drawing.Size(588, 189);
            this.gridLibros.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(514, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdoAutor
            // 
            this.rdoAutor.AutoSize = true;
            this.rdoAutor.Location = new System.Drawing.Point(77, 19);
            this.rdoAutor.Name = "rdoAutor";
            this.rdoAutor.Size = new System.Drawing.Size(50, 17);
            this.rdoAutor.TabIndex = 5;
            this.rdoAutor.Text = "Autor";
            this.rdoAutor.UseVisualStyleBackColor = true;
            // 
            // rdoCategoria
            // 
            this.rdoCategoria.AutoSize = true;
            this.rdoCategoria.Location = new System.Drawing.Point(133, 19);
            this.rdoCategoria.Name = "rdoCategoria";
            this.rdoCategoria.Size = new System.Drawing.Size(72, 17);
            this.rdoCategoria.TabIndex = 6;
            this.rdoCategoria.Text = "Categoría";
            this.rdoCategoria.UseVisualStyleBackColor = true;
            // 
            // rdoTitulo
            // 
            this.rdoTitulo.AutoSize = true;
            this.rdoTitulo.Checked = true;
            this.rdoTitulo.Location = new System.Drawing.Point(18, 19);
            this.rdoTitulo.Name = "rdoTitulo";
            this.rdoTitulo.Size = new System.Drawing.Size(53, 17);
            this.rdoTitulo.TabIndex = 7;
            this.rdoTitulo.TabStop = true;
            this.rdoTitulo.Text = "Título";
            this.rdoTitulo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTitulo);
            this.groupBox1.Controls.Add(this.rdoCategoria);
            this.groupBox1.Controls.Add(this.rdoAutor);
            this.groupBox1.Location = new System.Drawing.Point(111, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // ListaryFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridLibros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "ListaryFC";
            this.Text = "Listado de Libros";
            this.Load += new System.EventHandler(this.ListaryFC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView gridLibros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdoAutor;
        private System.Windows.Forms.RadioButton rdoCategoria;
        private System.Windows.Forms.RadioButton rdoTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}