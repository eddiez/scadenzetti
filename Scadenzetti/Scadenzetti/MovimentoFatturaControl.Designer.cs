namespace Scadenzetti
{
    partial class MovimentoFatturaControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddVoceCat = new System.Windows.Forms.Button();
            this.btnDeleteVoceCat = new System.Windows.Forms.Button();
            this.dataGridVociCat = new System.Windows.Forms.DataGridView();
            this.txtboxSuffixCaus = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelCats = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotaleCatValue = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblSuffixCaus = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVociCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnAddVoceCat);
            this.panel1.Controls.Add(this.btnDeleteVoceCat);
            this.panel1.Controls.Add(this.dataGridVociCat);
            this.panel1.Controls.Add(this.txtboxSuffixCaus);
            this.panel1.Controls.Add(this.flowLayoutPanelCats);
            this.panel1.Controls.Add(this.lblTotaleCatValue);
            this.panel1.Controls.Add(this.lblTot);
            this.panel1.Controls.Add(this.lblSuffixCaus);
            this.panel1.Controls.Add(this.lblCat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 339);
            this.panel1.TabIndex = 0;
            // 
            // btnAddVoceCat
            // 
            this.btnAddVoceCat.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddVoceCat.ForeColor = System.Drawing.Color.Black;
            this.btnAddVoceCat.Location = new System.Drawing.Point(465, 154);
            this.btnAddVoceCat.Name = "btnAddVoceCat";
            this.btnAddVoceCat.Size = new System.Drawing.Size(31, 23);
            this.btnAddVoceCat.TabIndex = 4;
            this.btnAddVoceCat.Text = "+";
            this.btnAddVoceCat.UseVisualStyleBackColor = false;
            this.btnAddVoceCat.Click += new System.EventHandler(this.btnAddVoceCat_Click);
            // 
            // btnDeleteVoceCat
            // 
            this.btnDeleteVoceCat.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteVoceCat.Location = new System.Drawing.Point(502, 154);
            this.btnDeleteVoceCat.Name = "btnDeleteVoceCat";
            this.btnDeleteVoceCat.Size = new System.Drawing.Size(31, 23);
            this.btnDeleteVoceCat.TabIndex = 4;
            this.btnDeleteVoceCat.Text = "-";
            this.btnDeleteVoceCat.UseVisualStyleBackColor = false;
            this.btnDeleteVoceCat.Click += new System.EventHandler(this.btnDeleteVoceCat_Click);
            // 
            // dataGridVociCat
            // 
            this.dataGridVociCat.AllowUserToAddRows = false;
            this.dataGridVociCat.AllowUserToDeleteRows = false;
            this.dataGridVociCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridVociCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVociCat.Location = new System.Drawing.Point(15, 183);
            this.dataGridVociCat.Name = "dataGridVociCat";
            this.dataGridVociCat.RowHeadersVisible = false;
            this.dataGridVociCat.RowTemplate.Height = 24;
            this.dataGridVociCat.Size = new System.Drawing.Size(518, 105);
            this.dataGridVociCat.TabIndex = 3;
            this.dataGridVociCat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVociCat_CellValueChanged);
            // 
            // txtboxSuffixCaus
            // 
            this.txtboxSuffixCaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSuffixCaus.Location = new System.Drawing.Point(185, 115);
            this.txtboxSuffixCaus.Multiline = true;
            this.txtboxSuffixCaus.Name = "txtboxSuffixCaus";
            this.txtboxSuffixCaus.Size = new System.Drawing.Size(348, 32);
            this.txtboxSuffixCaus.TabIndex = 2;
            // 
            // flowLayoutPanelCats
            // 
            this.flowLayoutPanelCats.AutoScroll = true;
            this.flowLayoutPanelCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCats.Location = new System.Drawing.Point(185, 14);
            this.flowLayoutPanelCats.Name = "flowLayoutPanelCats";
            this.flowLayoutPanelCats.Size = new System.Drawing.Size(348, 90);
            this.flowLayoutPanelCats.TabIndex = 1;
            // 
            // lblTotaleCatValue
            // 
            this.lblTotaleCatValue.AutoSize = true;
            this.lblTotaleCatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaleCatValue.Location = new System.Drawing.Point(181, 307);
            this.lblTotaleCatValue.Name = "lblTotaleCatValue";
            this.lblTotaleCatValue.Size = new System.Drawing.Size(19, 20);
            this.lblTotaleCatValue.TabIndex = 0;
            this.lblTotaleCatValue.Text = "0";
            this.lblTotaleCatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(11, 307);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(165, 20);
            this.lblTot.TabIndex = 0;
            this.lblTot.Text = "Totale Categoria =";
            // 
            // lblSuffixCaus
            // 
            this.lblSuffixCaus.AutoSize = true;
            this.lblSuffixCaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffixCaus.Location = new System.Drawing.Point(11, 118);
            this.lblSuffixCaus.Name = "lblSuffixCaus";
            this.lblSuffixCaus.Size = new System.Drawing.Size(136, 20);
            this.lblSuffixCaus.TabIndex = 0;
            this.lblSuffixCaus.Text = "Suffisso Causale";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(11, 14);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(81, 20);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Categoria";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(552, 345);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Blue;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 588;
            this.lineShape1.Y1 = 340;
            this.lineShape1.Y2 = 340;
            // 
            // MovimentoFatturaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MovimentoFatturaControl";
            this.Size = new System.Drawing.Size(552, 345);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVociCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtboxSuffixCaus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCats;
        private System.Windows.Forms.Label lblSuffixCaus;
        private System.Windows.Forms.DataGridView dataGridVociCat;
        private System.Windows.Forms.Label lblTotaleCatValue;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Button btnAddVoceCat;
        private System.Windows.Forms.Button btnDeleteVoceCat;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}
