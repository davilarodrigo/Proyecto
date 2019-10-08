namespace ProyectoPAV.Formularios.Auxiliares
{
    partial class FrmHistorialPrecio
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNuevaCategorias = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridHisotiralPrecio = new System.Windows.Forms.DataGridView();
            this.ComboProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHisotiralPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(521, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNuevaCategorias
            // 
            this.lblNuevaCategorias.AutoSize = true;
            this.lblNuevaCategorias.Location = new System.Drawing.Point(33, 21);
            this.lblNuevaCategorias.Name = "lblNuevaCategorias";
            this.lblNuevaCategorias.Size = new System.Drawing.Size(55, 13);
            this.lblNuevaCategorias.TabIndex = 40;
            this.lblNuevaCategorias.Text = "Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(503, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 49);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridHisotiralPrecio
            // 
            this.dataGridHisotiralPrecio.AllowUserToAddRows = false;
            this.dataGridHisotiralPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHisotiralPrecio.Location = new System.Drawing.Point(23, 58);
            this.dataGridHisotiralPrecio.Name = "dataGridHisotiralPrecio";
            this.dataGridHisotiralPrecio.Size = new System.Drawing.Size(548, 253);
            this.dataGridHisotiralPrecio.TabIndex = 39;
            // 
            // ComboProductos
            // 
            this.ComboProductos.FormattingEnabled = true;
            this.ComboProductos.Location = new System.Drawing.Point(94, 18);
            this.ComboProductos.Name = "ComboProductos";
            this.ComboProductos.Size = new System.Drawing.Size(187, 21);
            this.ComboProductos.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nuevo Historial Precio";
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Location = new System.Drawing.Point(287, 18);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(48, 23);
            this.buttonFiltro.TabIndex = 43;
            this.buttonFiltro.Text = "Filtrar";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.buttonFiltro_Click);
            // 
            // FrmHistorialPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 390);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNuevaCategorias);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridHisotiralPrecio);
            this.Name = "FrmHistorialPrecio";
            this.Text = "Historiales de Precio";
            this.Load += new System.EventHandler(this.FrmHistorialPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHisotiralPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNuevaCategorias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridHisotiralPrecio;
        private System.Windows.Forms.ComboBox ComboProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFiltro;
    }
}