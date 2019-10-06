namespace ProyectoPAV.Formularios.Transacciones
{
    partial class FrmComprasConsultar
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridCompras = new System.Windows.Forms.DataGridView();
            this.dataGridDetallesCompra = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.TimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.TextBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GroupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetallesCompra)).BeginInit();
            this.GroupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Edit_256x256;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnModificar.Location = new System.Drawing.Point(68, 461);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(50, 50);
            this.BtnModificar.TabIndex = 16;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.41026F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridCompras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridDetallesCompra, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 357);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // dataGridCompras
            // 
            this.dataGridCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompras.Location = new System.Drawing.Point(3, 3);
            this.dataGridCompras.Name = "dataGridCompras";
            this.dataGridCompras.Size = new System.Drawing.Size(351, 351);
            this.dataGridCompras.TabIndex = 0;
            this.dataGridCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompras_CellClick);
            // 
            // dataGridDetallesCompra
            // 
            this.dataGridDetallesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDetallesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetallesCompra.Location = new System.Drawing.Point(360, 3);
            this.dataGridDetallesCompra.Name = "dataGridDetallesCompra";
            this.dataGridDetallesCompra.Size = new System.Drawing.Size(456, 351);
            this.dataGridDetallesCompra.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 461);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(50, 50);
            this.BtnNuevo.TabIndex = 19;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(810, 464);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 47);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Razon Social";
            // 
            // TimePickerHasta
            // 
            this.TimePickerHasta.CustomFormat = "yyyy-MM-dd";
            this.TimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerHasta.Location = new System.Drawing.Point(341, 50);
            this.TimePickerHasta.Name = "TimePickerHasta";
            this.TimePickerHasta.Size = new System.Drawing.Size(253, 20);
            this.TimePickerHasta.TabIndex = 13;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Location = new System.Drawing.Point(264, 53);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.LblFechaHasta.TabIndex = 12;
            this.LblFechaHasta.Text = "Fecha Hasta";
            // 
            // TimePickerDesde
            // 
            this.TimePickerDesde.CustomFormat = "yyyy-MM-dd";
            this.TimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerDesde.Location = new System.Drawing.Point(341, 20);
            this.TimePickerDesde.Name = "TimePickerDesde";
            this.TimePickerDesde.Size = new System.Drawing.Size(253, 20);
            this.TimePickerDesde.TabIndex = 11;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Search_256x256;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Location = new System.Drawing.Point(613, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(50, 51);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Location = new System.Drawing.Point(264, 23);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.LblFechaDesde.TabIndex = 9;
            this.LblFechaDesde.Text = "Fecha Desde";
            // 
            // TextBoxRazonSocial
            // 
            this.TextBoxRazonSocial.Location = new System.Drawing.Point(92, 35);
            this.TextBoxRazonSocial.Name = "TextBoxRazonSocial";
            this.TextBoxRazonSocial.Size = new System.Drawing.Size(154, 20);
            this.TextBoxRazonSocial.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Location = new System.Drawing.Point(124, 461);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(50, 50);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFiltros
            // 
            this.GroupBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFiltros.Controls.Add(this.tableLayoutPanel1);
            this.GroupBoxFiltros.Controls.Add(this.label1);
            this.GroupBoxFiltros.Controls.Add(this.TimePickerHasta);
            this.GroupBoxFiltros.Controls.Add(this.LblFechaHasta);
            this.GroupBoxFiltros.Controls.Add(this.TimePickerDesde);
            this.GroupBoxFiltros.Controls.Add(this.BtnBuscar);
            this.GroupBoxFiltros.Controls.Add(this.LblFechaDesde);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxRazonSocial);
            this.GroupBoxFiltros.Location = new System.Drawing.Point(12, 3);
            this.GroupBoxFiltros.Name = "GroupBoxFiltros";
            this.GroupBoxFiltros.Size = new System.Drawing.Size(831, 439);
            this.GroupBoxFiltros.TabIndex = 15;
            this.GroupBoxFiltros.TabStop = false;
            this.GroupBoxFiltros.Text = "Filtros";
            // 
            // FrmComprasConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 523);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.GroupBoxFiltros);
            this.Name = "FrmComprasConsultar";
            this.Text = "Consultar Compras";
            this.Load += new System.EventHandler(this.FrmComprasConsultar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetallesCompra)).EndInit();
            this.GroupBoxFiltros.ResumeLayout(false);
            this.GroupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridCompras;
        private System.Windows.Forms.DataGridView dataGridDetallesCompra;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePickerHasta;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.DateTimePicker TimePickerDesde;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.TextBox TextBoxRazonSocial;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GroupBoxFiltros;
    }
}