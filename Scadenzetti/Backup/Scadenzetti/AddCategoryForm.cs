using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class AddCategoryForm : BaseForm
    {
        public string nome;
        public string descr;

        public AddCategoryForm()
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
                MessageBox.Show("Inserire almeno il nome della categoria di movimenti!");
                return;
            }
            //impostazione campi locali
            nome = txtNome.Text;
            descr = txtDescr.Text;

            this.DialogResult = DialogResult.OK;
        }


    }
}
