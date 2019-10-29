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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.reportViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Año = new System.Windows.Forms.Label();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.reportViewerEstadisticas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Reporte2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewerReporte2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentas = new ProyectoPAV.Formularios.ReportesyEstadisticas.DataSetVentas();
            this.Estadistica1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerEstadistica2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Estadistica2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Reportes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Reportes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // Reportes
            // 
            this.Reportes.Controls.Add(this.comboBoxEmpleado);
            this.Reportes.Controls.Add(this.label1);
            this.Reportes.Controls.Add(this.reportViewerVentas);
            this.Reportes.Controls.Add(this.btnReporte);
            this.Reportes.Location = new System.Drawing.Point(4, 22);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(3);
            this.Reportes.Size = new System.Drawing.Size(767, 399);
            this.Reportes.TabIndex = 0;
            this.Reportes.Text = "Listado Ventas - Empleado";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // reportViewerVentas
            // 
            this.reportViewerVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSVentas";
            reportDataSource1.Value = this.ventasBindingSource;
            this.reportViewerVentas.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerVentas.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportVentas.rdlc";
            this.reportViewerVentas.Location = new System.Drawing.Point(6, 35);
            this.reportViewerVentas.Name = "reportViewerVentas";
            this.reportViewerVentas.ServerReport.BearerToken = null;
            this.reportViewerVentas.Size = new System.Drawing.Size(755, 358);
            this.reportViewerVentas.TabIndex = 3;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(211, 7);
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
            this.tabPage2.Text = "Cantidad de Ventas Anuales x Empleado";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(57, 17);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(160, 20);
            this.textBoxAño.TabIndex = 3;
            // 
            // reportViewerEstadisticas
            // 
            reportDataSource2.Name = "DSEstadistica";
            reportDataSource2.Value = this.Estadistica1BindingSource;
            this.reportViewerEstadisticas.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerEstadisticas.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticaVentas.rdlc";
            this.reportViewerEstadisticas.Location = new System.Drawing.Point(6, 52);
            this.reportViewerEstadisticas.Name = "reportViewerEstadisticas";
            this.reportViewerEstadisticas.ServerReport.BearerToken = null;
            this.reportViewerEstadisticas.Size = new System.Drawing.Size(755, 341);
            this.reportViewerEstadisticas.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empleado";
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(83, 9);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(116, 21);
            this.comboBoxEmpleado.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerReporte2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Reporte2);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listado Ventas Intervalo Fecha";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(56, 41);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // Reporte2
            // 
            this.Reporte2.Location = new System.Drawing.Point(231, 14);
            this.Reporte2.Name = "Reporte2";
            this.Reporte2.Size = new System.Drawing.Size(101, 45);
            this.Reporte2.TabIndex = 2;
            this.Reporte2.Text = "Mostrar";
            this.Reporte2.UseVisualStyleBackColor = true;
            this.Reporte2.Click += new System.EventHandler(this.Reporte2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // reportViewerReporte2
            // 
            this.reportViewerReporte2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DSReporte2";
            reportDataSource3.Value = this.ventasBindingSource1;
            this.reportViewerReporte2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerReporte2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportVentas2.rdlc";
            this.reportViewerReporte2.Location = new System.Drawing.Point(6, 67);
            this.reportViewerReporte2.Name = "reportViewerReporte2";
            this.reportViewerReporte2.ServerReport.BearerToken = null;
            this.reportViewerReporte2.Size = new System.Drawing.Size(755, 326);
            this.reportViewerReporte2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewerEstadistica2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 399);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Estadistica1BindingSource
            // 
            this.Estadistica1BindingSource.DataMember = "Estadistica1";
            this.Estadistica1BindingSource.DataSource = this.dataSetVentas;
            // 
            // ventasBindingSource1
            // 
            this.ventasBindingSource1.DataMember = "Ventas";
            this.ventasBindingSource1.DataSource = this.dataSetVentas;
            // 
            // reportViewerEstadistica2
            // 
            this.reportViewerEstadistica2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DSEstadisticaVenta2";
            reportDataSource4.Value = this.Estadistica2BindingSource;
            this.reportViewerEstadistica2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerEstadistica2.LocalReport.ReportEmbeddedResource = "ProyectoPAV.Formularios.ReportesyEstadisticas.ReportEstadisticaVenta2.rdlc";
            this.reportViewerEstadistica2.Location = new System.Drawing.Point(6, 45);
            this.reportViewerEstadistica2.Name = "reportViewerEstadistica2";
            this.reportViewerEstadistica2.ServerReport.BearerToken = null;
            this.reportViewerEstadistica2.Size = new System.Drawing.Size(755, 348);
            this.reportViewerEstadistica2.TabIndex = 3;
            // 
            // Estadistica2BindingSource
            // 
            this.Estadistica2BindingSource.DataMember = "Estadistica2";
            this.Estadistica2BindingSource.DataSource = this.dataSetVentas;
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
            this.tabControl1.ResumeLayout(false);
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica2BindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reporte2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReporte2;
        private System.Windows.Forms.BindingSource ventasBindingSource1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadistica2;
        private System.Windows.Forms.BindingSource Estadistica2BindingSource;
    }
}