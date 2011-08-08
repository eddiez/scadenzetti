using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddRateMovimento : BaseForm
    {
        public List<RataMovimento> rate;

        private DataTable rateDt;

        public AddRateMovimento(decimal numrate, List<RataMovimento> rm)
        {
            InitializeComponent();

            rate = new List<RataMovimento>();

            

            //inizializza data grid
            rateDt = new DataTable();
            rateDt.Columns.Add("N° rata", typeof(int));
            rateDt.Columns.Add("Scadenza", typeof(DateTime));
            rateDt.Columns.Add("Importo", typeof(decimal));


            loadRateData(numrate, rm);

            rateDataGrid.DataSource = rateDt;

            rateDataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rateDataGrid.Columns["Scadenza"].DefaultCellStyle.Format = "d";
            rateDataGrid.Columns["N° rata"].ReadOnly = true;
            rateDataGrid.DefaultCellStyle.Font = new Font("Verdana", 9);
            rateDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rateDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11);
        }

        private void loadRateData(decimal numrate, List<RataMovimento> rm)
        {

            if (rm == null)
            //carico solo i progressivi delle rate
            {
                for (int i = 1; i <= numrate; i++)
                {
                    rateDt.Rows.Add(i, null, null);
                }
                return;
            }
            
            if (rm.Count >= numrate)
            {
                foreach (RataMovimento r in rm)
                {
                    if (r.Progr <= numrate)
                        rateDt.Rows.Add(r.Progr, r.Scadenza, r.Importo);
                    else break;
                }
            }
            else
            {
                foreach (RataMovimento r in rm)
                {
                    rateDt.Rows.Add(r.Progr, r.Scadenza, r.Importo);
                }
                for (int i = rm.Count + 1; i <= numrate; i++)
                {
                    rateDt.Rows.Add(i, null, null);
                }
            }
        }

        private void rateDataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (rateDataGrid.Columns[e.ColumnIndex].Name == "Importo")
            {
                if (e.FormattedValue != null && e.FormattedValue!="")
                {
                    try
                    {
                        decimal d = Decimal.Parse(e.FormattedValue.ToString());
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Importo dev'essere un numero", "Errore nel formato dell'input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; 
                    }
                }
            }

            if (rateDataGrid.Columns[e.ColumnIndex].Name == "Scadenza")
            {
                if (e.FormattedValue != null && e.FormattedValue.ToString() != "")
                {
                    try
                    {
                        DateTime d = DateTime.Parse(e.FormattedValue.ToString());
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Scadenza dev'essere una data nel formato dd/mm/yyyy", "Errore nel formato dell'input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private bool isDataGridComplete()
        {
            foreach (DataRow dr in rateDt.Rows)
            {
                if (dr["Scadenza"] == null || dr["Scadenza"].ToString() == "" || dr["Importo"] == null || dr["Importo"].ToString() == "")
                    return false;
            }
            return true;
        }

        private bool areImportPositive()
        {
            foreach (DataRow dr in rateDt.Rows)
            {
                if(decimal.Parse(dr["Importo"].ToString()) <= 0)
                    return false;
            }
            return true;
        }

        private bool areRateDateConsecutive()
        {
            DateTime previous = DateTime.MinValue;
            DateTime next;
            foreach (DataRow dr in rateDt.Rows)
            {
                next = DateTime.Parse(dr["Scadenza"].ToString());
                if (DateTime.Compare(previous, next) >= 0)
                {
                    return false;
                }
                previous = next;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //validazione rate
            if (!isDataGridComplete())
            {
                MessageBox.Show("I dati sulle rate sono incompleti", "Dati incompleti", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!areImportPositive())
            {
                MessageBox.Show("Gli importi delle rate devono essere positivi", "Importi errati", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!areRateDateConsecutive())
            {
                MessageBox.Show("Le date di scadenza delle rate non sono consecutive", "Date errate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //creazione lista risultato
            RataMovimento r;
            rate.Clear();
            foreach (DataRow dr in rateDt.Rows)
            {
                r = new RataMovimento();
                r.Progr = int.Parse(dr["N° rata"].ToString());
                r.Scadenza = DateTime.Parse(dr["Scadenza"].ToString());
                r.Importo = decimal.Parse(dr["Importo"].ToString());

                rate.Add(r);
            }

            this.DialogResult = DialogResult.OK;

        }
    }
}
