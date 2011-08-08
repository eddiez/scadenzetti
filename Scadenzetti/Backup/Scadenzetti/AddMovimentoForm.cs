using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddMovimentoForm : BaseForm
    {
        private scadenzettiDbDataSet.UtenteDataTable udt;
        private scadenzettiDbDataSet.DestinatarioMovDataTable ddt;

        public int idUtente;
        public int idDest;
        public string tipoMov;
        public DateTime scadenza;
        public bool scadAppr;
        public decimal impIvato;
        public bool impIvatoAppr;
        public decimal impNetto;
        public string causale;
        public string note;
        public List<int> movCategories;

        public AddMovimentoForm()
        {
            InitializeComponent();

            dtpickScadenza.Value = DateTime.Now;
            
        }

        

        private void AddMovimentoForm_Load(object sender, EventArgs e)
        {
            //popola dropdown utenti
            scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            udt = uta.GetDataOrderByNome();
            for(int i=0; i<udt.Count; i++){
                dropUtente.Items.Add(new UtenteDropDownItem(int.Parse(udt[i]["ID"].ToString()), 
                    udt[i]["Nome"].ToString()));
            }

            //popola dropdown destinatari
            scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter dta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter();
            ddt = dta.GetDataOrderByNome();
            for (int i = 0; i < ddt.Count; i++)
            {
                dropDest.Items.Add(new DestinatarioDropDownItem(int.Parse(ddt[i]["ID"].ToString()),
                    ddt[i]["Nome"].ToString()));
            }
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            SelectCategoryForm scf = new SelectCategoryForm(this.movCategories);
            DialogResult dr = scf.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if(this.movCategories!=null) this.movCategories.Clear();
                this.movCategories = scf.selectedCategory;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validazione input
            if (dropUtente.Text == "")
            {
                MessageBox.Show(this, "Selezionare il nome dell'utente", "Nome utente mancante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dropDest.Text == "")
            {
                MessageBox.Show(this, "Selezionare il nome del Destinatario", "Nome destinatario mancante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            decimal imp;
            try
            {
                imp = decimal.Parse(txtImportoIvato.Text);
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


            //impostazione campi locali
            idUtente = ((UtenteDropDownItem)dropUtente.SelectedItem).Id;
            idDest = ((DestinatarioDropDownItem)dropDest.SelectedItem).Id;
            tipoMov = cbxTipo.Text;
            scadenza = dtpickScadenza.Value;
            scadAppr = cbxScadAppross.Checked;
            impIvato = imp;
            impIvatoAppr = cbxImpAppross.Checked;
            impNetto = impnet;
            causale = txtCausale.Text;
            note = txtNote.Text;
            //categorie sono state già impostate

            this.DialogResult = DialogResult.OK;
        }

        private void cbxTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "uscita")
            {
                cbxTipo.Text = "entrata";
                cbxTipo.BackColor = Color.Green;
            }
            else
            {
                cbxTipo.Text = "uscita";
                cbxTipo.BackColor = Color.Red;
            }
        }
    }
}
