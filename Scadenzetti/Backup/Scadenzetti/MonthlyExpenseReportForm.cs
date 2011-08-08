using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Scadenzetti
{
    public partial class MonthlyExpenseReportForm : BaseForm
    {
        private List<MonthlyExpenseReportItem> repItems;
        private MonthlyReportSearchCriteria sc;

        public MonthlyExpenseReportForm(List<MonthlyExpenseReportItem> reps, MonthlyReportSearchCriteria m)
        {
            InitializeComponent();

            this.repItems = reps;
            this.sc = m;
            
        }

        private void MonthlyExpenseReportForm_Load(object sender, EventArgs e)
        {
            buildReport();
            this.reportViewer1.RefreshReport();
        }

        private void buildReport()
        {
            this.MonthlyExpenseReportItemBindingSource.DataSource = this.repItems;
            this.MonthlyReportSearchCriteriaBindingSource.DataSource = this.sc;
            
        }
    }
}
