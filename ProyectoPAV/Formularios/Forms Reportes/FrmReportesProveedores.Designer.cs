namespace ProyectoPAV.Formularios.Forms_Reportes
{
    partial class FrmReportesProveedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControlEstadisticas = new System.Windows.Forms.TabControl();
            this.tabPageReportes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLocalidades = new System.Windows.Forms.ComboBox();
            this.reportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabPageEstadisticas = new System.Windows.Forms.TabPage();
            this.reportViewerEstadistica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewerProductos2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.Reporte2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerEstadistca2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Estadistica2 = new System.Windows.Forms.Button();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.tabControlEstadisticas.SuspendLayout();
            this.tabPageReportes.SuspendLayout();
            this.tabPageEstadisticas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControlEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.tabControlEstadisticas.Name = "tabControlEstadisticas";
            this.tabControlEstadisticas.SelectedIndex = 0;
            this.tabControlEstadisticas.Size = new System.Drawing.Size(764, 426);
            this.tabControlEstadisticas.TabIndex = 2;
            // 
            // tabPageReportes
            // 
            this.tabPageReportes.Controls.Add(this.label2);
            this.tabPageReportes.Controls.Add(this.comboBoxLocalidades);
            this.tabPageReportes.Controls.Add(this.reportViewerProductos);
            this.tabPageReportes.Controls.Add(this.btnReporte);
            this.tabPageReportes.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportes.Name = "tabPageReportes";
            this.tabPageReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportes.Size = new System.Drawing.Size(756, 400);
            this.tabPageReportes.TabIndex = 0;
            this.tabPageReportes.Text = "Listado Proveedores - Localidades";
            this.tabPageReportes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Localidad";
            // 
            // comboBoxLocalidades
            // 
            this.comboBoxLocalidades.FormattingEnabled = true;
            this.comboBoxLocalidades.Location = new System.Drawing.Point(67, 6);
            this.comboBoxLocalidades.Name = "comboBoxLocalidades";
            this.comboBoxLocalidades.Size = new System.Drawing.Size(198, 21);
            this.comboBoxLocalidades.TabIndex = 3;
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSProductos";
            reportDataSource1.Value = null;
            this.reportViewerProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportProductos.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(6, 35);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.ServerReport.BearerToken = null;
            this.reportViewerProductos.Size = new System.Drawing.Size(735, 356);
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
            // 
            // tabPageEstadisticas
            // 
            this.tabPageEstadisticas.Controls.Add(this.reportViewerEstadistica);
            this.tabPageEstadisticas.Controls.Add(this.btnEstadistica);
            this.tabPageEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabPageEstadisticas.Name = "tabPageEstadisticas";
            this.tabPageEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEstadisticas.Size = new System.Drawing.Size(756, 400);
            this.tabPageEstadisticas.TabIndex = 1;
            this.tabPageEstadisticas.Text = "Proveedores x Localidades";
            this.tabPageEstadisticas.UseVisualStyleBackColor = true;
            // 
            // reportViewerEstadistica
            // 
            this.reportViewerEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DSEstadistica";
            reportDataSource2.Value = null;
            this.reportViewerEstadistica.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerEstadistica.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticasProductos.rdlc";
            this.reportViewerEstadistica.Location = new System.Drawing.Point(6, 33);
            this.reportViewerEstadistica.Name = "reportViewerEstadistica";
            this.reportViewerEstadistica.ServerReport.BearerToken = null;
            this.reportViewerEstadistica.Size = new System.Drawing.Size(744, 361);
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxRazonSocial);
            this.tabPage1.Controls.Add(this.reportViewerProductos2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Reporte2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listado Proveedores - Razon Social";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewerProductos2
            // 
            this.reportViewerProductos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DSProductos2";
            reportDataSource3.Value = null;
            this.reportViewerProductos2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerProductos2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportProductos2.rdlc";
            this.reportViewerProductos2.Location = new System.Drawing.Point(6, 36);
            this.reportViewerProductos2.Name = "reportViewerProductos2";
            this.reportViewerProductos2.ServerReport.BearerToken = null;
            this.reportViewerProductos2.Size = new System.Drawing.Size(744, 364);
            this.reportViewerProductos2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razon Social";
            // 
            // Reporte2
            // 
            this.Reporte2.Location = new System.Drawing.Point(275, 8);
            this.Reporte2.Name = "Reporte2";
            this.Reporte2.Size = new System.Drawing.Size(87, 20);
            this.Reporte2.TabIndex = 0;
            this.Reporte2.Text = "Mostrar";
            this.Reporte2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerEstadistca2);
            this.tabPage2.Controls.Add(this.Estadistica2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 400);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Proveedores x Razon Social";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerEstadistca2
            // 
            reportDataSource4.Name = "DSProductosEstadistica2";
            reportDataSource4.Value = null;
            this.reportViewerEstadistca2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerEstadistca2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticaProducto2.rdlc";
            this.reportViewerEstadistca2.Location = new System.Drawing.Point(6, 33);
            this.reportViewerEstadistca2.Name = "reportViewerEstadistca2";
            this.reportViewerEstadistca2.ServerReport.BearerToken = null;
            this.reportViewerEstadistca2.Size = new System.Drawing.Size(744, 367);
            this.reportViewerEstadistca2.TabIndex = 1;
            // 
            // Estadistica2
            // 
            this.Estadistica2.Location = new System.Drawing.Point(12, 8);
            this.Estadistica2.Name = "Estadistica2";
            this.Estadistica2.Size = new System.Drawing.Size(82, 19);
            this.Estadistica2.TabIndex = 0;
            this.Estadistica2.Text = "Mostrar";
            this.Estadistica2.UseVisualStyleBackColor = true;
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(85, 9);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(184, 20);
            this.textBoxRazonSocial.TabIndex = 4;
            // 
            // FrmReportesProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlEstadisticas);
            this.Name = "FrmReportesProveedores";
            this.Text = "FrmReportesProveedores";
            this.Load += new System.EventHandler(this.FrmReportesProveedores_Load);
            this.tabControlEstadisticas.ResumeLayout(false);
            this.tabPageReportes.ResumeLayout(false);
            this.tabPageReportes.PerformLayout();
            this.tabPageEstadisticas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEstadisticas;
        private System.Windows.Forms.TabPage tabPageReportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLocalidades;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TabPage tabPageEstadisticas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadistica;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reporte2;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadistca2;
        private System.Windows.Forms.Button Estadistica2;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
    }
}