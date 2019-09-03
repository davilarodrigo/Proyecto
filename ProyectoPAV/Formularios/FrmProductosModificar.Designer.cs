namespace ProyectoPAV.Formularios
{
    partial class FrmProductosModificar
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
            this.LblTalle = new System.Windows.Forms.Label();
            this.TextBoxTalle = new System.Windows.Forms.TextBox();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTalle
            // 
            this.LblTalle.AutoSize = true;
            this.LblTalle.Location = new System.Drawing.Point(59, 129);
            this.LblTalle.Name = "LblTalle";
            this.LblTalle.Size = new System.Drawing.Size(30, 13);
            this.LblTalle.TabIndex = 67;
            this.LblTalle.Text = "Talle";
            // 
            // TextBoxTalle
            // 
            this.TextBoxTalle.Location = new System.Drawing.Point(95, 126);
            this.TextBoxTalle.Name = "TextBoxTalle";
            this.TextBoxTalle.Size = new System.Drawing.Size(85, 20);
            this.TextBoxTalle.TabIndex = 64;
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(95, 99);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(206, 21);
            this.ComboCategoria.TabIndex = 54;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(95, 46);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(206, 20);
            this.TextBoxNombre.TabIndex = 53;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(37, 102);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 51;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(45, 49);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 50;
            this.LblNombre.Text = "Nombre";
            // 
            // ComboMarca
            // 
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(95, 72);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(206, 21);
            this.ComboMarca.TabIndex = 71;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(52, 75);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(37, 13);
            this.LblMarca.TabIndex = 70;
            this.LblMarca.Text = "Marca";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(312, 176);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 69;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Save_256x256;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardar.Location = new System.Drawing.Point(256, 176);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(50, 50);
            this.BtnGuardar.TabIndex = 68;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmProductosModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.ComboMarca);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTalle);
            this.Controls.Add(this.TextBoxTalle);
            this.Controls.Add(this.ComboCategoria);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmProductosModificar";
            this.Text = "FrmProductosModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTalle;
        private System.Windows.Forms.TextBox TextBoxTalle;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox ComboMarca;
        private System.Windows.Forms.Label LblMarca;
    }
}