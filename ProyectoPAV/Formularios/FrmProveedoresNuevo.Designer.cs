namespace ProyectoPAV.Formularios
{
    partial class FrmProveedoresNuevo
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
            this.LblNumeroCalle = new System.Windows.Forms.Label();
            this.LblCalle = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TextBoxNumeroCalle = new System.Windows.Forms.TextBox();
            this.TextBoxCalle = new System.Windows.Forms.TextBox();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LblLocalidad = new System.Windows.Forms.Label();
            this.ComboLocalidad = new System.Windows.Forms.ComboBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.TextBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(329, 231);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 45;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(273, 231);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 44;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // LblNumeroCalle
            // 
            this.LblNumeroCalle.AutoSize = true;
            this.LblNumeroCalle.Location = new System.Drawing.Point(73, 154);
            this.LblNumeroCalle.Name = "LblNumeroCalle";
            this.LblNumeroCalle.Size = new System.Drawing.Size(44, 13);
            this.LblNumeroCalle.TabIndex = 43;
            this.LblNumeroCalle.Text = "Número";
            // 
            // LblCalle
            // 
            this.LblCalle.AutoSize = true;
            this.LblCalle.Location = new System.Drawing.Point(87, 128);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(30, 13);
            this.LblCalle.TabIndex = 42;
            this.LblCalle.Text = "Calle";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(68, 102);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 41;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TextBoxNumeroCalle
            // 
            this.TextBoxNumeroCalle.Location = new System.Drawing.Point(123, 151);
            this.TextBoxNumeroCalle.Name = "TextBoxNumeroCalle";
            this.TextBoxNumeroCalle.Size = new System.Drawing.Size(85, 20);
            this.TextBoxNumeroCalle.TabIndex = 40;
            // 
            // TextBoxCalle
            // 
            this.TextBoxCalle.Location = new System.Drawing.Point(123, 125);
            this.TextBoxCalle.Name = "TextBoxCalle";
            this.TextBoxCalle.Size = new System.Drawing.Size(206, 20);
            this.TextBoxCalle.TabIndex = 39;
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(123, 99);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(155, 20);
            this.TextBoxTelefono.TabIndex = 38;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(85, 76);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 37;
            this.LblEmail.Text = "Email";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(123, 73);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(206, 20);
            this.TextBoxEmail.TabIndex = 32;
            // 
            // LblLocalidad
            // 
            this.LblLocalidad.AutoSize = true;
            this.LblLocalidad.Location = new System.Drawing.Point(64, 180);
            this.LblLocalidad.Name = "LblLocalidad";
            this.LblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.LblLocalidad.TabIndex = 47;
            this.LblLocalidad.Text = "Localidad";
            // 
            // ComboLocalidad
            // 
            this.ComboLocalidad.FormattingEnabled = true;
            this.ComboLocalidad.Location = new System.Drawing.Point(123, 177);
            this.ComboLocalidad.Name = "ComboLocalidad";
            this.ComboLocalidad.Size = new System.Drawing.Size(206, 21);
            this.ComboLocalidad.TabIndex = 46;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(47, 50);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.LblRazonSocial.TabIndex = 49;
            this.LblRazonSocial.Text = "Razon Social";
            // 
            // TextBoxRazonSocial
            // 
            this.TextBoxRazonSocial.Location = new System.Drawing.Point(123, 47);
            this.TextBoxRazonSocial.Name = "TextBoxRazonSocial";
            this.TextBoxRazonSocial.Size = new System.Drawing.Size(206, 20);
            this.TextBoxRazonSocial.TabIndex = 48;
            // 
            // FrmProveedoresNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 293);
            this.Controls.Add(this.LblRazonSocial);
            this.Controls.Add(this.TextBoxRazonSocial);
            this.Controls.Add(this.LblLocalidad);
            this.Controls.Add(this.ComboLocalidad);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblNumeroCalle);
            this.Controls.Add(this.LblCalle);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TextBoxNumeroCalle);
            this.Controls.Add(this.TextBoxCalle);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Name = "FrmProveedoresNuevo";
            this.Text = "FrmProveedoresNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblNumeroCalle;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TextBoxNumeroCalle;
        private System.Windows.Forms.TextBox TextBoxCalle;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LblLocalidad;
        private System.Windows.Forms.ComboBox ComboLocalidad;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.TextBox TextBoxRazonSocial;
    }
}