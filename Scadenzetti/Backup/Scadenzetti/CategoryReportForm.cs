using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class CategoryReportForm : BaseForm
    {
        private Categoria c;
        private List<MonthlyExpenseReportItem> list;

        public CategoryReportForm(Categoria cat, List<MonthlyExpenseReportItem> l)
        {
            InitializeComponent();

            this.c = cat;
            this.list = l;
        }

        private void CategoryReportForm_Load(object sender, EventArgs e)
        {
            
            buildReport();
            
            this.reportViewer1.RefreshReport();
        }

        private void buildReport() {
            CategoriaBindingSource.DataSource = this.c;
            MonthlyExpenseReportItemBindingSource.DataSource = this.list;
        }
    }
}
