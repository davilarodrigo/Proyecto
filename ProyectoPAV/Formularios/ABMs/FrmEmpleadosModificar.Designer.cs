namespace ProyectoPAV.Formularios
{
    partial class FrmEmpleadosModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleadosModificar));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGardar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnNuevoCargo = new System.Windows.Forms.Button();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(444, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGardar
            // 
            this.btnGardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGardar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Save_256x256;
            this.btnGardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGardar.Location = new System.Drawing.Point(388, 316);
            this.btnGardar.Name = "btnGardar";
            this.btnGardar.Size = new System.Drawing.Size(50, 50);
            this.btnGardar.TabIndex = 10;
            this.btnGardar.UseVisualStyleBackColor = true;
            this.btnGardar.Click += new System.EventHandler(this.BtnGardar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(83, 250);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 87;
            this.lblTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(138, 247);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(155, 20);
            this.textBoxTelefono.TabIndex = 9;
            this.textBoxTelefono.Tag = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 85;
            this.lblEmail.Text = "Email";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(39, 198);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblNacimiento.TabIndex = 84;
            this.lblNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(100, 174);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 83;
            this.lblSexo.Text = "Sexo";
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(205, 172);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(51, 17);
            this.radioMujer.TabIndex = 6;
            this.radioMujer.TabStop = true;
            this.radioMujer.Tag = "Sexo";
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(137, 172);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(62, 17);
            this.radioHombre.TabIndex = 5;
            this.radioHombre.TabStop = true;
            this.radioHombre.Tag = "Sexo";
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(138, 221);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(206, 20);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.Tag = "Email";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(138, 118);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(206, 20);
            this.textBoxDocumento.TabIndex = 3;
            this.textBoxDocumento.Tag = "Numero De Documento";
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(138, 91);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(206, 21);
            this.comboTipoDoc.TabIndex = 2;
            this.comboTipoDoc.Tag = "Tipo De Documento";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(138, 65);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(206, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Tag = "Nombre";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(138, 39);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(206, 20);
            this.textBoxApellido.TabIndex = 0;
            this.textBoxApellido.Tag = "Apellido";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(70, 109);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 75;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(88, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 74;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(88, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 73;
            this.lblApellido.Text = "Apellido";
            // 
            // comboCargo
            // 
            this.comboCargo.DisplayMember = "IdCargo";
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Location = new System.Drawing.Point(138, 144);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(206, 21);
            this.comboCargo.TabIndex = 4;
            this.comboCargo.Tag = "Cargo";
            this.comboCargo.ValueMember = "IdCargo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(97, 147);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 93;
            this.lblCargo.Text = "Cargo";
            // 
            // btnNuevoCargo
            // 
            this.btnNuevoCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoCargo.Image = global::ProyectoPAV.Properties.Resources.Add_16x16;
            this.btnNuevoCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCargo.Location = new System.Drawing.Point(350, 140);
            this.btnNuevoCargo.Name = "btnNuevoCargo";
            this.btnNuevoCargo.Size = new System.Drawing.Size(100, 27);
            this.btnNuevoCargo.TabIndex = 12;
            this.btnNuevoCargo.Text = "Nuevo Cargo";
            this.btnNuevoCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCargo.UseVisualStyleBackColor = true;
            this.btnNuevoCargo.Click += new System.EventHandler(this.BtnNuevoCargo_Click);
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(138, 195);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerNacimiento.TabIndex = 7;
            // 
            // FrmEmpleadosModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 378);
            this.Controls.Add(this.dateTimePickerNacimiento);
            this.Controls.Add(this.btnNuevoCargo);
            this.Controls.Add(this.comboCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGardar);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.radioMujer);
            this.Controls.Add(this.radioHombre);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.comboTipoDoc);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpleadosModificar";
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.FrmEmpleadosModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGardar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnNuevoCargo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
    }
}