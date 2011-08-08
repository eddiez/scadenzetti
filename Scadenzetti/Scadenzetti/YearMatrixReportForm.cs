using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class YearMatrixReportForm : BaseForm
    {
        private List<YearMatrixReportItem> l;

        public YearMatrixReportForm(List<YearMatrixReportItem> list)
        {
            InitializeComponent();

            this.l = list;
        }

        private void YearMatrixReportForm_Load(object sender, EventArgs e)
        {
            buildReport();
            this.reportViewer1.RefreshReport();
        }

        private void buildReport()
        {
            this.YearMatrixReportItemBindingSource.DataSource = this.l;
        }
    }
}
