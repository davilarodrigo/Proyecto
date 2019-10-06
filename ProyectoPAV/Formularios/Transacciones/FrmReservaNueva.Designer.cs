namespace ProyectoPAV.Formularios.Transacciones
{
    partial class FrmReservaNueva
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
            this.label1 = new System.Windows.Forms.Label();
            this.botonAsignarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumeroDoc = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.labeNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.ComboEmpleado = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMontoReserva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.botonBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            // botonAsignarCliente
            // 
            this.botonAsignarCliente.Location = new System.Drawing.Point(201, 108);
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
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(340, 24);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(54, 13);
            this.LblDocumento.TabIndex = 27;
            this.LblDocumento.Text = "Empleado";
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
            // ComboEmpleado
            // 
            this.ComboEmpleado.FormattingEnabled = true;
            this.ComboEmpleado.Location = new System.Drawing.Point(412, 21);
            this.ComboEmpleado.Name = "ComboEmpleado";
            this.ComboEmpleado.Size = new System.Drawing.Size(206, 21);
            this.ComboEmpleado.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(679, 446);
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
            this.BtnAceptar.Location = new System.Drawing.Point(623, 446);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 48;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(325, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 137);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMontoReserva);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridProductos);
            this.groupBox1.Controls.Add(this.ComboEmpleado);
            this.groupBox1.Controls.Add(this.LblDocumento);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 429);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva Nueva";
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(15, 260);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.Size = new System.Drawing.Size(648, 163);
            this.dataGridProductos.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Productos";
            // 
            // textBoxMontoReserva
            // 
            this.textBoxMontoReserva.Location = new System.Drawing.Point(412, 52);
            this.textBoxMontoReserva.Name = "textBoxMontoReserva";
            this.textBoxMontoReserva.Size = new System.Drawing.Size(206, 20);
            this.textBoxMontoReserva.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Monto Reserva";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botonBuscarProducto);
            this.groupBox3.Controls.Add(this.lblMarca);
            this.groupBox3.Controls.Add(this.textBoxMarca);
            this.groupBox3.Controls.Add(this.comboCategorias);
            this.groupBox3.Controls.Add(this.lblCategoria);
            this.groupBox3.Controls.Add(this.lblNombre);
            this.groupBox3.Controls.Add(this.textBoxNombreProducto);
            this.groupBox3.Location = new System.Drawing.Point(15, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 137);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(23, 51);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(66, 54);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(189, 20);
            this.textBoxMarca.TabIndex = 12;
            // 
            // comboCategorias
            // 
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(66, 79);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(189, 21);
            this.comboCategorias.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Location = new System.Drawing.Point(66, 25);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(189, 20);
            this.textBoxNombreProducto.TabIndex = 11;
            // 
            // botonBuscarProducto
            // 
            this.botonBuscarProducto.Location = new System.Drawing.Point(101, 106);
            this.botonBuscarProducto.Name = "botonBuscarProducto";
            this.botonBuscarProducto.Size = new System.Drawing.Size(96, 26);
            this.botonBuscarProducto.TabIndex = 16;
            this.botonBuscarProducto.Text = "Filtrar";
            this.botonBuscarProducto.UseVisualStyleBackColor = true;
            this.botonBuscarProducto.Click += new System.EventHandler(this.botonBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(116, 52);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(178, 20);
            this.textBoxCantidad.TabIndex = 60;
            // 
            // FrmReservaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 508);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReservaNueva";
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.FrmReservaNueva_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAsignarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumeroDoc;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label labeNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.ComboBox ComboEmpleado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMontoReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonBuscarProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label7;
    }
}