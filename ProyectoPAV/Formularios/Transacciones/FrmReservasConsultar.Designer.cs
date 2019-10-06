namespace ProyectoPAV.Formularios.Transacciones
{
    partial class FrmReservasConsultar
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
            this.dataGridReservas = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.TimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GroupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.checkVencimientoHoy = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).BeginInit();
            this.GroupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Edit_256x256;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnModificar.Location = new System.Drawing.Point(68, 577);
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridReservas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 477);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // dataGridReservas
            // 
            this.dataGridReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservas.Location = new System.Drawing.Point(3, 3);
            this.dataGridReservas.Name = "dataGridReservas";
            this.dataGridReservas.Size = new System.Drawing.Size(883, 471);
            this.dataGridReservas.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 577);
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
            this.BtnSalir.Location = new System.Drawing.Point(857, 577);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apellido";
            // 
            // TimePickerHasta
            // 
            this.TimePickerHasta.CustomFormat = "yyyy-MM-dd";
            this.TimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerHasta.Location = new System.Drawing.Point(399, 50);
            this.TimePickerHasta.Name = "TimePickerHasta";
            this.TimePickerHasta.Size = new System.Drawing.Size(253, 20);
            this.TimePickerHasta.TabIndex = 13;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Location = new System.Drawing.Point(264, 53);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(126, 13);
            this.LblFechaHasta.TabIndex = 12;
            this.LblFechaHasta.Text = "Fecha Realizacion Hasta";
            // 
            // TimePickerDesde
            // 
            this.TimePickerDesde.CustomFormat = "yyyy-MM-dd";
            this.TimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerDesde.Location = new System.Drawing.Point(399, 19);
            this.TimePickerDesde.Name = "TimePickerDesde";
            this.TimePickerDesde.Size = new System.Drawing.Size(253, 20);
            this.TimePickerDesde.TabIndex = 11;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(67, 50);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(179, 20);
            this.TextBoxNombre.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Search_256x256;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Location = new System.Drawing.Point(674, 19);
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
            this.LblFechaDesde.Size = new System.Drawing.Size(129, 13);
            this.LblFechaDesde.TabIndex = 9;
            this.LblFechaDesde.Text = "Fecha Realizacion Desde";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(17, 53);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(44, 13);
            this.LblCliente.TabIndex = 1;
            this.LblCliente.Text = "Nombre";
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(67, 20);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(179, 20);
            this.TextBoxApellido.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Location = new System.Drawing.Point(124, 577);
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
            this.GroupBoxFiltros.Controls.Add(this.checkVencimientoHoy);
            this.GroupBoxFiltros.Controls.Add(this.tableLayoutPanel1);
            this.GroupBoxFiltros.Controls.Add(this.label1);
            this.GroupBoxFiltros.Controls.Add(this.TimePickerHasta);
            this.GroupBoxFiltros.Controls.Add(this.LblFechaHasta);
            this.GroupBoxFiltros.Controls.Add(this.TimePickerDesde);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxNombre);
            this.GroupBoxFiltros.Controls.Add(this.BtnBuscar);
            this.GroupBoxFiltros.Controls.Add(this.LblFechaDesde);
            this.GroupBoxFiltros.Controls.Add(this.LblCliente);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxApellido);
            this.GroupBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFiltros.Name = "GroupBoxFiltros";
            this.GroupBoxFiltros.Size = new System.Drawing.Size(895, 559);
            this.GroupBoxFiltros.TabIndex = 15;
            this.GroupBoxFiltros.TabStop = false;
            this.GroupBoxFiltros.Text = "Filtros";
            // 
            // checkVencimientoHoy
            // 
            this.checkVencimientoHoy.AutoSize = true;
            this.checkVencimientoHoy.Location = new System.Drawing.Point(739, 37);
            this.checkVencimientoHoy.Name = "checkVencimientoHoy";
            this.checkVencimientoHoy.Size = new System.Drawing.Size(136, 17);
            this.checkVencimientoHoy.TabIndex = 17;
            this.checkVencimientoHoy.Text = "Vencimiento Dia Actual";
            this.checkVencimientoHoy.UseVisualStyleBackColor = true;
            // 
            // FrmReservasConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 639);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.GroupBoxFiltros);
            this.Name = "FrmReservasConsultar";
            this.Text = "Consultar Reservas";
            this.Load += new System.EventHandler(this.FrmReservasConsultar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).EndInit();
            this.GroupBoxFiltros.ResumeLayout(false);
            this.GroupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridReservas;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePickerHasta;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.DateTimePicker TimePickerDesde;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GroupBoxFiltros;
        private System.Windows.Forms.CheckBox checkVencimientoHoy;
    }
}