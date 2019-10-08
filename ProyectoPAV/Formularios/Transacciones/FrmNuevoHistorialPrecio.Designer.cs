namespace ProyectoPAV.Formularios.Transacciones
{
    partial class FrmNuevoHistorialPrecio
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
            this.ComboProductos = new System.Windows.Forms.ComboBox();
            this.lblNuevaCategorias = new System.Windows.Forms.Label();
            this.textBoxProv = new System.Windows.Forms.TextBox();
            this.textBoxPublic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.textBoxTalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboProductos
            // 
            this.ComboProductos.FormattingEnabled = true;
            this.ComboProductos.Location = new System.Drawing.Point(112, 30);
            this.ComboProductos.Name = "ComboProductos";
            this.ComboProductos.Size = new System.Drawing.Size(187, 21);
            this.ComboProductos.TabIndex = 43;
            // 
            // lblNuevaCategorias
            // 
            this.lblNuevaCategorias.AutoSize = true;
            this.lblNuevaCategorias.Location = new System.Drawing.Point(17, 33);
            this.lblNuevaCategorias.Name = "lblNuevaCategorias";
            this.lblNuevaCategorias.Size = new System.Drawing.Size(55, 13);
            this.lblNuevaCategorias.TabIndex = 42;
            this.lblNuevaCategorias.Text = "Productos";
            // 
            // textBoxProv
            // 
            this.textBoxProv.Location = new System.Drawing.Point(112, 73);
            this.textBoxProv.Name = "textBoxProv";
            this.textBoxProv.Size = new System.Drawing.Size(185, 20);
            this.textBoxProv.TabIndex = 44;
            // 
            // textBoxPublic
            // 
            this.textBoxPublic.Location = new System.Drawing.Point(112, 118);
            this.textBoxPublic.Name = "textBoxPublic";
            this.textBoxPublic.Size = new System.Drawing.Size(187, 20);
            this.textBoxPublic.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Precio Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Precio Publico";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(302, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(246, 207);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 49;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // textBoxTalle
            // 
            this.textBoxTalle.Location = new System.Drawing.Point(113, 159);
            this.textBoxTalle.Name = "textBoxTalle";
            this.textBoxTalle.Size = new System.Drawing.Size(185, 20);
            this.textBoxTalle.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Numero Talle";
            // 
            // FrmNuevoHistorialPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTalle);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPublic);
            this.Controls.Add(this.textBoxProv);
            this.Controls.Add(this.ComboProductos);
            this.Controls.Add(this.lblNuevaCategorias);
            this.Name = "FrmNuevoHistorialPrecio";
            this.Text = "Nuevo Historial Precio";
            this.Load += new System.EventHandler(this.FrmNuevoHistorialPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboProductos;
        private System.Windows.Forms.Label lblNuevaCategorias;
        private System.Windows.Forms.TextBox textBoxProv;
        private System.Windows.Forms.TextBox textBoxPublic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox textBoxTalle;
        private System.Windows.Forms.Label label3;
    }
}