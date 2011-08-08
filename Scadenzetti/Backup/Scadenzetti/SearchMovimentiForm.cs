using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class SearchMovimentiForm : BaseForm
    {
        public bool hasModifiedAnyMov = false;

        private scadenzettiDbDataSet.UtenteDataTable udt;
        private scadenzettiDbDataSet.DestinatarioMovDataTable ddt;
        private scadenzettiDbDataSet.MovimentoDataTable mdt;
        private DataAccessGateway dag;
        DataTable dt;

        private Dictionary<int, string> Utenti;
        private Dictionary<int, string> Destinatari;

        
        public SearchMovimentiForm()
        {
            InitializeComponent();

            dag = new DataAccessGateway();

            setupMovimentiDataGrid();

            dtpickDataDa.Value = DateTime.Today.AddMonths(-1);
            dtpickDataA.Value = DateTime.Today.AddMonths(1);

            Utenti = new Dictionary<int, string>();
            Destinatari = new Dictionary<int, string>();
        }

        private void setupMovimentiDataGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("Scadenza", typeof(string));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Importo", typeof(float));
            dt.Columns.Add("Utente", typeof(string));
            dt.Columns.Add("Destinatario", typeof(string));
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Pagato/Incassato", typeof(bool));
            //dt.Rows.Add();
            //dt.Rows.Add(DateTime.Now.ToShortDateString(), "uscita", 120, "io", "tu");

            dataGridMov.DataSource = dt;
            //styles
            dataGridMov.Columns["id"].Visible = false;
            dataGridMov.Columns["Tipo"].Visible = false;
            dataGridMov.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMov.DefaultCellStyle.Font = new Font("Verdana", 9);
            dataGridMov.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMov.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11);
        }

        private void SearchMovimentiForm_Load(object sender, EventArgs e)
        {
            //popola dropdown utenti
            dropUtente.Items.Add(""); //scelta vuota
            scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            udt = uta.GetDataOrderByNome();
            int idUtente;
            string nomeUtente;
            for (int i = 0; i < udt.Count; i++)
            {
                idUtente = int.Parse(udt[i]["ID"].ToString());
                nomeUtente = udt[i]["Nome"].ToString();
                dropUtente.Items.Add(new UtenteDropDownItem(idUtente, nomeUtente));
                Utenti.Add(idUtente, nomeUtente);

            }

            //popola dropdown destinatari
            dropDest.Items.Add(""); //scelta vuota
            scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter dta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter();
            ddt = dta.GetDataOrderByNome();
            int idDest;
            string nomeDest;
            for (int i = 0; i < ddt.Count; i++)
            {
                idDest = int.Parse(ddt[i]["ID"].ToString());
                nomeDest = ddt[i]["Nome"].ToString();
                dropDest.Items.Add(new DestinatarioDropDownItem(idDest,nomeDest));
                Destinatari.Add(idDest, nomeDest);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idutente;
            int iddest;

            //prelevamento criteri di ricerca
            if (dropUtente.Text == "")
            {
                idutente = -1;
            }
            else
            {
                idutente = ((UtenteDropDownItem)dropUtente.SelectedItem).Id;
            }
            if (dropDest.Text == "")
            {
                iddest = -1;
            }
            else
            {
                iddest = ((DestinatarioDropDownItem)dropDest.SelectedItem).Id;
            }

            
            //esecuzione query movimenti
            mdt = dag.cercaMovimenti(idutente, iddest, dtpickDataDa.Value, dtpickDataA.Value.AddDays(1).AddSeconds(-1));

            fillMovDataGrid(mdt);

        }

        private void fillMovDataGrid(scadenzettiDbDataSet.MovimentoDataTable mdt)
        {
            dt.Clear();
            string nomeUtente;
            string nomeDest;
            if (mdt.Count == 0)
            {
                MessageBox.Show(this, "La ricerca non ha prodotto alcun risultato", "Nessun risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < mdt.Count; i++)
            {
                nomeUtente = Utenti[int.Parse(mdt[i]["Utente"].ToString())];
                nomeDest = Destinatari[int.Parse(mdt[i]["DestinatarioMov"].ToString())];
                dt.Rows.Add(((DateTime)mdt[i]["DataScadenza"]).ToShortDateString(),
                    mdt[i]["Tipo"].ToString(), mdt[i]["ImportoIvato"].ToString(),
                    nomeUtente, nomeDest, int.Parse(mdt[i]["ID"].ToString()), bool.Parse(mdt[i]["Ultimato"].ToString()));
            }
            dataGridMov.Refresh();
            
        }

        
        private void dataGridMov_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridMov.Rows[e.RowIndex].Cells["tipo"].Value.ToString() == "uscita")
            {
                dataGridMov.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            if (dataGridMov.Rows[e.RowIndex].Cells["tipo"].Value.ToString() == "entrata")
            {
                dataGridMov.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        private void dataGridMov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //prelevamento dati movimento
            int? idMovN = dataGridMov.SelectedRows[0].Cells["id"].Value as int?;
            int idMov = (idMovN == null) ? 0 : (int)idMovN;
            string nomeUtente = dataGridMov.SelectedRows[0].Cells["Utente"].Value.ToString();
            string nomeDest = dataGridMov.SelectedRows[0].Cells["Destinatario"].Value.ToString();

            EditMovimentoForm emf = new EditMovimentoForm(idMov, nomeUtente, nomeDest);
            DialogResult dr = emf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DateTime? dataUlt = emf.ultimato ? (DateTime?)emf.dataUlt : null;
                //update movimento nel db
                dag.aggiornaMovimento(idMov, emf.ultimato, emf.dataScad, emf.dataAppr, dataUlt,
                    emf.impIvato, emf.impIvAppr, emf.impNetto, emf.causale, emf.note, emf.categories);

                //pulisco i risultati di ricerca perchè non più rilevanti
                dt.Clear();
                this.hasModifiedAnyMov = true;
            }

            if (dr == DialogResult.Abort)
            {
                //pulisco i risultati di ricerca perchè non più rilevanti
                dt.Clear();
                this.hasModifiedAnyMov = true;
            }
        }

        
    }
}
