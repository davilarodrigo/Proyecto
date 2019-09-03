namespace ProyectoPAV
{
    partial class FrmEscritorio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscritorio));
            this.MenuStripEscritorio = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auxiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripEscritorio = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TableEstructura = new System.Windows.Forms.TableLayoutPanel();
            this.TableMenuPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.TableBotonesPrinciales = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnReservas = new System.Windows.Forms.Button();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnCompras = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.TableMenuSecundario = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.MenuStripEscritorio.SuspendLayout();
            this.ToolStripEscritorio.SuspendLayout();
            this.TableEstructura.SuspendLayout();
            this.TableMenuPrincipal.SuspendLayout();
            this.TableBotonesPrinciales.SuspendLayout();
            this.TableMenuSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripEscritorio
            // 
            this.MenuStripEscritorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aBMToolStripMenuItem});
            this.MenuStripEscritorio.Location = new System.Drawing.Point(0, 0);
            this.MenuStripEscritorio.Name = "MenuStripEscritorio";
            this.MenuStripEscritorio.Size = new System.Drawing.Size(800, 24);
            this.MenuStripEscritorio.TabIndex = 0;
            this.MenuStripEscritorio.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarLoginToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cambiarLoginToolStripMenuItem
            // 
            this.cambiarLoginToolStripMenuItem.Name = "cambiarLoginToolStripMenuItem";
            this.cambiarLoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cambiarLoginToolStripMenuItem.Text = "Cambiar Login";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.auxiliaresToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // auxiliaresToolStripMenuItem
            // 
            this.auxiliaresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríasToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.tiposDeDocumentoToolStripMenuItem,
            this.cargosToolStripMenuItem});
            this.auxiliaresToolStripMenuItem.Name = "auxiliaresToolStripMenuItem";
            this.auxiliaresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auxiliaresToolStripMenuItem.Text = "Auxiliares";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.CategoríasToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.LocalidadesToolStripMenuItem_Click);
            // 
            // tiposDeDocumentoToolStripMenuItem
            // 
            this.tiposDeDocumentoToolStripMenuItem.Name = "tiposDeDocumentoToolStripMenuItem";
            this.tiposDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tiposDeDocumentoToolStripMenuItem.Text = "Tipos de Documento";
            this.tiposDeDocumentoToolStripMenuItem.Click += new System.EventHandler(this.TiposDeDocumentoToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.CargosToolStripMenuItem_Click);
            // 
            // ToolStripEscritorio
            // 
            this.ToolStripEscritorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.ToolStripEscritorio.Location = new System.Drawing.Point(0, 24);
            this.ToolStripEscritorio.Name = "ToolStripEscritorio";
            this.ToolStripEscritorio.Size = new System.Drawing.Size(800, 25);
            this.ToolStripEscritorio.TabIndex = 1;
            this.ToolStripEscritorio.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // TableEstructura
            // 
            this.TableEstructura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableEstructura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TableEstructura.ColumnCount = 1;
            this.TableEstructura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableEstructura.Controls.Add(this.TableMenuPrincipal, 0, 0);
            this.TableEstructura.Location = new System.Drawing.Point(12, 52);
            this.TableEstructura.Name = "TableEstructura";
            this.TableEstructura.RowCount = 1;
            this.TableEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TableEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableEstructura.Size = new System.Drawing.Size(776, 386);
            this.TableEstructura.TabIndex = 2;
            // 
            // TableMenuPrincipal
            // 
            this.TableMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableMenuPrincipal.BackColor = System.Drawing.Color.PaleGreen;
            this.TableMenuPrincipal.ColumnCount = 2;
            this.TableMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TableMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TableMenuPrincipal.Controls.Add(this.TableBotonesPrinciales, 0, 0);
            this.TableMenuPrincipal.Controls.Add(this.TableMenuSecundario, 1, 0);
            this.TableMenuPrincipal.Location = new System.Drawing.Point(3, 3);
            this.TableMenuPrincipal.Name = "TableMenuPrincipal";
            this.TableMenuPrincipal.RowCount = 1;
            this.TableMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMenuPrincipal.Size = new System.Drawing.Size(770, 380);
            this.TableMenuPrincipal.TabIndex = 0;
            // 
            // TableBotonesPrinciales
            // 
            this.TableBotonesPrinciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableBotonesPrinciales.BackColor = System.Drawing.Color.PeachPuff;
            this.TableBotonesPrinciales.ColumnCount = 3;
            this.TableBotonesPrinciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBotonesPrinciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBotonesPrinciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBotonesPrinciales.Controls.Add(this.BtnClientes, 0, 0);
            this.TableBotonesPrinciales.Controls.Add(this.BtnProductos, 1, 0);
            this.TableBotonesPrinciales.Controls.Add(this.BtnReservas, 0, 2);
            this.TableBotonesPrinciales.Controls.Add(this.BtnEstadisticas, 1, 2);
            this.TableBotonesPrinciales.Controls.Add(this.BtnProveedores, 2, 0);
            this.TableBotonesPrinciales.Controls.Add(this.BtnEmpleados, 0, 1);
            this.TableBotonesPrinciales.Controls.Add(this.BtnCompras, 2, 1);
            this.TableBotonesPrinciales.Controls.Add(this.BtnVentas, 1, 1);
            this.TableBotonesPrinciales.Location = new System.Drawing.Point(3, 3);
            this.TableBotonesPrinciales.Name = "TableBotonesPrinciales";
            this.TableBotonesPrinciales.RowCount = 3;
            this.TableBotonesPrinciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBotonesPrinciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBotonesPrinciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBotonesPrinciales.Size = new System.Drawing.Size(494, 374);
            this.TableBotonesPrinciales.TabIndex = 0;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClientes.Location = new System.Drawing.Point(3, 3);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(158, 118);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProductos.Location = new System.Drawing.Point(167, 3);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(158, 118);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReservas.Location = new System.Drawing.Point(3, 251);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Size = new System.Drawing.Size(158, 120);
            this.BtnReservas.TabIndex = 6;
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.UseVisualStyleBackColor = true;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEstadisticas.Location = new System.Drawing.Point(167, 251);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(158, 120);
            this.BtnEstadisticas.TabIndex = 7;
            this.BtnEstadisticas.Text = "Estadísticas y Reportes";
            this.BtnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProveedores.Location = new System.Drawing.Point(331, 3);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(160, 118);
            this.BtnProveedores.TabIndex = 3;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = true;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEmpleados.Location = new System.Drawing.Point(3, 127);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(158, 118);
            this.BtnEmpleados.TabIndex = 5;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCompras.Location = new System.Drawing.Point(331, 127);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Size = new System.Drawing.Size(160, 118);
            this.BtnCompras.TabIndex = 4;
            this.BtnCompras.Text = "Compras a Proveedores";
            this.BtnCompras.UseVisualStyleBackColor = true;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVentas.Location = new System.Drawing.Point(167, 127);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(158, 118);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            // 
            // TableMenuSecundario
            // 
            this.TableMenuSecundario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableMenuSecundario.BackColor = System.Drawing.Color.Pink;
            this.TableMenuSecundario.ColumnCount = 1;
            this.TableMenuSecundario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMenuSecundario.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.TableMenuSecundario.Location = new System.Drawing.Point(503, 3);
            this.TableMenuSecundario.Name = "TableMenuSecundario";
            this.TableMenuSecundario.RowCount = 2;
            this.TableMenuSecundario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableMenuSecundario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableMenuSecundario.Size = new System.Drawing.Size(264, 374);
            this.TableMenuSecundario.TabIndex = 1;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Pink;
            this.PictureBoxLogo.BackgroundImage = global::ProyectoPAV.Properties.Resources.Logo_Programa;
            this.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxLogo.Location = new System.Drawing.Point(51, 42);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(162, 215);
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // FrmEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableEstructura);
            this.Controls.Add(this.ToolStripEscritorio);
            this.Controls.Add(this.MenuStripEscritorio);
            this.MainMenuStrip = this.MenuStripEscritorio;
            this.Name = "FrmEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStripEscritorio.ResumeLayout(false);
            this.MenuStripEscritorio.PerformLayout();
            this.ToolStripEscritorio.ResumeLayout(false);
            this.ToolStripEscritorio.PerformLayout();
            this.TableEstructura.ResumeLayout(false);
            this.TableMenuPrincipal.ResumeLayout(false);
            this.TableBotonesPrinciales.ResumeLayout(false);
            this.TableMenuSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripEscritorio;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripEscritorio;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel TableEstructura;
        private System.Windows.Forms.TableLayoutPanel TableMenuPrincipal;
        private System.Windows.Forms.TableLayoutPanel TableBotonesPrinciales;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnCompras;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnReservas;
        private System.Windows.Forms.Button BtnEstadisticas;
        private System.Windows.Forms.TableLayoutPanel TableMenuSecundario;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auxiliaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
    }
}

