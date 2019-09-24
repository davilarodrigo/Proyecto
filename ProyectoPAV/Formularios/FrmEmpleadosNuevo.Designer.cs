namespace ProyectoPAV.Formularios
{
    partial class FrmEmpleadosNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleadosNuevo));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNacimiento = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.RadioMujer = new System.Windows.Forms.RadioButton();
            this.RadioHombre = new System.Windows.Forms.RadioButton();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxDocumento = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnNuevoCargo = new System.Windows.Forms.Button();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(413, 260);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(357, 260);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(80, 240);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 65;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(135, 237);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(155, 20);
            this.TextBoxTelefono.TabIndex = 9;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(97, 214);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 61;
            this.LblEmail.Text = "Email";
            // 
            // LblNacimiento
            // 
            this.LblNacimiento.AutoSize = true;
            this.LblNacimiento.Location = new System.Drawing.Point(36, 188);
            this.LblNacimiento.Name = "LblNacimiento";
            this.LblNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LblNacimiento.TabIndex = 60;
            this.LblNacimiento.Text = "Fecha Nacimiento";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(97, 164);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 59;
            this.LblSexo.Text = "Sexo";
            // 
            // RadioMujer
            // 
            this.RadioMujer.AutoSize = true;
            this.RadioMujer.Location = new System.Drawing.Point(202, 162);
            this.RadioMujer.Name = "RadioMujer";
            this.RadioMujer.Size = new System.Drawing.Size(51, 17);
            this.RadioMujer.TabIndex = 6;
            this.RadioMujer.TabStop = true;
            this.RadioMujer.Text = "Mujer";
            this.RadioMujer.UseVisualStyleBackColor = true;
            // 
            // RadioHombre
            // 
            this.RadioHombre.AutoSize = true;
            this.RadioHombre.Location = new System.Drawing.Point(134, 162);
            this.RadioHombre.Name = "RadioHombre";
            this.RadioHombre.Size = new System.Drawing.Size(62, 17);
            this.RadioHombre.TabIndex = 5;
            this.RadioHombre.TabStop = true;
            this.RadioHombre.Text = "Hombre";
            this.RadioHombre.UseVisualStyleBackColor = true;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(135, 211);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(206, 20);
            this.TextBoxEmail.TabIndex = 8;
            // 
            // TextBoxDocumento
            // 
            this.TextBoxDocumento.Location = new System.Drawing.Point(135, 111);
            this.TextBoxDocumento.Name = "TextBoxDocumento";
            this.TextBoxDocumento.Size = new System.Drawing.Size(206, 20);
            this.TextBoxDocumento.TabIndex = 3;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(135, 58);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(206, 20);
            this.TextBoxNombre.TabIndex = 1;
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(135, 32);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(206, 20);
            this.TextBoxApellido.TabIndex = 0;
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(67, 102);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(62, 13);
            this.LblDocumento.TabIndex = 51;
            this.LblDocumento.Text = "Documento";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(85, 61);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 50;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(85, 35);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 49;
            this.LblApellido.Text = "Apellido";
            // 
            // comboCargo
            // 
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Location = new System.Drawing.Point(134, 137);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(207, 21);
            this.comboCargo.TabIndex = 4;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(93, 140);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 95;
            this.lblCargo.Text = "Cargo";
            // 
            // btnNuevoCargo
            // 
            this.btnNuevoCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoCargo.Image = global::ProyectoPAV.Properties.Resources.Add_16x16;
            this.btnNuevoCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCargo.Location = new System.Drawing.Point(347, 133);
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
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(135, 185);
            this.dateTimePickerNacimiento.MaxDate = new System.DateTime(2101, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerNacimiento.TabIndex = 7;
            this.dateTimePickerNacimiento.Value = new System.DateTime(2019, 9, 23, 0, 0, 0, 0);
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(135, 84);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(206, 21);
            this.comboTipoDoc.TabIndex = 2;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Refresh_256x256;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargar.Location = new System.Drawing.Point(423, 12);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(40, 40);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // FrmEmpleadosNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 322);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.comboTipoDoc);
            this.Controls.Add(this.dateTimePickerNacimiento);
            this.Controls.Add(this.btnNuevoCargo);
            this.Controls.Add(this.comboCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNacimiento);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.RadioMujer);
            this.Controls.Add(this.RadioHombre);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxDocumento);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.TextBoxApellido);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpleadosNuevo";
            this.Text = "Nuevo Empleado";
            this.Load += new System.EventHandler(this.FrmEmpleadosNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNacimiento;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.RadioButton RadioMujer;
        private System.Windows.Forms.RadioButton RadioHombre;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxDocumento;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnNuevoCargo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.Button btnRecargar;
    }
}