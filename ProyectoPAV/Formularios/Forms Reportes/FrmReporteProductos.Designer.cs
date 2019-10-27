namespace ProyectoPAV.Formularios.Forms_Reportes
{
    partial class FrmReporteProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new ProyectoPAV.Formularios.ReportesyEstadisticas.DataSetProductos();
            this.EstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageEstadisticas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCategorias = new System.Windows.Forms.RadioButton();
            this.radioButtonMarcas = new System.Windows.Forms.RadioButton();
            this.reportViewerEstadistica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.tabControlEstadisticas = new System.Windows.Forms.TabControl();
            this.tabPageReportes = new System.Windows.Forms.TabPage();
            this.reportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).BeginInit();
            this.tabPageEstadisticas.SuspendLayout();
            this.tabControlEstadisticas.SuspendLayout();
            this.tabPageReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dataSetProductos;
            // 
            // dataSetProductos
            // 
            this.dataSetProductos.DataSetName = "DataSetProductos";
            this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstadisticasBindingSource
            // 
            this.EstadisticasBindingSource.DataMember = "Estadisticas";
            this.EstadisticasBindingSource.DataSource = this.dataSetProductos;
            // 
            // tabPageEstadisticas
            // 
            this.tabPageEstadisticas.Controls.Add(this.label1);
            this.tabPageEstadisticas.Controls.Add(this.radioButtonCategorias);
            this.tabPageEstadisticas.Controls.Add(this.radioButtonMarcas);
            this.tabPageEstadisticas.Controls.Add(this.reportViewerEstadistica);
            this.tabPageEstadisticas.Controls.Add(this.btnEstadistica);
            this.tabPageEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabPageEstadisticas.Name = "tabPageEstadisticas";
            this.tabPageEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEstadisticas.Size = new System.Drawing.Size(756, 406);
            this.tabPageEstadisticas.TabIndex = 1;
            this.tabPageEstadisticas.Text = "Estadisticas";
            this.tabPageEstadisticas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MARCAS";
            this.label1.Visible = false;
            // 
            // radioButtonCategorias
            // 
            this.radioButtonCategorias.AutoSize = true;
            this.radioButtonCategorias.Location = new System.Drawing.Point(6, 29);
            this.radioButtonCategorias.Name = "radioButtonCategorias";
            this.radioButtonCategorias.Size = new System.Drawing.Size(75, 17);
            this.radioButtonCategorias.TabIndex = 3;
            this.radioButtonCategorias.Text = "Categorias";
            this.radioButtonCategorias.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarcas
            // 
            this.radioButtonMarcas.AutoSize = true;
            this.radioButtonMarcas.Checked = true;
            this.radioButtonMarcas.Location = new System.Drawing.Point(6, 6);
            this.radioButtonMarcas.Name = "radioButtonMarcas";
            this.radioButtonMarcas.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMarcas.TabIndex = 2;
            this.radioButtonMarcas.TabStop = true;
            this.radioButtonMarcas.Text = "Marcas";
            this.radioButtonMarcas.UseVisualStyleBackColor = true;
            // 
            // reportViewerEstadistica
            // 
            this.reportViewerEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSEstadistica";
            reportDataSource1.Value = this.EstadisticasBindingSource;
            this.reportViewerEstadistica.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerEstadistica.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticasProductos.rdlc";
            this.reportViewerEstadistica.Location = new System.Drawing.Point(6, 56);
            this.reportViewerEstadistica.Name = "reportViewerEstadistica";
            this.reportViewerEstadistica.ServerReport.BearerToken = null;
            this.reportViewerEstadistica.Size = new System.Drawing.Size(744, 344);
            this.reportViewerEstadistica.TabIndex = 1;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(87, 6);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(77, 40);
            this.btnEstadistica.TabIndex = 0;
            this.btnEstadistica.Text = "Mostrar";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // tabControlEstadisticas
            // 
            this.tabControlEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEstadisticas.Controls.Add(this.tabPageReportes);
            this.tabControlEstadisticas.Controls.Add(this.tabPageEstadisticas);
            this.tabControlEstadisticas.Location = new System.Drawing.Point(13, 12);
            this.tabControlEstadisticas.Name = "tabControlEstadisticas";
            this.tabControlEstadisticas.SelectedIndex = 0;
            this.tabControlEstadisticas.Size = new System.Drawing.Size(764, 432);
            this.tabControlEstadisticas.TabIndex = 0;
            // 
            // tabPageReportes
            // 
            this.tabPageReportes.Controls.Add(this.reportViewerProductos);
            this.tabPageReportes.Controls.Add(this.btnReporte);
            this.tabPageReportes.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportes.Name = "tabPageReportes";
            this.tabPageReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportes.Size = new System.Drawing.Size(756, 406);
            this.tabPageReportes.TabIndex = 0;
            this.tabPageReportes.Text = "Reportes";
            this.tabPageReportes.UseVisualStyleBackColor = true;
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DSProductos";
            reportDataSource2.Value = this.productosBindingSource;
            this.reportViewerProductos.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportProductos.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(6, 35);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.ServerReport.BearerToken = null;
            this.reportViewerProductos.Size = new System.Drawing.Size(735, 362);
            this.reportViewerProductos.TabIndex = 2;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(6, 6);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Mostrar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FrmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 456);
            this.Controls.Add(this.tabControlEstadisticas);
            this.Name = "FrmReporteProductos";
            this.Text = "FrmReporteProductos";
            this.Load += new System.EventHandler(this.FrmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).EndInit();
            this.tabPageEstadisticas.ResumeLayout(false);
            this.tabPageEstadisticas.PerformLayout();
            this.tabControlEstadisticas.ResumeLayout(false);
            this.tabPageReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageEstadisticas;
        private System.Windows.Forms.TabControl tabControlEstadisticas;
        private System.Windows.Forms.TabPage tabPageReportes;
        private System.Windows.Forms.Button btnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private ReportesyEstadisticas.DataSetProductos dataSetProductos;
        private System.Windows.Forms.Button btnEstadistica;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadistica;
        private System.Windows.Forms.BindingSource EstadisticasBindingSource;
        private System.Windows.Forms.RadioButton radioButtonCategorias;
        private System.Windows.Forms.RadioButton radioButtonMarcas;
        private System.Windows.Forms.Label label1;
    }
}