namespace ProyectoPAV.Formularios.Forms_Reportes
{
    partial class FrmReportesVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentas = new ProyectoPAV.Formularios.ReportesyEstadisticas.DataSetVentas();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.reportViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.reportViewerEstadisticas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Estadistica1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.Año = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Reportes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.dataSetVentas;
            // 
            // dataSetVentas
            // 
            this.dataSetVentas.DataSetName = "DataSetVentas";
            this.dataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Reportes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // Reportes
            // 
            this.Reportes.Controls.Add(this.reportViewerVentas);
            this.Reportes.Controls.Add(this.btnReporte);
            this.Reportes.Location = new System.Drawing.Point(4, 22);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(3);
            this.Reportes.Size = new System.Drawing.Size(767, 399);
            this.Reportes.TabIndex = 0;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // reportViewerVentas
            // 
            this.reportViewerVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DSVentas";
            reportDataSource4.Value = this.ventasBindingSource;
            this.reportViewerVentas.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerVentas.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportVentas.rdlc";
            this.reportViewerVentas.Location = new System.Drawing.Point(6, 35);
            this.reportViewerVentas.Name = "reportViewerVentas";
            this.reportViewerVentas.ServerReport.BearerToken = null;
            this.reportViewerVentas.Size = new System.Drawing.Size(755, 358);
            this.reportViewerVentas.TabIndex = 3;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(6, 6);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Mostrar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Año);
            this.tabPage2.Controls.Add(this.textBoxAño);
            this.tabPage2.Controls.Add(this.reportViewerEstadisticas);
            this.tabPage2.Controls.Add(this.btnEstadistica);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadisticas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(223, 6);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(77, 40);
            this.btnEstadistica.TabIndex = 1;
            this.btnEstadistica.Text = "Mostrar";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // reportViewerEstadisticas
            // 
            reportDataSource3.Name = "DSEstadistica";
            reportDataSource3.Value = this.Estadistica1BindingSource;
            this.reportViewerEstadisticas.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerEstadisticas.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticaVentas.rdlc";
            this.reportViewerEstadisticas.Location = new System.Drawing.Point(6, 52);
            this.reportViewerEstadisticas.Name = "reportViewerEstadisticas";
            this.reportViewerEstadisticas.ServerReport.BearerToken = null;
            this.reportViewerEstadisticas.Size = new System.Drawing.Size(755, 341);
            this.reportViewerEstadisticas.TabIndex = 2;
            // 
            // Estadistica1BindingSource
            // 
            this.Estadistica1BindingSource.DataMember = "Estadistica1";
            this.Estadistica1BindingSource.DataSource = this.dataSetVentas;
            // 
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(57, 17);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(160, 20);
            this.textBoxAño.TabIndex = 3;
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(25, 20);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(26, 13);
            this.Año.TabIndex = 4;
            this.Año.Text = "Año";
            // 
            // FrmReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmReportesVentas";
            this.Text = "FrmReportesVentas";
            this.Load += new System.EventHandler(this.FrmReportesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Reportes.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Reportes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEstadistica;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVentas;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private ReportesyEstadisticas.DataSetVentas dataSetVentas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadisticas;
        private System.Windows.Forms.BindingSource Estadistica1BindingSource;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.TextBox textBoxAño;
    }
}