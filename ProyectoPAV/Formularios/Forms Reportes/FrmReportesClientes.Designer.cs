namespace ProyectoPAV.Formularios.Forms_Reportes
{
    partial class FrmReportesClientes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReporte = new System.Windows.Forms.Button();
            this.reportViewerClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientes = new ProyectoPAV.Formularios.ReportesyEstadisticas.DataSetClientes();
            this.reportViewerEstadisticas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EstadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerClientes);
            this.tabPage1.Controls.Add(this.btnReporte);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reportes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerEstadisticas);
            this.tabPage2.Controls.Add(this.btnEstadistica);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadisticas";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // reportViewerClientes
            // 
            this.reportViewerClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSClientes";
            reportDataSource1.Value = this.clientesBindingSource;
            this.reportViewerClientes.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerClientes.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportClientes.rdlc";
            this.reportViewerClientes.Location = new System.Drawing.Point(6, 35);
            this.reportViewerClientes.Name = "reportViewerClientes";
            this.reportViewerClientes.ServerReport.BearerToken = null;
            this.reportViewerClientes.Size = new System.Drawing.Size(755, 351);
            this.reportViewerClientes.TabIndex = 3;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(6, 6);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(77, 20);
            this.btnEstadistica.TabIndex = 1;
            this.btnEstadistica.Text = "Mostrar";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dataSetClientes;
            // 
            // dataSetClientes
            // 
            this.dataSetClientes.DataSetName = "DataSetClientes";
            this.dataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerEstadisticas
            // 
            this.reportViewerEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerEstadisticas.DocumentMapWidth = 93;
            reportDataSource2.Name = "DSEstadisticasClientes";
            reportDataSource2.Value = this.EstadisticaBindingSource;
            this.reportViewerEstadisticas.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerEstadisticas.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticasClientes.rdlc";
            this.reportViewerEstadisticas.Location = new System.Drawing.Point(6, 32);
            this.reportViewerEstadisticas.Name = "reportViewerEstadisticas";
            this.reportViewerEstadisticas.ServerReport.BearerToken = null;
            this.reportViewerEstadisticas.Size = new System.Drawing.Size(755, 354);
            this.reportViewerEstadisticas.TabIndex = 2;
            // 
            // EstadisticaBindingSource
            // 
            this.EstadisticaBindingSource.DataMember = "Estadistica";
            this.EstadisticaBindingSource.DataSource = this.dataSetClientes;
            // 
            // FrmReportesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmReportesClientes";
            this.Text = "FrmReportesClientes";
            this.Load += new System.EventHandler(this.FrmReportesClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ReportesyEstadisticas.DataSetClientes dataSetClientes;
        private System.Windows.Forms.Button btnEstadistica;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadisticas;
        private System.Windows.Forms.BindingSource EstadisticaBindingSource;
    }
}