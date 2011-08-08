using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddDestinatarioForm : BaseForm
    {
        public string nome;
        public string piva;
        public string sede;
        public string descr;

        public AddDestinatarioForm()
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
                MessageBox.Show("Inserire almeno il nome del destinatario di movimenti!");
                return;
            }
            //impostazione campi locali
            nome = txtNome.Text;
            piva = txtPiva.Text;
            sede = txtSede.Text;
            descr = txtDescr.Text;


            this.DialogResult = DialogResult.OK;
        }
    }
}
