using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class EditCategoryForm : BaseForm
    {
        private scadenzettiDbDataSet.CategoriaDataTable cdt;
        private int currentIndex;
        private string oldNome;
        private string oldDescr;
        private bool btnNextStatus;
        private bool btnPreviousStatus;

        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            //mostra il primo destinatario
            currentIndex = 0;
            loadCategorie(currentIndex);
            btnPreviousStatus = false;
            if (cdt.Count == 1) btnNextStatus = false;
            else btnNextStatus = true;
            disableControls();
        }

        private void disableControls()
        {
            txtNome.ReadOnly = true;
            txtDescr.ReadOnly = true;

            btnDelete.Enabled = true;
            btnNext.Enabled = btnNextStatus;
            btnPrevious.Enabled = btnPreviousStatus;
        }

        private void enableControls()
        {
            txtNome.ReadOnly = false;
            txtDescr.ReadOnly = false;

            btnDelete.Enabled = false;
            btnNextStatus = btnNext.Enabled;
            btnNext.Enabled = false;
            btnPreviousStatus = btnPrevious.Enabled;
            btnPrevious.Enabled = false;
        }

        private void loadCategorie(int index)
        {
            scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
            cdt = cta.GetDataOrderByNome();

            if (cdt.Count == 0)
            {
                MessageBox.Show("Non ci sono categorie archivio", "Nessuna categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            showCategoria(index);
        }

        private void showCategoria(int index)
        {
            txtNome.Text = cdt[index]["Nome"].ToString();
            txtDescr.Text = cdt[index]["Descrizione"].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            btnPrevious.Enabled = true;
            if (currentIndex + 1 >= cdt.Count)
            {
                currentIndex = cdt.Count - 1;
                btnNext.Enabled = false;
            }
            showCategoria(currentIndex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;
            btnNext.Enabled = true;
            if (currentIndex <= 0)
            {
                currentIndex = 0;
                btnPrevious.Enabled = false;
            }

            showCategoria(currentIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Sei sicuro di voler eliminare questa categoria?", "Conferma eliminazione categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int idCat = int.Parse(cdt[currentIndex]["ID"].ToString());
                if (HasAnyMovement(idCat))
                {
                    MessageBox.Show("Impossibile eliminare la categoria perchè esistono movimenti associati ad essa.",
                        "Comando negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    deleteCat(idCat);
                    currentIndex = (currentIndex - 1 >= 0) ? currentIndex - 1 : currentIndex;
                    loadCategorie(currentIndex);
                }
            }
        }

        private void deleteCat(int idCat)
        {
            scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
            cta.DeleteById(idCat);
        }

        private bool HasAnyMovement(int idCat)
        {
            scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter cmta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter();
            if (cmta.CategoriaInUse(idCat) > 0) return true;
            else return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!txtNome.ReadOnly) //salva eventuali modifiche e disabilita controlli
            {
                //validazione campi
                if (txtNome.Text == "")
                {
                    MessageBox.Show(this, "Nome della categoria è un campo obbligatorio.", "Mancano dati obbligatori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                disableControls();
                btnEdit.Text = "Modifica";
                if (IsThereAnyModification())
                {
                    //salva i dati nel db
                    scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
                    cta.UpdateById(txtNome.Text, txtDescr.Text, int.Parse(cdt[currentIndex]["ID"].ToString()));
                }

            }
            else
            {   //salva valori originali e abilita controlli
                enableControls();
                saveOldValues();
                btnEdit.Text = "Salva";
            }
        }

        private void saveOldValues()
        {
            oldNome = txtNome.Text;
            oldDescr = txtDescr.Text;
        }

        private bool IsThereAnyModification()
        {
            if (txtNome.Text != oldNome) return true;
            if (txtDescr.Text != oldDescr) return true;
            return false;
        }
    }
}
