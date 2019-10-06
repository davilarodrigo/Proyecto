namespace ProyectoPAV.Formularios.Transacciones
{
    partial class FrmCompraNueva
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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ComboEmpleado = new System.Windows.Forms.ComboBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 46;
            this.label4.Text = "Agregar\r\nProducto";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(19, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 51);
            this.button2.TabIndex = 45;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pedido Compra";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(570, 163);
            this.dataGridView2.TabIndex = 42;
            // 
            // ComboEmpleado
            // 
            this.ComboEmpleado.FormattingEnabled = true;
            this.ComboEmpleado.Location = new System.Drawing.Point(383, 24);
            this.ComboEmpleado.Name = "ComboEmpleado";
            this.ComboEmpleado.Size = new System.Drawing.Size(206, 21);
            this.ComboEmpleado.TabIndex = 0;
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(323, 27);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(54, 13);
            this.LblDocumento.TabIndex = 27;
            this.LblDocumento.Text = "Empleado";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(591, 361);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 49;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(535, 361);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 48;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.ComboEmpleado);
            this.groupBox1.Controls.Add(this.LblDocumento);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 342);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra Nueva";
            // 
            // ComboProveedor
            // 
            this.ComboProveedor.FormattingEnabled = true;
            this.ComboProveedor.Location = new System.Drawing.Point(92, 24);
            this.ComboProveedor.Name = "ComboProveedor";
            this.ComboProveedor.Size = new System.Drawing.Size(188, 21);
            this.ComboProveedor.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Razon Social";
            // 
            // FrmCompraNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 414);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCompraNueva";
            this.Text = "Nueva Compra";
            this.Load += new System.EventHandler(this.FrmCompraNueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox ComboEmpleado;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboProveedor;
        private System.Windows.Forms.Label label1;
    }
}