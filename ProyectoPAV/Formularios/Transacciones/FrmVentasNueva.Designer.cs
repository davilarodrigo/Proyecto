﻿namespace ProyectoPAV.Formularios
{
    partial class FrmVentasNueva
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
            this.ComboEmpleado = new System.Windows.Forms.ComboBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonAsignarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumeroDoc = new System.Windows.Forms.Label();
            this.labeNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(694, 447);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(50, 50);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Check_256x256;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAceptar.Location = new System.Drawing.Point(638, 447);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // ComboEmpleado
            // 
            this.ComboEmpleado.FormattingEnabled = true;
            this.ComboEmpleado.Location = new System.Drawing.Point(401, 27);
            this.ComboEmpleado.Name = "ComboEmpleado";
            this.ComboEmpleado.Size = new System.Drawing.Size(206, 21);
            this.ComboEmpleado.TabIndex = 0;
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(329, 35);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(54, 13);
            this.LblDocumento.TabIndex = 27;
            this.LblDocumento.Text = "Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.ComboEmpleado);
            this.groupBox1.Controls.Add(this.LblDocumento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 429);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta Nueva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonAsignarCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelNumeroDoc);
            this.groupBox2.Controls.Add(this.labeNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Location = new System.Drawing.Point(19, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 137);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // botonAsignarCliente
            // 
            this.botonAsignarCliente.Location = new System.Drawing.Point(170, 108);
            this.botonAsignarCliente.Name = "botonAsignarCliente";
            this.botonAsignarCliente.Size = new System.Drawing.Size(92, 23);
            this.botonAsignarCliente.TabIndex = 52;
            this.botonAsignarCliente.Text = "Asignar Cliente";
            this.botonAsignarCliente.UseVisualStyleBackColor = true;
            this.botonAsignarCliente.Click += new System.EventHandler(this.botonAsignarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellido:";
            // 
            // labelNumeroDoc
            // 
            this.labelNumeroDoc.AutoSize = true;
            this.labelNumeroDoc.Location = new System.Drawing.Point(107, 76);
            this.labelNumeroDoc.Name = "labelNumeroDoc";
            this.labelNumeroDoc.Size = new System.Drawing.Size(61, 13);
            this.labelNumeroDoc.TabIndex = 51;
            this.labelNumeroDoc.Text = "_________";
            // 
            // labeNombre
            // 
            this.labeNombre.AutoSize = true;
            this.labeNombre.Location = new System.Drawing.Point(107, 25);
            this.labeNombre.Name = "labeNombre";
            this.labeNombre.Size = new System.Drawing.Size(61, 13);
            this.labeNombre.TabIndex = 47;
            this.labeNombre.Text = "_________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Documento:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(107, 51);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(61, 13);
            this.labelApellido.TabIndex = 48;
            this.labelApellido.Text = "_________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 46;
            this.label4.Text = "Agregar\r\nProducto";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(19, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 51);
            this.button2.TabIndex = 45;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Carrito";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(690, 163);
            this.dataGridView2.TabIndex = 42;
            // 
            // FrmVentasNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FrmVentasNueva";
            this.Text = "FrmVentasNueva";
            this.Load += new System.EventHandler(this.FrmVentasNueva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox ComboEmpleado;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumeroDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labeNombre;
        private System.Windows.Forms.Button botonAsignarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}