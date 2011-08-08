using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddRateazioneForm : BaseForm
    {
        private scadenzettiDbDataSet.UtenteDataTable udt;
        private scadenzettiDbDataSet.DestinatarioMovDataTable ddt;

        public int idUtente;
        public int idDest;
        public string tipoMov;
        public string causale;
        public string note;
        public List<int> movCategories;
        public List<RataMovimento> rate;

        public AddRateazioneForm()
        {
            InitializeComponent();
        }

        private void AddRateazioneForm_Load(object sender, EventArgs e)
        {
            //popola dropdown utenti
            scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            udt = uta.GetDataOrderByNome();
            for (int i = 0; i < udt.Count; i++)
            {
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
                if (this.movCategories != null) this.movCategories.Clear();
                this.movCategories = scf.selectedCategory;
            }
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

        private void btnInsertRate_Click(object sender, EventArgs e)
        {
            AddRateMovimento arm = new AddRateMovimento(rateUpDown.Value, this.rate);
            DialogResult dr = arm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (this.rate != null) this.rate.Clear();
                this.rate = arm.rate;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
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

            if (rate == null)
            {
                MessageBox.Show(this, "Inserire i dettagli delle rate", "Mancano i dettagli delle rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //salvataggio risultati nei campi della form
            idUtente = ((UtenteDropDownItem)dropUtente.SelectedItem).Id;
            idDest = ((DestinatarioDropDownItem)dropDest.SelectedItem).Id;
            tipoMov = cbxTipo.Text;
            causale = txtCausale.Text;
            note = txtNote.Text;
            //categorie e rate sono già state impostate
            this.DialogResult = DialogResult.OK;
        }
    }
}
