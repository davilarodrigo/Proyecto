namespace ProyectoPAV.Formularios.Auxiliares
{
    partial class FrmTipoDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoDocumentos));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxNuevoTipoDoc = new System.Windows.Forms.TextBox();
            this.lblNuevoTipoDoc = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridTipoDoc = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(368, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(424, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // textBoxNuevoTipoDoc
            // 
            this.textBoxNuevoTipoDoc.Location = new System.Drawing.Point(152, 27);
            this.textBoxNuevoTipoDoc.Name = "textBoxNuevoTipoDoc";
            this.textBoxNuevoTipoDoc.Size = new System.Drawing.Size(164, 20);
            this.textBoxNuevoTipoDoc.TabIndex = 35;
            // 
            // lblNuevoTipoDoc
            // 
            this.lblNuevoTipoDoc.AutoSize = true;
            this.lblNuevoTipoDoc.Location = new System.Drawing.Point(25, 30);
            this.lblNuevoTipoDoc.Name = "lblNuevoTipoDoc";
            this.lblNuevoTipoDoc.Size = new System.Drawing.Size(121, 13);
            this.lblNuevoTipoDoc.TabIndex = 34;
            this.lblNuevoTipoDoc.Text = "Nuevo Tipo Documento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(322, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 50);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridTipoDoc
            // 
            this.dataGridTipoDoc.AllowUserToAddRows = false;
            this.dataGridTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre});
            this.dataGridTipoDoc.Location = new System.Drawing.Point(28, 67);
            this.dataGridTipoDoc.Name = "dataGridTipoDoc";
            this.dataGridTipoDoc.Size = new System.Drawing.Size(416, 213);
            this.dataGridTipoDoc.TabIndex = 32;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            // 
            // FrmTipoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 361);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBoxNuevoTipoDoc);
            this.Controls.Add(this.lblNuevoTipoDoc);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridTipoDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTipoDocumentos";
            this.Text = "FrmTipoDocumentos";
            this.Load += new System.EventHandler(this.FrmTipoDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxNuevoTipoDoc;
        private System.Windows.Forms.Label lblNuevoTipoDoc;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
    }
}