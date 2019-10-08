namespace ProyectoPAV.Formularios.Transacciones
{
    partial class FrmProductosTransacciones
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.botonNuevoProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.botonBuscarProducto = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(786, 498);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 63;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(730, 498);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 62;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // botonNuevoProducto
            // 
            this.botonNuevoProducto.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.botonNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonNuevoProducto.Location = new System.Drawing.Point(602, 23);
            this.botonNuevoProducto.Name = "botonNuevoProducto";
            this.botonNuevoProducto.Size = new System.Drawing.Size(51, 51);
            this.botonNuevoProducto.TabIndex = 64;
            this.botonNuevoProducto.UseVisualStyleBackColor = true;
            this.botonNuevoProducto.Click += new System.EventHandler(this.botonNuevoProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Nuevo Producto";
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(18, 124);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.Size = new System.Drawing.Size(818, 368);
            this.dataGridProductos.TabIndex = 66;
            // 
            // botonBuscarProducto
            // 
            this.botonBuscarProducto.Location = new System.Drawing.Point(286, 50);
            this.botonBuscarProducto.Name = "botonBuscarProducto";
            this.botonBuscarProducto.Size = new System.Drawing.Size(96, 26);
            this.botonBuscarProducto.TabIndex = 16;
            this.botonBuscarProducto.Text = "Filtrar";
            this.botonBuscarProducto.UseVisualStyleBackColor = true;
            this.botonBuscarProducto.Click += new System.EventHandler(this.botonBuscarProducto_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 58);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // comboCategorias
            // 
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(82, 84);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(189, 21);
            this.comboCategorias.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 87);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Location = new System.Drawing.Point(82, 20);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(189, 20);
            this.textBoxNombreProducto.TabIndex = 11;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(82, 54);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(189, 20);
            this.textBoxMarca.TabIndex = 12;
            // 
            // FrmProductosTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.ControlBox = false;
            this.Controls.Add(this.botonBuscarProducto);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonNuevoProducto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.textBoxNombreProducto);
            this.Name = "FrmProductosTransacciones";
            this.Text = "Eliga Un Producto";
            this.Load += new System.EventHandler(this.FrmProductosTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button botonNuevoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Button botonBuscarProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.TextBox textBoxMarca;
    }
}