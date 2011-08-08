using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddUserForm : BaseForm
    {
        public string tipo;
        public string nome;
        public string cf;
        public string piva;
        public string sede;
        public string descr;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validazione input
            if (txtNome.Text == "")
            {
                MessageBox.Show("Inserire almeno il nome dell'utente!");
                return;
            }
            //impostazione campi locali
            tipo = cbxTipo.Text;
            nome = txtNome.Text;
            cf = txtCf.Text;
            piva = txtPiva.Text;
            sede = txtSede.Text;
            descr = txtDescr.Text;

            
            this.DialogResult = DialogResult.OK;
        }
    }
}
