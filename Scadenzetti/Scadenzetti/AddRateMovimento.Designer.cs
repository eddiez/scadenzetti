namespace Scadenzetti
{
    partial class AddRateMovimento
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpRate = new System.Windows.Forms.GroupBox();
            this.rateDataGrid = new System.Windows.Forms.DataGridView();
            this.grpRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(319, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(187, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 30);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Inserisci";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpRate
            // 
            this.grpRate.Controls.Add(this.rateDataGrid);
            this.grpRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRate.Location = new System.Drawing.Point(23, 29);
            this.grpRate.Name = "grpRate";
            this.grpRate.Size = new System.Drawing.Size(414, 343);
            this.grpRate.TabIndex = 11;
            this.grpRate.TabStop = false;
            this.grpRate.Text = "Rate movimento";
            // 
            // rateDataGrid
            // 
            this.rateDataGrid.AllowUserToAddRows = false;
            this.rateDataGrid.AllowUserToDeleteRows = false;
            this.rateDataGrid.AllowUserToResizeRows = false;
            this.rateDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.rateDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rateDataGrid.Location = new System.Drawing.Point(6, 23);
            this.rateDataGrid.Name = "rateDataGrid";
            this.rateDataGrid.RowHeadersVisible = false;
            this.rateDataGrid.Size = new System.Drawing.Size(402, 314);
            this.rateDataGrid.TabIndex = 0;
            this.rateDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.rateDataGrid_CellValidating);
            // 
            // AddRateMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(461, 443);
            this.Controls.Add(this.grpRate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddRateMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi rate movimento";
            this.grpRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rateDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpRate;
        private System.Windows.Forms.DataGridView rateDataGrid;
    }
}