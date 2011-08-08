using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class EditMovimentoForm : BaseForm
    {
        public int idMov;
        private scadenzettiDbDataSet.MovimentoDataTable mdt;
        private scadenzettiDbDataSet.CategoriaDataTable cdt;
        private scadenzettiDbDataSet.CategoriaMovimentoDataTable cmdt;

        //elenco campi form modificabili
        public bool ultimato;
        public DateTime dataScad;
        public DateTime dataUlt;
        public bool dataAppr;
        public decimal impIvato;
        public bool impIvAppr;
        public decimal impNetto;
        public string causale;
        public string note;
        public List<int> categories;

        public EditMovimentoForm(int id, string utente, string dest)
        {
            InitializeComponent();

            this.idMov = id;
            lblUtenteValue.Text = utente;
            lblDestValue.Text = dest;
            cbxUltim.ForeColor = Color.White;

            scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter mta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter();
            mdt = mta.GetDataById(idMov);

            loadValues();
        }

        private void loadValues()
        {
            if(mdt[0]["Tipo"].ToString() == "entrata"){
                lblArrow.Text = "<--";
                lblDataUlt.Text = "Data incasso";
                if ((bool)mdt[0]["Ultimato"])
                {
                    cbxUltim.Text = "incassato";
                    cbxUltim.BackColor = Color.YellowGreen;
                }
                else
                {
                    cbxUltim.Text = "non incassato";
                    cbxUltim.BackColor = Color.Red;
                    dtpickUltim.Enabled = false;
                }
            }
            else{
                lblArrow.Text = "-->";
                lblDataUlt.Text = "Data pagamento";
                if ((bool)mdt[0]["Ultimato"])
                {
                    cbxUltim.Text = "pagato";
                    cbxUltim.BackColor = Color.YellowGreen;
                }
                else
                {
                    cbxUltim.Text = "non pagato";
                    cbxUltim.BackColor = Color.Red;
                    dtpickUltim.Enabled = false;
                }
            }

            dtpickScadenza.Value = (DateTime)mdt[0]["DataScadenza"];
            if ((bool)mdt[0]["Ultimato"])
            {
                dtpickUltim.Value = (DateTime)mdt[0]["DataUltimaggio"];
            }
            cbxScadAppross.Checked = (bool)mdt[0]["DataApprossimata"];
            cbxImpAppross.Checked = (bool)mdt[0]["ImportoIvatoApprossimato"];

            txtImportoIvato.Text = mdt[0]["ImportoIvato"].ToString();
            txtImportoNetto.Text = mdt[0]["ImportoNetto"].ToString();
            txtCausale.Text = mdt[0]["Causale"].ToString();
            txtNote.Text = mdt[0]["Note"].ToString();


            loadCategorieMovimento();

        }

        private void loadCategorieMovimento()
        {
            //carico le categorie precedentemente assegnate nella lista
            categories = new List<int>();
            scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter cmta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter();
            cmdt = cmta.GetDataByMovimento(idMov);
            for (int i = 0; i < cmdt.Count; i++)
            {
                categories.Add(int.Parse(cmdt[i]["Categoria"].ToString()));
            }

            //elenco tutte le categorie
            scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
            cdt = cta.GetDataOrderByNome();
            for (int j = 0; j < cdt.Count; j++)
            {
                CategoryCheckbox catcbx = new CategoryCheckbox();
                catcbx.AutoSize = true;
                catcbx.IdCategoria = int.Parse(cdt[j]["ID"].ToString());
                catcbx.Text = cdt[j]["Nome"].ToString();
                if (categories.Contains(catcbx.IdCategoria))
                    catcbx.Checked = true;
                else catcbx.Checked = false;
                flowLayoutPanel.Controls.Add(catcbx);
            }


            
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validazione campi
            decimal impiv;
            try
            {
                impiv = decimal.Parse(txtImportoIvato.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(this, "L'importo del movimento deve essere un numero.", "Errore nel formato dell'importo ivato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal impnet = 0;
            if (txtImportoNetto.Text != "") //importo netto è opzionale
            {
                try
                {
                    impnet = decimal.Parse(txtImportoNetto.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(this, "L'importo netto del movimento deve essere un numero.", "Errore nel formato dell'importo netto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            ultimato = (cbxUltim.Text == "pagato" || cbxUltim.Text == "incassato") ? true : false;
            if (ultimato)
                dataUlt = dtpickUltim.Value;
            dataScad = dtpickScadenza.Value;
            dataAppr = cbxScadAppross.Checked;
            impIvato = impiv;
            impIvAppr = cbxImpAppross.Checked;
            impNetto = impnet;
            causale = txtCausale.Text;
            note = txtNote.Text;
            
            //raccolta categorie del movimento
            categories.Clear();
            foreach (CategoryCheckbox catcbx in flowLayoutPanel.Controls)
            {
                if (catcbx.Checked)
                    categories.Add(catcbx.IdCategoria);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Sei sicuro di voler eliminare questo movimento?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter cmta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter();
                cmta.DeleteByMovimento(idMov);
                scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter mta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter();
                mta.DeleteById(idMov);

                
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void cbxUltim_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxUltim.Text == "non incassato")
            {
                cbxUltim.Text = "incassato";
                cbxUltim.BackColor = Color.YellowGreen;
                dtpickUltim.Enabled = true;
            }
            else
            {
                if (cbxUltim.Text == "non pagato")
                {
                    cbxUltim.Text = "pagato";
                    cbxUltim.BackColor = Color.YellowGreen;
                    dtpickUltim.Enabled = true;
                }
                else
                {
                    if (cbxUltim.Text == "incassato")
                    {
                        cbxUltim.Text = "non incassato";
                        cbxUltim.BackColor = Color.Red;
                        dtpickUltim.Enabled = false;
                    }
                    else
                        if (cbxUltim.Text == "pagato")
                        {
                            cbxUltim.Text = "non pagato";
                            cbxUltim.BackColor = Color.Red;
                            dtpickUltim.Enabled = false;
                        }
                }
            }

        }
    }
}
