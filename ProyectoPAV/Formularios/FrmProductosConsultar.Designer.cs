namespace ProyectoPAV.Formularios
{
    partial class FrmProductosConsultar
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
            this.GropuBoxFiltros = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblMarca = new System.Windows.Forms.Label();
            this.TextBoxMarca = new System.Windows.Forms.TextBox();
            this.ComboCategorias = new System.Windows.Forms.ComboBox();
            this.DataGridProductos = new System.Windows.Forms.DataGridView();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmStockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TextBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.GropuBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // GropuBoxFiltros
            // 
            this.GropuBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GropuBoxFiltros.Controls.Add(this.BtnBuscar);
            this.GropuBoxFiltros.Controls.Add(this.LblMarca);
            this.GropuBoxFiltros.Controls.Add(this.TextBoxMarca);
            this.GropuBoxFiltros.Controls.Add(this.ComboCategorias);
            this.GropuBoxFiltros.Controls.Add(this.DataGridProductos);
            this.GropuBoxFiltros.Controls.Add(this.LblCategoria);
            this.GropuBoxFiltros.Controls.Add(this.LblNombre);
            this.GropuBoxFiltros.Controls.Add(this.TextBoxNombreProducto);
            this.GropuBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.GropuBoxFiltros.Name = "GropuBoxFiltros";
            this.GropuBoxFiltros.Size = new System.Drawing.Size(770, 432);
            this.GropuBoxFiltros.TabIndex = 9;
            this.GropuBoxFiltros.TabStop = false;
            this.GropuBoxFiltros.Text = "Filtros";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Search_256x256;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Location = new System.Drawing.Point(408, 57);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(48, 48);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(58, 49);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(37, 13);
            this.LblMarca.TabIndex = 9;
            this.LblMarca.Text = "Marca";
            // 
            // TextBoxMarca
            // 
            this.TextBoxMarca.Location = new System.Drawing.Point(101, 46);
            this.TextBoxMarca.Name = "TextBoxMarca";
            this.TextBoxMarca.Size = new System.Drawing.Size(291, 20);
            this.TextBoxMarca.TabIndex = 8;
            // 
            // ComboCategorias
            // 
            this.ComboCategorias.FormattingEnabled = true;
            this.ComboCategorias.Location = new System.Drawing.Point(101, 72);
            this.ComboCategorias.Name = "ComboCategorias";
            this.ComboCategorias.Size = new System.Drawing.Size(291, 21);
            this.ComboCategorias.TabIndex = 6;
            // 
            // DataGridProductos
            // 
            this.DataGridProductos.AllowUserToAddRows = false;
            this.DataGridProductos.AllowUserToDeleteRows = false;
            this.DataGridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNombre,
            this.ClmMarca,
            this.ClmCategoria,
            this.ClmTalle,
            this.ClmStockDisponible});
            this.DataGridProductos.Location = new System.Drawing.Point(6, 111);
            this.DataGridProductos.Name = "DataGridProductos";
            this.DataGridProductos.ReadOnly = true;
            this.DataGridProductos.Size = new System.Drawing.Size(758, 315);
            this.DataGridProductos.TabIndex = 5;
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "Nombre";
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.ReadOnly = true;
            this.ClmNombre.Width = 200;
            // 
            // ClmMarca
            // 
            this.ClmMarca.HeaderText = "Marca";
            this.ClmMarca.Name = "ClmMarca";
            this.ClmMarca.ReadOnly = true;
            this.ClmMarca.Width = 150;
            // 
            // ClmCategoria
            // 
            this.ClmCategoria.HeaderText = "Categoría";
            this.ClmCategoria.Name = "ClmCategoria";
            this.ClmCategoria.ReadOnly = true;
            this.ClmCategoria.Width = 150;
            // 
            // ClmTalle
            // 
            this.ClmTalle.HeaderText = "Talle";
            this.ClmTalle.Name = "ClmTalle";
            this.ClmTalle.ReadOnly = true;
            // 
            // ClmStockDisponible
            // 
            this.ClmStockDisponible.HeaderText = "Stock Disponible";
            this.ClmStockDisponible.Name = "ClmStockDisponible";
            this.ClmStockDisponible.ReadOnly = true;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(41, 75);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(54, 13);
            this.LblCategoria.TabIndex = 2;
            this.LblCategoria.Text = "Categoría";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(51, 23);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // TextBoxNombreProducto
            // 
            this.TextBoxNombreProducto.Location = new System.Drawing.Point(101, 20);
            this.TextBoxNombreProducto.Name = "TextBoxNombreProducto";
            this.TextBoxNombreProducto.Size = new System.Drawing.Size(291, 20);
            this.TextBoxNombreProducto.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 459);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(50, 50);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(732, 459);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Location = new System.Drawing.Point(124, 459);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(50, 50);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Edit_256x256;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnModificar.Location = new System.Drawing.Point(68, 459);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(50, 50);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FrmProductosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 521);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.GropuBoxFiltros);
            this.Name = "FrmProductosConsultar";
            this.Text = "FrmProductosConsultar";
            this.GropuBoxFiltros.ResumeLayout(false);
            this.GropuBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.GroupBox GropuBoxFiltros;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox TextBoxMarca;
        private System.Windows.Forms.ComboBox ComboCategorias;
        private System.Windows.Forms.DataGridView DataGridProductos;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TextBoxNombreProducto;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmStockDisponible;
    }
}