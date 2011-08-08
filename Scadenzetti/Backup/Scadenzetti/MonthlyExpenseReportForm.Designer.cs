namespace Scadenzetti
{
    partial class MonthlyExpenseReportForm
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
            this.MonthlyExpenseReportItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MonthlyReportSearchCriteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyExpenseReportItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyReportSearchCriteriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthlyExpenseReportItemBindingSource
            // 
            this.MonthlyExpenseReportItemBindingSource.DataSource = typeof(Scadenzetti.MonthlyExpenseReportItem);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Scadenzetti_MonthlyExpenseReportItem";
            reportDataSource1.Value = this.MonthlyExpenseReportItemBindingSource;
            reportDataSource2.Name = "Scadenzetti_MonthlyReportSearchCriteria";
            reportDataSource2.Value = this.MonthlyReportSearchCriteriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Scadenzetti.MonthlyExpenseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(442, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // MonthlyReportSearchCriteriaBindingSource
            // 
            this.MonthlyReportSearchCriteriaBindingSource.DataSource = typeof(Scadenzetti.MonthlyReportSearchCriteria);
            // 
            // MonthlyExpenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MonthlyExpenseReportForm";
            this.Text = "Report spese mensili";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonthlyExpenseReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyExpenseReportItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyReportSearchCriteriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MonthlyExpenseReportItemBindingSource;
        private System.Windows.Forms.BindingSource MonthlyReportSearchCriteriaBindingSource;
    }
}