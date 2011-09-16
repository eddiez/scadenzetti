using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class ReportSearchCriteriaForm : BaseForm
    {
        private scadenzettiDbDataSet.UtenteDataTable udt;
        private scadenzettiDbDataSet.CategoriaDataTable cdt;
        private Dictionary<int, string> num2stringMonth;
        private Dictionary<string, int> string2intMonth;
        DataAccessGateway dag;

        public ReportSearchCriteriaForm()
        {
            InitializeComponent();

            dag = new DataAccessGateway();

            initializeMonthDictionaries();

            scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            udt = uta.GetDataOrderByNome();

            scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
            cdt = cta.GetDataOrderByNome();

            //inizializzazione controlli
            initializeMonthExpenseTab();
            initializeYearMatrixTab();
            initializeCategTab();
            initializePersTab();
        }

        private void initializePersTab()
        {
            //intervallo predefinito: dal mese scorso al prossimo messe
            dtDataFrom.Value = DateTime.Today.AddMonths(-1);
            dtDataTo.Value = DateTime.Today.AddMonths(1);
        }

        private void initializeCategTab()
        {
            CategoryRadioButton crb;
            for (int i = 0; i < cdt.Count; i++)
            {
                crb = new CategoryRadioButton();
                crb.IdCategoria = int.Parse(cdt[i]["ID"].ToString());
                crb.Text = cdt[i]["Nome"].ToString();
                crb.Size = new Size(270, 25);
                flowLayoutPanelCategories.Controls.Add(crb);
            }
        }

        private void initializeYearMatrixTab()
        {
            numericUpDownMatrix.Value = DateTime.Now.Year;
        }

        private void initializeMonthDictionaries()
        {
            num2stringMonth = new Dictionary<int, string>();
            num2stringMonth.Add(1, "Gennaio");
            num2stringMonth.Add(2, "Febbraio");
            num2stringMonth.Add(3, "Marzo");
            num2stringMonth.Add(4, "Aprile");
            num2stringMonth.Add(5, "Maggio");
            num2stringMonth.Add(6, "Giugno");
            num2stringMonth.Add(7, "Luglio");
            num2stringMonth.Add(8, "Agosto");
            num2stringMonth.Add(9, "Settembre");
            num2stringMonth.Add(10, "Ottobre");
            num2stringMonth.Add(11, "Novembre");
            num2stringMonth.Add(12, "Dicembre");

            string2intMonth = new Dictionary<string, int>();
            string2intMonth.Add("Gennaio", 1);
            string2intMonth.Add("Febbraio", 2);
            string2intMonth.Add("Marzo", 3);
            string2intMonth.Add("Aprile", 4);
            string2intMonth.Add("Maggio", 5);
            string2intMonth.Add("Giugno", 6);
            string2intMonth.Add("Luglio", 7);
            string2intMonth.Add("Agosto", 8);
            string2intMonth.Add("Settembre", 9);
            string2intMonth.Add("Ottobre", 10);
            string2intMonth.Add("Novembre", 11);
            string2intMonth.Add("Dicembre", 12);
        }

        private void initializeMonthExpenseTab()
        {
            UserCheckBox ucbx;
            for (int i = 0; i < udt.Count; i++)
            {
                ucbx = new UserCheckBox();
                ucbx.IdUtente = int.Parse(udt[i]["ID"].ToString());
                ucbx.Text = udt[i]["Nome"].ToString();
                ucbx.Size = new Size(290, 20);
                flowLayoutPanelUsers.Controls.Add(ucbx);
            }

            numAnno.Value = DateTime.Now.Year;
            cbxMese.SelectedIndex =  DateTime.Now.Month-1;
        }

        private void btnCreateMonthlyExpense_Click(object sender, EventArgs e)
        {
            List<int> selectedIdUser = new List<int>();

            MonthlyReportSearchCriteria mesc = new MonthlyReportSearchCriteria();
            mesc.Mese = cbxMese.Text;
            mesc.Anno = numAnno.Value.ToString();
            foreach (UserCheckBox u in flowLayoutPanelUsers.Controls)
            {
                if (u.Checked)
                {
                    selectedIdUser.Add(u.IdUtente);
                    mesc.addUser(u.Text);
                }
            }

            if (selectedIdUser.Count == 0)
            {
                MessageBox.Show(this, "Selezionare almeno un utente dalla lista.", "Nessun utente selezionato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            List<MonthlyExpenseReportItem> list =
                dag.getDataForMonthlyExpense(string2intMonth[cbxMese.Text], (int)numAnno.Value, selectedIdUser);
            
            
            MonthlyExpenseReportForm merf = new MonthlyExpenseReportForm(list, mesc);
            
            merf.Show();
        }

        private void btnCreateMatrixReport_Click(object sender, EventArgs e)
        {
            List<YearMatrixReportItem> list = dag.cercaMovimentiAnnata((int)numericUpDownMatrix.Value);

            YearMatrixReportForm ymrf = new YearMatrixReportForm(list);
            ymrf.Show();
        }

        private void btnCreateCategoryReport_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Id = 0;
            foreach (CategoryRadioButton crb in flowLayoutPanelCategories.Controls)
                if (crb.Checked)
                {
                    cat.Id = crb.IdCategoria;
                    cat.Nome = crb.Text;
                    break;
                }
            //non ho selezionato alcuna categoria
            if (cat.Id == 0)
            {
                MessageBox.Show(this, "Selezionare almeno una categoria di movimenti", "Nessuna categoria selezionata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            List<MonthlyExpenseReportItem> list = dag.cercaMovimentiCategoria(cat.Id);

            CategoryReportForm crf = new CategoryReportForm(cat, list);
            crf.Show();

            
        }

        private void btnCreateAllReport_Click(object sender, EventArgs e)
        {
            List<MonthlyExpenseReportItem> list = dag.cercaTuttiMov(dtDataFrom.Value, dtDataTo.Value);
            DateSearchCriteria dsc = new DateSearchCriteria();
            dsc.From = dtDataFrom.Value;
            dsc.To = dtDataTo.Value;

            ReportAllMovForm ramf = new ReportAllMovForm(list, dsc);
            ramf.Show();

        }

        
    }
}
