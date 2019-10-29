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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new ProyectoPAV.Formularios.ReportesyEstadisticas.DataSetProductos();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageEstadisticas = new System.Windows.Forms.TabPage();
            this.reportViewerEstadistica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.tabControlEstadisticas = new System.Windows.Forms.TabControl();
            this.tabPageReportes = new System.Windows.Forms.TabPage();
            this.reportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Estadistica2 = new System.Windows.Forms.Button();
            this.Reporte2 = new System.Windows.Forms.Button();
            this.comboMarcas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerProductos2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerEstadistca2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.estadisticasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.tabPageEstadisticas.SuspendLayout();
            this.tabControlEstadisticas.SuspendLayout();
            this.tabPageReportes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadisticasBindingSource
            // 
            this.EstadisticasBindingSource.DataMember = "Estadisticas";
            this.EstadisticasBindingSource.DataSource = this.dataSetProductos;
            // 
            // dataSetProductos
            // 
            this.dataSetProductos.DataSetName = "DataSetProductos";
            this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dataSetProductos;
            // 
            // tabPageEstadisticas
            // 
            this.tabPageEstadisticas.Controls.Add(this.reportViewerEstadistica);
            this.tabPageEstadisticas.Controls.Add(this.btnEstadistica);
            this.tabPageEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabPageEstadisticas.Name = "tabPageEstadisticas";
            this.tabPageEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEstadisticas.Size = new System.Drawing.Size(756, 406);
            this.tabPageEstadisticas.TabIndex = 1;
            this.tabPageEstadisticas.Text = "Productos x Categoria";
            this.tabPageEstadisticas.UseVisualStyleBackColor = true;
            // 
            // reportViewerEstadistica
            // 
            this.reportViewerEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource5.Name = "DSEstadistica";
            reportDataSource5.Value = this.EstadisticasBindingSource;
            this.reportViewerEstadistica.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerEstadistica.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticasProductos.rdlc";
            this.reportViewerEstadistica.Location = new System.Drawing.Point(6, 33);
            this.reportViewerEstadistica.Name = "reportViewerEstadistica";
            this.reportViewerEstadistica.ServerReport.BearerToken = null;
            this.reportViewerEstadistica.Size = new System.Drawing.Size(744, 367);
            this.reportViewerEstadistica.TabIndex = 1;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(6, 6);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(77, 21);
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
            this.tabControlEstadisticas.Controls.Add(this.tabPage1);
            this.tabControlEstadisticas.Controls.Add(this.tabPage2);
            this.tabControlEstadisticas.Location = new System.Drawing.Point(13, 12);
            this.tabControlEstadisticas.Name = "tabControlEstadisticas";
            this.tabControlEstadisticas.SelectedIndex = 0;
            this.tabControlEstadisticas.Size = new System.Drawing.Size(764, 432);
            this.tabControlEstadisticas.TabIndex = 0;
            // 
            // tabPageReportes
            // 
            this.tabPageReportes.Controls.Add(this.label2);
            this.tabPageReportes.Controls.Add(this.comboCategoria);
            this.tabPageReportes.Controls.Add(this.reportViewerProductos);
            this.tabPageReportes.Controls.Add(this.btnReporte);
            this.tabPageReportes.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportes.Name = "tabPageReportes";
            this.tabPageReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportes.Size = new System.Drawing.Size(756, 406);
            this.tabPageReportes.TabIndex = 0;
            this.tabPageReportes.Text = "Listado Productos - Categoria";
            this.tabPageReportes.UseVisualStyleBackColor = true;
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource7.Name = "DSProductos";
            reportDataSource7.Value = this.productosBindingSource;
            this.reportViewerProductos.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportProductos.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(6, 35);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.ServerReport.BearerToken = null;
            this.reportViewerProductos.Size = new System.Drawing.Size(735, 362);
            this.reportViewerProductos.TabIndex = 2;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(271, 5);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Mostrar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(67, 6);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(198, 21);
            this.comboCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categorias";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerProductos2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboMarcas);
            this.tabPage1.Controls.Add(this.Reporte2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 406);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listado Productos - Marcas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerEstadistca2);
            this.tabPage2.Controls.Add(this.Estadistica2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 406);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Productos x Marca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Estadistica2
            // 
            this.Estadistica2.Location = new System.Drawing.Point(12, 8);
            this.Estadistica2.Name = "Estadistica2";
            this.Estadistica2.Size = new System.Drawing.Size(82, 19);
            this.Estadistica2.TabIndex = 0;
            this.Estadistica2.Text = "Mostrar";
            this.Estadistica2.UseVisualStyleBackColor = true;
            this.Estadistica2.Click += new System.EventHandler(this.Estadistica2_Click);
            // 
            // Reporte2
            // 
            this.Reporte2.Location = new System.Drawing.Point(242, 8);
            this.Reporte2.Name = "Reporte2";
            this.Reporte2.Size = new System.Drawing.Size(87, 20);
            this.Reporte2.TabIndex = 0;
            this.Reporte2.Text = "Mostrar";
            this.Reporte2.UseVisualStyleBackColor = true;
            this.Reporte2.Click += new System.EventHandler(this.Reporte2_Click);
            // 
            // comboMarcas
            // 
            this.comboMarcas.FormattingEnabled = true;
            this.comboMarcas.Location = new System.Drawing.Point(57, 9);
            this.comboMarcas.Name = "comboMarcas";
            this.comboMarcas.Size = new System.Drawing.Size(179, 21);
            this.comboMarcas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marcas";
            // 
            // reportViewerProductos2
            // 
            this.reportViewerProductos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource8.Name = "DSProductos2";
            reportDataSource8.Value = this.productosBindingSource1;
            this.reportViewerProductos2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewerProductos2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportProductos2.rdlc";
            this.reportViewerProductos2.Location = new System.Drawing.Point(6, 36);
            this.reportViewerProductos2.Name = "reportViewerProductos2";
            this.reportViewerProductos2.ServerReport.BearerToken = null;
            this.reportViewerProductos2.Size = new System.Drawing.Size(744, 364);
            this.reportViewerProductos2.TabIndex = 3;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.dataSetProductos;
            // 
            // reportViewerEstadistca2
            // 
            reportDataSource6.Name = "DSProductosEstadistica2";
            reportDataSource6.Value = this.estadisticasBindingSource1;
            this.reportViewerEstadistca2.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerEstadistca2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticaProducto2.rdlc";
            this.reportViewerEstadistca2.Location = new System.Drawing.Point(6, 33);
            this.reportViewerEstadistca2.Name = "reportViewerEstadistca2";
            this.reportViewerEstadistca2.ServerReport.BearerToken = null;
            this.reportViewerEstadistca2.Size = new System.Drawing.Size(744, 367);
            this.reportViewerEstadistca2.TabIndex = 1;
            // 
            // estadisticasBindingSource1
            // 
            this.estadisticasBindingSource1.DataMember = "Estadisticas";
            this.estadisticasBindingSource1.DataSource = this.dataSetProductos;
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
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.tabPageEstadisticas.ResumeLayout(false);
            this.tabControlEstadisticas.ResumeLayout(false);
            this.tabPageReportes.ResumeLayout(false);
            this.tabPageReportes.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticasBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarcas;
        private System.Windows.Forms.Button Reporte2;
        private System.Windows.Forms.Button Estadistica2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos2;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadistca2;
        private System.Windows.Forms.BindingSource estadisticasBindingSource1;
    }
}