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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedoresNuevo));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumeroCalle = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.textBoxNumeroCalle = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.comboLocalidad = new System.Windows.Forms.ComboBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.btnNuevaLocalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(435, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(379, 231);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(50, 50);
            this.btnAceptar.TabIndex = 44;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(73, 154);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroCalle.TabIndex = 43;
            this.lblNumeroCalle.Text = "Número";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(87, 128);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 42;
            this.lblCalle.Text = "Calle";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(68, 102);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 41;
            this.lblTelefono.Text = "Teléfono";
            // 
            // textBoxNumeroCalle
            // 
            this.textBoxNumeroCalle.Location = new System.Drawing.Point(123, 151);
            this.textBoxNumeroCalle.Name = "textBoxNumeroCalle";
            this.textBoxNumeroCalle.Size = new System.Drawing.Size(85, 20);
            this.textBoxNumeroCalle.TabIndex = 40;
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(123, 125);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(206, 20);
            this.textBoxCalle.TabIndex = 39;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(123, 99);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(155, 20);
            this.textBoxTelefono.TabIndex = 38;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(85, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(123, 73);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(206, 20);
            this.textBoxEmail.TabIndex = 32;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(64, 180);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 47;
            this.lblLocalidad.Text = "Localidad";
            // 
            // comboLocalidad
            // 
            this.comboLocalidad.FormattingEnabled = true;
            this.comboLocalidad.Location = new System.Drawing.Point(123, 177);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(206, 21);
            this.comboLocalidad.TabIndex = 46;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(47, 50);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 49;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(123, 47);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(206, 20);
            this.textBoxRazonSocial.TabIndex = 48;
            // 
            // btnNuevaLocalidad
            // 
            this.btnNuevaLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevaLocalidad.Image = global::ProyectoPAV.Properties.Resources.Add_16x16;
            this.btnNuevaLocalidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaLocalidad.Location = new System.Drawing.Point(335, 173);
            this.btnNuevaLocalidad.Name = "btnNuevaLocalidad";
            this.btnNuevaLocalidad.Size = new System.Drawing.Size(117, 27);
            this.btnNuevaLocalidad.TabIndex = 84;
            this.btnNuevaLocalidad.Text = "Nueva Localidad";
            this.btnNuevaLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaLocalidad.UseVisualStyleBackColor = true;
            this.btnNuevaLocalidad.Click += new System.EventHandler(this.BtnNuevaLocalidad_Click);
            // 
            // FrmProveedoresNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.btnNuevaLocalidad);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.comboLocalidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.textBoxNumeroCalle);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProveedoresNuevo";
            this.Text = "Nuevo Proveedor";
            this.Load += new System.EventHandler(this.FrmProveedoresNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumeroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBoxNumeroCalle;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox comboLocalidad;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Button btnNuevaLocalidad;
    }
}