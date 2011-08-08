using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class EditDestinatarioForm : BaseForm
    {
        private scadenzettiDbDataSet.DestinatarioMovDataTable ddt;
        private int currentIndex;
        private string oldNome;
        private string oldPiva;
        private string oldSede;
        private string oldDescr;
        private bool btnNextStatus;
        private bool btnPreviousStatus;

        public EditDestinatarioForm()
        {
            InitializeComponent();
        }

        private void EditDestinatarioForm_Load(object sender, EventArgs e)
        {
            //mostra il primo destinatario
            currentIndex = 0;
            loadDestinatari(currentIndex);
            btnPreviousStatus = false;

            if (ddt.Count == 1) btnNextStatus = false;
            else btnNextStatus = true;
            disableControls();
        }

        private void disableControls()
        {
            txtNome.ReadOnly = true;
            txtPiva.ReadOnly = true;
            txtSede.ReadOnly = true;
            txtDescr.ReadOnly = true;

            btnDelete.Enabled = true;
            btnNext.Enabled = btnNextStatus;
            btnPrevious.Enabled = btnPreviousStatus;
        }

        private void enableControls()
        {
            txtNome.ReadOnly = false;
            txtPiva.ReadOnly = false;
            txtSede.ReadOnly = false;
            txtDescr.ReadOnly = false;

            btnDelete.Enabled = false;
            btnNextStatus = btnNext.Enabled;
            btnNext.Enabled = false;
            btnPreviousStatus = btnPrevious.Enabled;
            btnPrevious.Enabled = false;
        }

        private void loadDestinatari(int index)
        {
            scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter dta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter();
            ddt = dta.GetDataOrderByNome();

            if (ddt.Count == 0)
            {
                MessageBox.Show("Non ci sono destinatari in archivio", "Nessun destinatario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            showDestinatario(index);
        }

        private void showDestinatario(int index)
        {
            txtNome.Text = ddt[index]["Nome"].ToString();
            txtPiva.Text = ddt[index]["PIVA"].ToString();
            txtSede.Text = ddt[index]["Sede"].ToString();
            txtDescr.Text = ddt[index]["Descrizione"].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            btnPrevious.Enabled = true;
            if (currentIndex + 1 >= ddt.Count)
            {
                currentIndex = ddt.Count - 1;
                btnNext.Enabled = false;
            }
            showDestinatario(currentIndex);
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

            showDestinatario(currentIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Sei sicuro di voler eliminare questo destinatario?", "Conferma eliminazione destinatario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int idDest = int.Parse(ddt[currentIndex]["ID"].ToString());
                if (HasAnyMovement(idDest))
                {
                    MessageBox.Show("Impossibile eliminare il destinatario perchè esistono movimenti associati ad esso.",
                        "Comando negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    deleteDest(idDest);
                    currentIndex = (currentIndex - 1 >= 0) ? currentIndex - 1 : currentIndex;
                    loadDestinatari(currentIndex);
                }
            }
        }

        private void deleteDest(int idDest)
        {
            scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter dta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter();
            dta.DeleteById(idDest);
        }

        private bool HasAnyMovement(int idDest)
        {
            scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter mta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter();
            if (mta.DestinatarioInUse(idDest) > 0) return true;
            else return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!txtNome.ReadOnly) //salva eventuali modifiche e disabilita controlli
            {
                //validazione campi
                if (txtNome.Text == "")
                {
                    MessageBox.Show(this, "Nome del destinatario è un campo obbligatorio.", "Mancano dati obbligatori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                disableControls();
                btnEdit.Text = "Modifica";
                if (IsThereAnyModification())
                {
                    //salva i dati nel db
                    scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter dta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.DestinatarioMovTableAdapter();
                    dta.UpdateById(txtPiva.Text, txtNome.Text, txtDescr.Text, txtSede.Text, 
                        int.Parse(ddt[currentIndex]["ID"].ToString()));
                        
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
            oldPiva = txtPiva.Text;
            oldSede = txtSede.Text;
            oldDescr = txtDescr.Text;
        }

        private bool IsThereAnyModification()
        {
            if (txtNome.Text != oldNome) return true;
            if (txtPiva.Text != oldPiva) return true;
            if (txtSede.Text != oldSede) return true;
            if (txtDescr.Text != oldDescr) return true;
            return false;
        }
    }
}
