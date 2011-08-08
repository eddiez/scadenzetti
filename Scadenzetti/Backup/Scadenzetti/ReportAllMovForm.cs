using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class ReportAllMovForm : BaseForm
    {
        private List<MonthlyExpenseReportItem> list;
        private DateSearchCriteria dsc;

        public ReportAllMovForm(List<MonthlyExpenseReportItem> l, DateSearchCriteria criteria)
        {
            InitializeComponent();

            this.list = l;
            this.dsc = criteria;
        }

        private void ReportAllMovForm_Load(object sender, EventArgs e)
        {
            buildReport();
            this.reportViewer1.RefreshReport();
        }

        private void buildReport()
        {
            this.MonthlyExpenseReportItemBindingSource.DataSource = this.list;
            this.DateSearchCriteriaBindingSource.DataSource = this.dsc;

        }
    }
}
