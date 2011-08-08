using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class EditUserForm : BaseForm
    {
        private scadenzettiDbDataSet.UtenteDataTable udt;
        private int currentIndex;
        private string oldNome;
        private string oldCf;
        private string oldPiva;
        private string oldSede;
        private string oldDescr;
        private bool btnNextStatus;
        private bool btnPreviousStatus;

        public EditUserForm()
        {
            InitializeComponent();
            
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            //mostra il primo utente
            currentIndex = 0;
            loadUsers(currentIndex);
            btnPreviousStatus = false;
            if(udt.Count==1) btnNextStatus = false;
            else btnNextStatus = true;
            disableControls();
        }

        private void loadUsers(int index)
        {
            scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            udt = uta.GetDataOrderByNome();

            if (udt.Count == 0)
            {
                MessageBox.Show("Non ci sono utenti in archivio", "Nessun utente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            showUtente(index);
        }

        private void showUtente(int index)
        {
            txtNome.Text = udt[index]["Nome"].ToString();
            txtCf.Text = udt[index]["CF"].ToString();
            txtPiva.Text = udt[index]["PIVA"].ToString();
            txtSede.Text = udt[index]["Sede"].ToString();
            txtDescr.Text = udt[index]["Descrizione"].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            btnPrevious.Enabled = true;
            if (currentIndex + 1 >= udt.Count)
            {
                currentIndex = udt.Count - 1;
                btnNext.Enabled = false;
            }
            showUtente(currentIndex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;
            btnNext.Enabled = true;
            if (currentIndex <= 0) {
                currentIndex = 0;
                btnPrevious.Enabled = false;
            }

            showUtente(currentIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Sei sicuro di voler eliminare questo utente?", "Conferma eliminazione utente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int idUtente = int.Parse(udt[currentIndex]["ID"].ToString());
                if (HasAnyMovement(idUtente))
                {
                    MessageBox.Show("Impossibile eliminare l'utente perchè esistono movimenti associati ad esso.",
                        "Comando negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    deleteUser(idUtente);
                    currentIndex = (currentIndex - 1 >= 0) ? currentIndex - 1 : currentIndex;
                    loadUsers(currentIndex);
                }
            }
        }

        private void deleteUser(int idUtente)
        {
            scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
            uta.DeleteById(idUtente);
        }

        private bool HasAnyMovement(int idUtente)
        {
            scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter mta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter();
            if (mta.UtenteInUse(idUtente) > 0) return true;
            else return false;

        }

        private void disableControls()
        {
            txtNome.ReadOnly = true;
            txtCf.ReadOnly = true;
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
            txtCf.ReadOnly = false;
            txtPiva.ReadOnly = false;
            txtSede.ReadOnly = false;
            txtDescr.ReadOnly = false;

            btnDelete.Enabled = false;
            btnNextStatus = btnNext.Enabled;
            btnNext.Enabled = false;
            btnPreviousStatus = btnPrevious.Enabled;
            btnPrevious.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!txtNome.ReadOnly) //salva eventuali modifiche e disabilita controlli
            {
                //validazione campi
                if (txtNome.Text == "")
                {
                    MessageBox.Show(this, "Nome dell'utente è un campo obbligatorio.", "Mancano dati obbligatori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                disableControls();
                btnEdit.Text = "Modifica";
                if (IsThereAnyModification())
                {
                    //salva i dati nel db
                    scadenzettiDbDataSetTableAdapters.UtenteTableAdapter uta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.UtenteTableAdapter();
                    uta.UpdateById(udt[currentIndex]["Tipo"].ToString(), txtCf.Text, txtPiva.Text, txtNome.Text,
                        txtSede.Text, txtDescr.Text, int.Parse(udt[currentIndex]["ID"].ToString()));
                }

            }
            else
            {   //salva valori originali e abilita controlli
                enableControls();
                saveOldValues();
                btnEdit.Text = "Salva";
            }
        }

        private bool IsThereAnyModification()
        {
            if (txtNome.Text != oldNome) return true;
            if (txtCf.Text != oldCf) return true;
            if (txtPiva.Text != oldPiva) return true;
            if (txtSede.Text != oldSede) return true;
            if (txtDescr.Text != oldDescr) return true;
            return false;
        }

        private void saveOldValues()
        {
            oldNome = txtNome.Text;
            oldCf = txtCf.Text;
            oldPiva = txtPiva.Text;
            oldSede = txtSede.Text;
            oldDescr = txtDescr.Text;
        }



    }
}

