using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class MainForm : BaseForm
    {
        private DataAccessGateway dag;
        private DataTable elapsedMovDt;
        private DataTable nextMonthMovDt;

        public MainForm()
        {
            InitializeComponent();

            dag = new DataAccessGateway();
            initializeDataGrids();
        }

        private void initializeDataGrids()
        {
            //grid movimenti scaduti
            elapsedMovDt = new DataTable();
            elapsedMovDt.Columns.Add("Scadenza", typeof(string));
            elapsedMovDt.Columns.Add("Importo", typeof(float));
            elapsedMovDt.Columns.Add("Utente", typeof(string));
            elapsedMovDt.Columns.Add("Destinatario", typeof(string));
            elapsedMovDt.Columns.Add("id", typeof(int));
            elapsedMovDt.Columns.Add("tipo", typeof(string));
            //elapsedMovDt.Rows.Add();
            //elapsedMovDt.Rows.Add(DateTime.Now.ToShortDateString(), 120, "io", "tu", 1, "uscita");

            datagridElapsedMov.DataSource = elapsedMovDt;
            //styles
            datagridElapsedMov.Columns["id"].Visible = false;
            datagridElapsedMov.Columns["tipo"].Visible = false;
            datagridElapsedMov.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridElapsedMov.DefaultCellStyle.Font = new Font("Verdana", 9);
            datagridElapsedMov.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridElapsedMov.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11);

            //grid movimenti prossimo mese
            nextMonthMovDt = new DataTable();
            nextMonthMovDt.Columns.Add("Scadenza", typeof(string));
            nextMonthMovDt.Columns.Add("Importo", typeof(float));
            nextMonthMovDt.Columns.Add("Utente", typeof(string));
            nextMonthMovDt.Columns.Add("Destinatario", typeof(string));
            nextMonthMovDt.Columns.Add("id", typeof(int));
            nextMonthMovDt.Columns.Add("tipo", typeof(string));
            

            dataGridNextMonthMov.DataSource = nextMonthMovDt;
            //styles
            dataGridNextMonthMov.Columns["id"].Visible = false;
            dataGridNextMonthMov.Columns["tipo"].Visible = false;
            dataGridNextMonthMov.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridNextMonthMov.DefaultCellStyle.Font = new Font("Verdana", 9);
            dataGridNextMonthMov.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridNextMonthMov.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11);

        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewMov_Click(object sender, EventArgs e)
        {
            AddMovimentoForm amf = new AddMovimentoForm();
            DialogResult dr = amf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dag.salvaMovimento(amf.tipoMov, amf.scadenza, amf.scadAppr, amf.impIvato, amf.impIvatoAppr,
                    amf.impNetto, amf.causale, amf.note, amf.idUtente, amf.idDest, amf.movCategories);

                this.loadElapsedMovDataGrid();
                this.loadNextMonthMovDataGrid();
            }
        }

        private void aggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            DialogResult dr = auf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dag.salvaUtente(auf.tipo, auf.cf, auf.piva, auf.nome, auf.sede, auf.descr);
            }

        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm euf = new EditUserForm();
            euf.ShowDialog();
        }

        private void aggiungiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDestinatarioForm adf = new AddDestinatarioForm();
            DialogResult dr = adf.ShowDialog();

            if (dr == DialogResult.OK)
            {
                dag.salvaDestinatario(adf.piva, adf.nome, adf.sede, adf.descr);
            }
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditDestinatarioForm edf = new EditDestinatarioForm();
            edf.ShowDialog();
        }

        private void aggiungiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddCategoryForm acf = new AddCategoryForm();
            DialogResult dr = acf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dag.salvaCategoria(acf.nome, acf.descr);
            }
        }

        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditCategoryForm ecf = new EditCategoryForm();
            ecf.ShowDialog();
        }

        private void btnSearchMov_Click(object sender, EventArgs e)
        {
            SearchMovimentiForm smf = new SearchMovimentiForm();
            smf.ShowDialog();

            if (smf.hasModifiedAnyMov)
            {
                loadElapsedMovDataGrid();
                loadNextMonthMovDataGrid();
            }
        }

        private void btnPrintMov_Click(object sender, EventArgs e)
        {
            ReportSearchCriteriaForm rscf = new ReportSearchCriteriaForm();
            rscf.ShowDialog();
        }

        private void aboutScadenzettiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        public void loadElapsedMovDataGrid()
        {
            List<Movimento> list = dag.cercaMovimentiScaduti();
            elapsedMovDt.Clear();
            foreach(Movimento m in list){
                elapsedMovDt.Rows.Add(m.DataScadenza.ToShortDateString(), m.ImportoIvato, m.Utente.Nome, m.Destinatario.Nome,
                    m.Id, m.Tipo);
            }
            datagridElapsedMov.Refresh();
        }

        private void loadNextMonthMovDataGrid()
        {
            List<Movimento> list = dag.cercaMovimentiProssimoMese();
            nextMonthMovDt.Clear();
            foreach (Movimento m in list)
            {
                nextMonthMovDt.Rows.Add(m.DataScadenza.ToShortDateString(), m.ImportoIvato, m.Utente.Nome, m.Destinatario.Nome,
                    m.Id, m.Tipo);
            }
            dataGridNextMonthMov.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadElapsedMovDataGrid();
            loadNextMonthMovDataGrid();
        }

        

        private void datagridElapsedMov_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (datagridElapsedMov.Rows[e.RowIndex].Cells["tipo"].Value.ToString() == "uscita")
            {
                datagridElapsedMov.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            if (datagridElapsedMov.Rows[e.RowIndex].Cells["tipo"].Value.ToString() == "entrata")
            {
                datagridElapsedMov.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        private void dataGridNextMonthMov_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridNextMonthMov.Rows[e.RowIndex].Cells["tipo"].Value.ToString() == "uscita")
            {
                dataGridNextMonthMov.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            if (dataGridNextMonthMov.Rows[e.RowIndex].Cells["tipo"].Value.ToString() == "entrata")
            {
                dataGridNextMonthMov.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        private void datagridElapsedMov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //prelevamento dati movimento
            int idMov = (int)datagridElapsedMov.SelectedRows[0].Cells["id"].Value;
            string nomeUtente = datagridElapsedMov.SelectedRows[0].Cells["Utente"].Value.ToString();
            string nomeDest = datagridElapsedMov.SelectedRows[0].Cells["Destinatario"].Value.ToString();

            EditMovimentoForm emf = new EditMovimentoForm(idMov, nomeUtente, nomeDest);
            DialogResult dr = emf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DateTime? dataUlt = emf.ultimato ? (DateTime?)emf.dataUlt : null;
                //update movimento nel db
                dag.aggiornaMovimento(idMov, emf.ultimato, emf.dataScad, emf.dataAppr, dataUlt,
                    emf.impIvato, emf.impIvAppr, emf.impNetto, emf.causale, emf.note, emf.categories);

                //pulisco i risultati di ricerca perchè non più rilevanti
                loadElapsedMovDataGrid();
            }

            if (dr == DialogResult.Abort)
            {
                //pulisco i risultati di ricerca perchè non più rilevanti
                loadElapsedMovDataGrid();
            }
        }

        

        private void dataGridNextMonthMov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //prelevamento dati movimento
            int idMov = (int)dataGridNextMonthMov.SelectedRows[0].Cells["id"].Value;
            string nomeUtente = dataGridNextMonthMov.SelectedRows[0].Cells["Utente"].Value.ToString();
            string nomeDest = dataGridNextMonthMov.SelectedRows[0].Cells["Destinatario"].Value.ToString();

            EditMovimentoForm emf = new EditMovimentoForm(idMov, nomeUtente, nomeDest);
            DialogResult dr = emf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DateTime? dataUlt = emf.ultimato ? (DateTime?)emf.dataUlt : null;
                //update movimento nel db
                dag.aggiornaMovimento(idMov, emf.ultimato, emf.dataScad, emf.dataAppr, dataUlt,
                    emf.impIvato, emf.impIvAppr, emf.impNetto, emf.causale, emf.note, emf.categories);

                //pulisco i risultati di ricerca perchè non più rilevanti
                loadNextMonthMovDataGrid();
            }

            if (dr == DialogResult.Abort)
            {
                //pulisco i risultati di ricerca perchè non più rilevanti
                loadNextMonthMovDataGrid();
            }
        }
    }
}
