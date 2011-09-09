using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    public partial class MovimentoFatturaControl : UserControl
    {
        List<Categoria> categorieMov;
        private DataTable vociCategoriaDt;
        
        public event EventHandler TotalChanged;

        public MovimentoFatturaControl(List<Categoria> cats)
        {
            InitializeComponent();
            
            categorieMov = cats;
            //inserisco le categoria

            if (categorieMov.Count > 0)
            {
                foreach (Categoria cat in categorieMov)
                {
                    CategoryRadioButton cbx = new CategoryRadioButton();
                    cbx.Text = cat.Nome;
                    cbx.IdCategoria = cat.Id;
                    cbx.Size = new Size(250, 24);
                    flowLayoutPanelCats.Controls.Add(cbx);
                }
            }
            initializeDataGrids();
        }

        private void initializeDataGrids()
        {
            vociCategoriaDt = new DataTable();
            vociCategoriaDt.Columns.Add("Imponibile", typeof(decimal));
            vociCategoriaDt.Columns.Add("IVA", typeof(decimal));
            vociCategoriaDt.Columns.Add("Totale", typeof(decimal));

            dataGridVociCat.DataSource = vociCategoriaDt;

            dataGridVociCat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridVociCat.DefaultCellStyle.Font = new Font("Verdana", 9);
            dataGridVociCat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridVociCat.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9);
        }

        public decimal getTotaleCategoria()
        {
            return decimal.Parse(lblTotaleCatValue.Text);
        }

        private void btnAddVoceCat_Click(object sender, EventArgs e)
        {
            vociCategoriaDt.Rows.Add(0, 10, 0);
        }

        private void dataGridVociCat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                //imponibile o iva cambiata
                dataGridVociCat[2, e.RowIndex].Value = (decimal)dataGridVociCat[0, e.RowIndex].Value + (((decimal)dataGridVociCat[0, e.RowIndex].Value * (decimal)dataGridVociCat[1, e.RowIndex].Value)/100);
            }

            if (e.ColumnIndex == 2)
            {
                //aggiorno il totale della categoria
                ricalcolaTotaleCategoria();
            }
        }

        private void ricalcolaTotaleCategoria()
        {
            decimal tot = 0;
            for (int i = 0; i < vociCategoriaDt.Rows.Count; i++)
            {

                tot += (decimal)vociCategoriaDt.Rows[i]["Totale"];
            }
            lblTotaleCatValue.Text = tot.ToString();

            TotalChanged(this, null);
        }

        private void btnDeleteVoceCat_Click(object sender, EventArgs e)
        {
            dataGridVociCat.Rows.RemoveAt(dataGridVociCat.SelectedCells[0].RowIndex);
            ricalcolaTotaleCategoria();
        }

        public string getCausaleSuffix()
        {
            return txtboxSuffixCaus.Text;
        }

        public int getIdCategoria()
        {
            foreach (CategoryRadioButton crb in flowLayoutPanelCats.Controls)
                if (crb.Checked)
                {
                    return crb.IdCategoria;
                }
            return 0;
        }

        
    }
}
