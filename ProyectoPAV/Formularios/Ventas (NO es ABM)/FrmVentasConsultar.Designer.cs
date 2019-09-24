namespace ProyectoPAV.Formularios
{
    partial class FrmVentasConsultar
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
            this.GroupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.TimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.TimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.DataGridVentas = new System.Windows.Forms.DataGridView();
            this.ClmIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.GroupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxFiltros
            // 
            this.GroupBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFiltros.Controls.Add(this.TimePickerHasta);
            this.GroupBoxFiltros.Controls.Add(this.LblFechaHasta);
            this.GroupBoxFiltros.Controls.Add(this.TimePickerDesde);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxNombre);
            this.GroupBoxFiltros.Controls.Add(this.BtnBuscar);
            this.GroupBoxFiltros.Controls.Add(this.LblFechaDesde);
            this.GroupBoxFiltros.Controls.Add(this.DataGridVentas);
            this.GroupBoxFiltros.Controls.Add(this.LblCliente);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxApellido);
            this.GroupBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFiltros.Name = "GroupBoxFiltros";
            this.GroupBoxFiltros.Size = new System.Drawing.Size(814, 419);
            this.GroupBoxFiltros.TabIndex = 10;
            this.GroupBoxFiltros.TabStop = false;
            this.GroupBoxFiltros.Text = "Filtros";
            // 
            // TimePickerHasta
            // 
            this.TimePickerHasta.Location = new System.Drawing.Point(96, 74);
            this.TimePickerHasta.Name = "TimePickerHasta";
            this.TimePickerHasta.Size = new System.Drawing.Size(253, 20);
            this.TimePickerHasta.TabIndex = 13;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Location = new System.Drawing.Point(22, 80);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.LblFechaHasta.TabIndex = 12;
            this.LblFechaHasta.Text = "Fecha Hasta";
            // 
            // TimePickerDesde
            // 
            this.TimePickerDesde.Location = new System.Drawing.Point(96, 46);
            this.TimePickerDesde.Name = "TimePickerDesde";
            this.TimePickerDesde.Size = new System.Drawing.Size(253, 20);
            this.TimePickerDesde.TabIndex = 11;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(260, 20);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(179, 20);
            this.TextBoxNombre.TabIndex = 1;
            this.TextBoxNombre.Text = "Nombre";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Search_256x256;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Location = new System.Drawing.Point(391, 46);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(48, 48);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Location = new System.Drawing.Point(19, 52);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.LblFechaDesde.TabIndex = 9;
            this.LblFechaDesde.Text = "Fecha Desde";
            // 
            // DataGridVentas
            // 
            this.DataGridVentas.AllowUserToAddRows = false;
            this.DataGridVentas.AllowUserToDeleteRows = false;
            this.DataGridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIdVenta,
            this.ClmNombreEmpleado,
            this.ClmNombreCliente,
            this.ClmApellidoCliente,
            this.ClmFechaHora,
            this.ClmMonto});
            this.DataGridVentas.Location = new System.Drawing.Point(6, 100);
            this.DataGridVentas.Name = "DataGridVentas";
            this.DataGridVentas.ReadOnly = true;
            this.DataGridVentas.Size = new System.Drawing.Size(802, 313);
            this.DataGridVentas.TabIndex = 5;
            // 
            // ClmIdVenta
            // 
            this.ClmIdVenta.HeaderText = "Id Venta";
            this.ClmIdVenta.Name = "ClmIdVenta";
            this.ClmIdVenta.ReadOnly = true;
            // 
            // ClmNombreEmpleado
            // 
            this.ClmNombreEmpleado.HeaderText = "Nombre Empleado";
            this.ClmNombreEmpleado.Name = "ClmNombreEmpleado";
            this.ClmNombreEmpleado.ReadOnly = true;
            // 
            // ClmNombreCliente
            // 
            this.ClmNombreCliente.HeaderText = "Nombre Cliente";
            this.ClmNombreCliente.Name = "ClmNombreCliente";
            this.ClmNombreCliente.ReadOnly = true;
            // 
            // ClmApellidoCliente
            // 
            this.ClmApellidoCliente.HeaderText = "Apellido Cliente";
            this.ClmApellidoCliente.Name = "ClmApellidoCliente";
            this.ClmApellidoCliente.ReadOnly = true;
            // 
            // ClmFechaHora
            // 
            this.ClmFechaHora.HeaderText = "Fecha y Hora";
            this.ClmFechaHora.Name = "ClmFechaHora";
            this.ClmFechaHora.ReadOnly = true;
            // 
            // ClmMonto
            // 
            this.ClmMonto.HeaderText = "Monto";
            this.ClmMonto.Name = "ClmMonto";
            this.ClmMonto.ReadOnly = true;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(51, 23);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 1;
            this.LblCliente.Text = "Cliente";
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(96, 20);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(158, 20);
            this.TextBoxApellido.TabIndex = 0;
            this.TextBoxApellido.Text = "Apellido";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 457);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(50, 50);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(776, 457);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Location = new System.Drawing.Point(124, 457);
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
            this.BtnModificar.Location = new System.Drawing.Point(68, 457);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(50, 50);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Location = new System.Drawing.Point(180, 457);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(100, 50);
            this.BtnVerDetalle.TabIndex = 15;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.UseVisualStyleBackColor = true;
            // 
            // FrmVentasConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 519);
            this.Controls.Add(this.BtnVerDetalle);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.GroupBoxFiltros);
            this.Name = "FrmVentasConsultar";
            this.Text = "FrmVentasConsultar";
            this.GroupBoxFiltros.ResumeLayout(false);
            this.GroupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.GroupBox GroupBoxFiltros;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.DataGridView DataGridVentas;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.DateTimePicker TimePickerDesde;
        private System.Windows.Forms.DateTimePicker TimePickerHasta;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMonto;
        private System.Windows.Forms.Button BtnVerDetalle;
    }
}