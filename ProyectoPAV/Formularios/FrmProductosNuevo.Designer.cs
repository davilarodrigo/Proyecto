namespace ProyectoPAV.Formularios
{
    partial class FrmProductosNuevo
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
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblTalle = new System.Windows.Forms.Label();
            this.TextBoxTalle = new System.Windows.Forms.TextBox();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboMarca
            // 
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(81, 58);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(206, 21);
            this.ComboMarca.TabIndex = 81;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(38, 61);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(37, 13);
            this.LblMarca.TabIndex = 80;
            this.LblMarca.Text = "Marca";
            // 
            // LblTalle
            // 
            this.LblTalle.AutoSize = true;
            this.LblTalle.Location = new System.Drawing.Point(45, 115);
            this.LblTalle.Name = "LblTalle";
            this.LblTalle.Size = new System.Drawing.Size(30, 13);
            this.LblTalle.TabIndex = 77;
            this.LblTalle.Text = "Talle";
            // 
            // TextBoxTalle
            // 
            this.TextBoxTalle.Location = new System.Drawing.Point(81, 112);
            this.TextBoxTalle.Name = "TextBoxTalle";
            this.TextBoxTalle.Size = new System.Drawing.Size(85, 20);
            this.TextBoxTalle.TabIndex = 76;
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(81, 85);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(206, 21);
            this.ComboCategoria.TabIndex = 75;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(81, 32);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(206, 20);
            this.TextBoxNombre.TabIndex = 74;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(23, 88);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 73;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(31, 35);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 72;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(373, 131);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 79;
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(317, 131);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 78;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Nueva Marca";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmProductosNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboMarca);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblTalle);
            this.Controls.Add(this.TextBoxTalle);
            this.Controls.Add(this.ComboCategoria);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmProductosNuevo";
            this.Text = "FrmProductosNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboMarca;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblTalle;
        private System.Windows.Forms.TextBox TextBoxTalle;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button button1;
    }
}