using System;

namespace ProyectoPAV
{
    partial class FrmEmpleadosConsultar
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.TextBoxDocumento = new System.Windows.Forms.TextBox();
            this.ComboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.DataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.clmTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaNaciminto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GroupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxFiltros
            // 
            this.GroupBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFiltros.Controls.Add(this.BtnBuscar);
            this.GroupBoxFiltros.Controls.Add(this.LblApellido);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxApellido);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxDocumento);
            this.GroupBoxFiltros.Controls.Add(this.ComboTipoDocumento);
            this.GroupBoxFiltros.Controls.Add(this.DataGridEmpleados);
            this.GroupBoxFiltros.Controls.Add(this.LblDocumento);
            this.GroupBoxFiltros.Controls.Add(this.LblNombre);
            this.GroupBoxFiltros.Controls.Add(this.TextBoxNombre);
            this.GroupBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFiltros.Name = "GroupBoxFiltros";
            this.GroupBoxFiltros.Size = new System.Drawing.Size(711, 419);
            this.GroupBoxFiltros.TabIndex = 0;
            this.GroupBoxFiltros.TabStop = false;
            this.GroupBoxFiltros.Text = "Filtros";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Search_256x256;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Location = new System.Drawing.Point(445, 46);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(48, 48);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(51, 49);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 9;
            this.LblApellido.Text = "Apellido";
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(101, 46);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(338, 20);
            this.TextBoxApellido.TabIndex = 8;
            // 
            // TextBoxDocumento
            // 
            this.TextBoxDocumento.Location = new System.Drawing.Point(185, 72);
            this.TextBoxDocumento.Name = "TextBoxDocumento";
            this.TextBoxDocumento.Size = new System.Drawing.Size(254, 20);
            this.TextBoxDocumento.TabIndex = 7;
            // 
            // ComboTipoDocumento
            // 
            this.ComboTipoDocumento.FormattingEnabled = true;
            this.ComboTipoDocumento.Location = new System.Drawing.Point(101, 72);
            this.ComboTipoDocumento.Name = "ComboTipoDocumento";
            this.ComboTipoDocumento.Size = new System.Drawing.Size(78, 21);
            this.ComboTipoDocumento.TabIndex = 6;
            // 
            // DataGridEmpleados
            // 
            this.DataGridEmpleados.AllowUserToAddRows = false;
            this.DataGridEmpleados.AllowUserToDeleteRows = false;
            this.DataGridEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTipoDocumento,
            this.clmNroDocumento,
            this.clmApellido,
            this.clmNombre,
            this.clmTelefono,
            this.ClmFechaNaciminto,
            this.ClmFechaAlta,
            this.clmSexo,
            this.clmEmail,
            this.ClmFechaBaja});
            this.DataGridEmpleados.Location = new System.Drawing.Point(6, 100);
            this.DataGridEmpleados.Name = "DataGridEmpleados";
            this.DataGridEmpleados.ReadOnly = true;
            this.DataGridEmpleados.Size = new System.Drawing.Size(699, 313);
            this.DataGridEmpleados.TabIndex = 5;
            // 
            // clmTipoDocumento
            // 
            this.clmTipoDocumento.HeaderText = "Tipo Documento";
            this.clmTipoDocumento.Name = "clmTipoDocumento";
            this.clmTipoDocumento.ReadOnly = true;
            // 
            // clmNroDocumento
            // 
            this.clmNroDocumento.HeaderText = "Numero Documento";
            this.clmNroDocumento.Name = "clmNroDocumento";
            this.clmNroDocumento.ReadOnly = true;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            // 
            // ClmFechaNaciminto
            // 
            this.ClmFechaNaciminto.HeaderText = "Fecha Nacimiento";
            this.ClmFechaNaciminto.Name = "ClmFechaNaciminto";
            this.ClmFechaNaciminto.ReadOnly = true;
            // 
            // ClmFechaAlta
            // 
            this.ClmFechaAlta.HeaderText = "Fecha de Alta";
            this.ClmFechaAlta.Name = "ClmFechaAlta";
            this.ClmFechaAlta.ReadOnly = true;
            // 
            // clmSexo
            // 
            this.clmSexo.HeaderText = "Sexo";
            this.clmSexo.Name = "clmSexo";
            this.clmSexo.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // ClmFechaBaja
            // 
            this.ClmFechaBaja.HeaderText = "Fecha de Baja";
            this.ClmFechaBaja.Name = "ClmFechaBaja";
            this.ClmFechaBaja.ReadOnly = true;
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(33, 75);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(62, 13);
            this.LblDocumento.TabIndex = 2;
            this.LblDocumento.Text = "Documento";
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
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(101, 20);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(338, 20);
            this.TextBoxNombre.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(673, 437);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Location = new System.Drawing.Point(124, 437);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(50, 50);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Edit_256x256;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnModificar.Location = new System.Drawing.Point(68, 437);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(50, 50);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 437);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(50, 50);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FrmEmpleadosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 499);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.GroupBoxFiltros);
            this.Name = "FrmEmpleadosConsultar";
            this.Text = "Consultar Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleadosConsultar_Load);
            this.GroupBoxFiltros.ResumeLayout(false);
            this.GroupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmEmpleadosConsultar_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxFiltros;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.DataGridView DataGridEmpleados;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.TextBox TextBoxDocumento;
        private System.Windows.Forms.ComboBox ComboTipoDocumento;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaNaciminto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaBaja;
    }
}