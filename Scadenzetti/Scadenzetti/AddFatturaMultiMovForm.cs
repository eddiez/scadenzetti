using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddFatturaMultiMovForm : BaseForm
    {
        private scadenzettiDbDataSet.UtenteDataTable udt;
        private scadenzettiDbDataSet.DestinatarioMovDataTable ddt;
        private scadenzettiDbDataSet.CategoriaDataTable cdt;
        private scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta;
        scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter dta;
        private DataAccessGateway dag;
        private List<Categoria> catlist;
        private List<MovimentoFatturaControl> catControls;

        public int idUtente;
        public int idDest;
        public DateTime scadenza;
        public decimal impIvato;
        public decimal impNetto;
        public string causalePrefix;
        public List<int> movCategories;
        public List<Movimento> fatturaMovs;
        

        public AddFatturaMultiMovForm()
        {
            InitializeComponent();
            dag = new DataAccessGateway();
        }

        private void AddFatturaMultiMovForm_Load(object sender, EventArgs e)
        {
            //popola dropdown utenti
            uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            udt = uta.GetDataOrderByNome();
            for (int i = 0; i < udt.Count; i++)
            {
                dropUtente.Items.Add(new UtenteDropDownItem(int.Parse(udt[i]["ID"].ToString()),
                    udt[i]["Nome"].ToString()));
            }

            //popola dropdown destinatari
            dta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter();
            ddt = dta.GetDataOrderByNome();
            for (int i = 0; i < ddt.Count; i++)
            {
                dropDest.Items.Add(new DestinatarioDropDownItem(int.Parse(ddt[i]["ID"].ToString()),
                    ddt[i]["Nome"].ToString()));
            }

            //aggiungi due blocchi categoria
            catControls = new List<MovimentoFatturaControl>();
            scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
            cdt = cta.GetDataOrderByNome();
            catlist = new List<Categoria>();
            Categoria cat;
            foreach(scadenzettiDbDataSet.CategoriaRow cr in cdt){
                cat = new Categoria();
                cat.Id = cr.ID;
                cat.Nome = cr.Nome;
                catlist.Add(cat);
            }
            MovimentoFatturaControl mfc = new MovimentoFatturaControl(catlist);
            catControls.Add(mfc);
            flowLayoutPanelMovs.Controls.Add(mfc);
            mfc.TotalChanged += totaleFattura_Changed;

            mfc = new MovimentoFatturaControl(catlist);
            catControls.Add(mfc);
            flowLayoutPanelMovs.Controls.Add(mfc);
            mfc.TotalChanged += totaleFattura_Changed;

            lblNumMovFattura.Text = "2";
        }

        private void totaleFattura_Changed(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (MovimentoFatturaControl mfc in catControls)
            {
                total += mfc.getTotaleCategoria();
            }
            lblTotale.Text = total.ToString("C");
        }

        private void btnAddDest_Click(object sender, EventArgs e)
        {
            AddDestinatarioForm adf = new AddDestinatarioForm();
            DialogResult dr = adf.ShowDialog();

            if (dr == DialogResult.OK)
            {
                dag.salvaDestinatario(adf.piva, adf.nome, adf.sede, adf.descr);
                dropDest.Items.Clear();
                ddt = dta.GetDataOrderByNome();
                int itemToSelect = 0;
                for (int i = 0; i < ddt.Count; i++)
                {
                    if (ddt[i]["Nome"].ToString() == adf.nome)
                        itemToSelect = i;
                    dropDest.Items.Add(new DestinatarioDropDownItem(int.Parse(ddt[i]["ID"].ToString()),
                        ddt[i]["Nome"].ToString()));
                }

                dropDest.SelectedIndex = itemToSelect;
            }
        }

        private void btnAddMovFattura_Click(object sender, EventArgs e)
        {
            MovimentoFatturaControl mfc = new MovimentoFatturaControl(catlist);
            catControls.Add(mfc);
            flowLayoutPanelMovs.Controls.Add(mfc);
            lblNumMovFattura.Text = catControls.Count.ToString();

            mfc.TotalChanged += totaleFattura_Changed;
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


            if (txtTotFattura.Text != "")
            {
                try
                {
                    float.Parse(txtTotFattura.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show(this, "Il totale fattura dev'essere un numero", "Formato totale fattura errato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //impostazione campi locali
            idUtente = ((UtenteDropDownItem)dropUtente.SelectedItem).Id;
            idDest = ((DestinatarioDropDownItem)dropDest.SelectedItem).Id;
            scadenza = dtpickScadenza.Value;
            causalePrefix = txtCausale.Text;

            //Movimento m;
            int idcat;
            foreach (MovimentoFatturaControl mfc in catControls)
            {
                movCategories = new List<int>();
                idcat = mfc.getIdCategoria();
                if(idcat==0)
                    dag.salvaMovimento("uscita", scadenza, false, mfc.getTotaleCategoria(), false,
                    0, causalePrefix + " - " + mfc.getCausaleSuffix() + " (tot.fattura € "+ txtTotFattura.Text +")", "", idUtente, idDest, null);
                else{

                    movCategories.Add(idcat);
                    dag.salvaMovimento("uscita", scadenza, false, mfc.getTotaleCategoria(), false,
                        0, causalePrefix + " - " + mfc.getCausaleSuffix() + " (tot.fattura € " + txtTotFattura.Text + ")", "", idUtente, idDest, movCategories);
                }
            }

            
            this.DialogResult = DialogResult.OK;
        }
    }
}
