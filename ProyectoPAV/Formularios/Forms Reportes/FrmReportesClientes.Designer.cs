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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewerClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerEstadisticas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMesCompra = new System.Windows.Forms.TextBox();
            this.Reporte2 = new System.Windows.Forms.Button();
            this.reportViewerReporte2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Estadistica2 = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientes = new ProyectoPAV.Formularios.ReportesyEstadisticas.DataSetClientes();
            this.EstadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerEstadistica2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Estadistica2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadistica2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadistica2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxMes);
            this.tabPage1.Controls.Add(this.reportViewerClientes);
            this.tabPage1.Controls.Add(this.btnReporte);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado De Clientes Cumpleaños en Mes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewerClientes
            // 
            this.reportViewerClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource6.Name = "DSClientes";
            reportDataSource6.Value = this.clientesBindingSource;
            this.reportViewerClientes.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerClientes.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportClientes.rdlc";
            this.reportViewerClientes.Location = new System.Drawing.Point(6, 35);
            this.reportViewerClientes.Name = "reportViewerClientes";
            this.reportViewerClientes.ServerReport.BearerToken = null;
            this.reportViewerClientes.Size = new System.Drawing.Size(755, 351);
            this.reportViewerClientes.TabIndex = 3;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(220, 6);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Mostrar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
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
            this.tabPage2.Text = "Cantidad de Clientes -Genero";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerEstadisticas
            // 
            this.reportViewerEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerEstadisticas.DocumentMapWidth = 93;
            reportDataSource7.Name = "DSEstadisticasClientes";
            reportDataSource7.Value = this.EstadisticaBindingSource;
            this.reportViewerEstadisticas.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewerEstadisticas.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticasClientes.rdlc";
            this.reportViewerEstadisticas.Location = new System.Drawing.Point(6, 32);
            this.reportViewerEstadisticas.Name = "reportViewerEstadisticas";
            this.reportViewerEstadisticas.ServerReport.BearerToken = null;
            this.reportViewerEstadisticas.Size = new System.Drawing.Size(755, 354);
            this.reportViewerEstadisticas.TabIndex = 2;
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
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(56, 9);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(134, 20);
            this.textBoxMes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mes";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewerReporte2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxMesCompra);
            this.tabPage3.Controls.Add(this.Reporte2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listado de Clientes Realizaron Compras en Mes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mes";
            // 
            // textBoxMesCompra
            // 
            this.textBoxMesCompra.Location = new System.Drawing.Point(48, 9);
            this.textBoxMesCompra.Name = "textBoxMesCompra";
            this.textBoxMesCompra.Size = new System.Drawing.Size(134, 20);
            this.textBoxMesCompra.TabIndex = 7;
            // 
            // Reporte2
            // 
            this.Reporte2.Location = new System.Drawing.Point(212, 6);
            this.Reporte2.Name = "Reporte2";
            this.Reporte2.Size = new System.Drawing.Size(75, 23);
            this.Reporte2.TabIndex = 6;
            this.Reporte2.Text = "Mostrar";
            this.Reporte2.UseVisualStyleBackColor = true;
            this.Reporte2.Click += new System.EventHandler(this.Reporte2_Click);
            // 
            // reportViewerReporte2
            // 
            this.reportViewerReporte2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource8.Name = "DSClientes2";
            reportDataSource8.Value = this.clientesBindingSource1;
            this.reportViewerReporte2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewerReporte2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportClientes2.rdlc";
            this.reportViewerReporte2.Location = new System.Drawing.Point(6, 37);
            this.reportViewerReporte2.Name = "reportViewerReporte2";
            this.reportViewerReporte2.ServerReport.BearerToken = null;
            this.reportViewerReporte2.Size = new System.Drawing.Size(755, 349);
            this.reportViewerReporte2.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewerEstadistica2);
            this.tabPage4.Controls.Add(this.Estadistica2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cantidad Compras de Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Estadistica2
            // 
            this.Estadistica2.Location = new System.Drawing.Point(24, 12);
            this.Estadistica2.Name = "Estadistica2";
            this.Estadistica2.Size = new System.Drawing.Size(93, 25);
            this.Estadistica2.TabIndex = 0;
            this.Estadistica2.Text = "Mostrar";
            this.Estadistica2.UseVisualStyleBackColor = true;
            this.Estadistica2.Click += new System.EventHandler(this.Estadistica2_Click);
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
            // EstadisticaBindingSource
            // 
            this.EstadisticaBindingSource.DataMember = "Estadistica";
            this.EstadisticaBindingSource.DataSource = this.dataSetClientes;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.dataSetClientes;
            // 
            // reportViewerEstadistica2
            // 
            this.reportViewerEstadistica2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource5.Name = "DSEstadisticasClientes2";
            reportDataSource5.Value = this.estadistica2BindingSource1;
            this.reportViewerEstadistica2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerEstadistica2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticasCliente2.rdlc";
            this.reportViewerEstadistica2.Location = new System.Drawing.Point(6, 43);
            this.reportViewerEstadistica2.Name = "reportViewerEstadistica2";
            this.reportViewerEstadistica2.ServerReport.BearerToken = null;
            this.reportViewerEstadistica2.Size = new System.Drawing.Size(755, 343);
            this.reportViewerEstadistica2.TabIndex = 1;
            // 
            // Estadistica2BindingSource
            // 
            this.Estadistica2BindingSource.DataMember = "Estadistica2";
            this.Estadistica2BindingSource.DataSource = this.dataSetClientes;
            // 
            // estadistica2BindingSource1
            // 
            this.estadistica2BindingSource1.DataMember = "Estadistica2";
            this.estadistica2BindingSource1.DataSource = this.dataSetClientes;
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
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadistica2BindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMesCompra;
        private System.Windows.Forms.Button Reporte2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReporte2;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Estadistica2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadistica2;
        private System.Windows.Forms.BindingSource Estadistica2BindingSource;
        private System.Windows.Forms.BindingSource estadistica2BindingSource1;
    }
}