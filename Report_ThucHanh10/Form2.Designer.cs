﻿namespace Report_ThucHanh10
{
    partial class Form2
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
            this.HangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dataset_CH = new Report_ThucHanh10.Dataset_CH();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset_CH)).BeginInit();
            this.SuspendLayout();
            // 
            // HangHoaBindingSource
            // 
            this.HangHoaBindingSource.DataMember = "HangHoa";
            this.HangHoaBindingSource.DataSource = this.Dataset_CH;
            // 
            // Dataset_CH
            // 
            this.Dataset_CH.DataSetName = "Dataset_CH";
            this.Dataset_CH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 8;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HangHoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report_ThucHanh10.ReportCH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 411);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Thống kê hàng hoá bán theo nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset_CH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HangHoaBindingSource;
        private Dataset_CH Dataset_CH;
    }
}