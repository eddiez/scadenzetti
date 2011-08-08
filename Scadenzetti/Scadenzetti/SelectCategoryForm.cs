using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class SelectCategoryForm : BaseForm
    {
        private scadenzettiDbDataSet.CategoriaDataTable cdt;
        public List<int> selectedCategory;

        public SelectCategoryForm(List<int> selected)
        {
            InitializeComponent();

            selectedCategory = new List<int>();
            if (selected != null)
                selectedCategory.AddRange(selected);
        }

        private void SelectCategoryForm_Load(object sender, EventArgs e)
        {
            scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter cta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaTableAdapter();
            cdt = cta.GetDataOrderByNome();
            if (cdt.Count == 0)
            {
                MessageBox.Show("Non è stata ancora definita alcuna categoria.", "Nessuna categoria presente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            else
            {
                for (int i = 0; i < cdt.Count; i++)
                {
                    CategoryCheckbox cbx = new CategoryCheckbox();
                    cbx.Text = cdt[i]["Nome"].ToString();
                    cbx.IdCategoria = int.Parse(cdt[i]["ID"].ToString());
                    if (selectedCategory.Contains(cbx.IdCategoria))
                        cbx.Checked = true;
                    else 
                        cbx.Checked = false;
                    cbx.Size = new Size(250, 20);
                    flowLayoutPanel.Controls.Add(cbx);
                }
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            selectedCategory.Clear();
            foreach(CategoryCheckbox c in flowLayoutPanel.Controls){
                if (c.Checked)
                {
                    selectedCategory.Add(c.IdCategoria);
                }
                else
                {
                    if (selectedCategory.Contains(c.IdCategoria))
                        selectedCategory.Remove(c.IdCategoria);
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
