namespace Scadenzetti
{
    partial class SearchMovimentiForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lblCriteri = new System.Windows.Forms.Label();
            this.grpScad = new System.Windows.Forms.GroupBox();
            this.lblDataA = new System.Windows.Forms.Label();
            this.lblDataDa = new System.Windows.Forms.Label();
            this.dtpickDataDa = new System.Windows.Forms.DateTimePicker();
            this.dtpickDataA = new System.Windows.Forms.DateTimePicker();
            this.lblDest = new System.Windows.Forms.Label();
            this.dropUtente = new System.Windows.Forms.ComboBox();
            this.lblUtente = new System.Windows.Forms.Label();
            this.dropDest = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblRisultati = new System.Windows.Forms.Label();
            this.dataGridMov = new System.Windows.Forms.DataGridView();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpScad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMov)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(457, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Cerca";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lblCriteri);
            this.splitContainer.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer.Panel1.Controls.Add(this.grpScad);
            this.splitContainer.Panel1.Controls.Add(this.lblDest);
            this.splitContainer.Panel1.Controls.Add(this.dropUtente);
            this.splitContainer.Panel1.Controls.Add(this.lblUtente);
            this.splitContainer.Panel1.Controls.Add(this.dropDest);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer.Panel2.Controls.Add(this.lblRisultati);
            this.splitContainer.Panel2.Controls.Add(this.dataGridMov);
            this.splitContainer.Size = new System.Drawing.Size(686, 644);
            this.splitContainer.SplitterDistance = 321;
            this.splitContainer.TabIndex = 10;
            // 
            // lblCriteri
            // 
            this.lblCriteri.AutoSize = true;
            this.lblCriteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteri.Location = new System.Drawing.Point(19, 18);
            this.lblCriteri.Name = "lblCriteri";
            this.lblCriteri.Size = new System.Drawing.Size(129, 18);
            this.lblCriteri.TabIndex = 1;
            this.lblCriteri.Text = "Criteri di ricerca";
            // 
            // grpScad
            // 
            this.grpScad.Controls.Add(this.lblDataA);
            this.grpScad.Controls.Add(this.lblDataDa);
            this.grpScad.Controls.Add(this.dtpickDataDa);
            this.grpScad.Controls.Add(this.dtpickDataA);
            this.grpScad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScad.Location = new System.Drawing.Point(75, 141);
            this.grpScad.Name = "grpScad";
            this.grpScad.Size = new System.Drawing.Size(509, 88);
            this.grpScad.TabIndex = 8;
            this.grpScad.TabStop = false;
            this.grpScad.Text = "Data scadenza";
            // 
            // lblDataA
            // 
            this.lblDataA.AutoSize = true;
            this.lblDataA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataA.Location = new System.Drawing.Point(273, 46);
            this.lblDataA.Name = "lblDataA";
            this.lblDataA.Size = new System.Drawing.Size(16, 18);
            this.lblDataA.TabIndex = 9;
            this.lblDataA.Text = "a";
            // 
            // lblDataDa
            // 
            this.lblDataDa.AutoSize = true;
            this.lblDataDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDa.Location = new System.Drawing.Point(22, 46);
            this.lblDataDa.Name = "lblDataDa";
            this.lblDataDa.Size = new System.Drawing.Size(24, 18);
            this.lblDataDa.TabIndex = 9;
            this.lblDataDa.Text = "da";
            // 
            // dtpickDataDa
            // 
            this.dtpickDataDa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickDataDa.Location = new System.Drawing.Point(52, 41);
            this.dtpickDataDa.Name = "dtpickDataDa";
            this.dtpickDataDa.Size = new System.Drawing.Size(200, 24);
            this.dtpickDataDa.TabIndex = 0;
            // 
            // dtpickDataA
            // 
            this.dtpickDataA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickDataA.Location = new System.Drawing.Point(303, 41);
            this.dtpickDataA.Name = "dtpickDataA";
            this.dtpickDataA.Size = new System.Drawing.Size(200, 24);
            this.dtpickDataA.TabIndex = 1;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.Location = new System.Drawing.Point(81, 100);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(87, 18);
            this.lblDest.TabIndex = 6;
            this.lblDest.Text = "Destinatario";
            // 
            // dropUtente
            // 
            this.dropUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropUtente.FormattingEnabled = true;
            this.dropUtente.Location = new System.Drawing.Point(336, 52);
            this.dropUtente.Name = "dropUtente";
            this.dropUtente.Size = new System.Drawing.Size(248, 26);
            this.dropUtente.Sorted = true;
            this.dropUtente.TabIndex = 0;
            // 
            // lblUtente
            // 
            this.lblUtente.AutoSize = true;
            this.lblUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtente.Location = new System.Drawing.Point(81, 55);
            this.lblUtente.Name = "lblUtente";
            this.lblUtente.Size = new System.Drawing.Size(51, 18);
            this.lblUtente.TabIndex = 7;
            this.lblUtente.Text = "Utente";
            // 
            // dropDest
            // 
            this.dropDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDest.FormattingEnabled = true;
            this.dropDest.Location = new System.Drawing.Point(336, 97);
            this.dropDest.Name = "dropDest";
            this.dropDest.Size = new System.Drawing.Size(248, 26);
            this.dropDest.Sorted = true;
            this.dropDest.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(541, 275);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 31);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Stampa";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblRisultati
            // 
            this.lblRisultati.AutoSize = true;
            this.lblRisultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultati.Location = new System.Drawing.Point(13, 20);
            this.lblRisultati.Name = "lblRisultati";
            this.lblRisultati.Size = new System.Drawing.Size(144, 18);
            this.lblRisultati.TabIndex = 1;
            this.lblRisultati.Text = "Risultati di ricerca";
            // 
            // dataGridMov
            // 
            this.dataGridMov.AllowUserToAddRows = false;
            this.dataGridMov.AllowUserToDeleteRows = false;
            this.dataGridMov.AllowUserToResizeRows = false;
            this.dataGridMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMov.Location = new System.Drawing.Point(16, 52);
            this.dataGridMov.MultiSelect = false;
            this.dataGridMov.Name = "dataGridMov";
            this.dataGridMov.ReadOnly = true;
            this.dataGridMov.RowHeadersVisible = false;
            this.dataGridMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMov.Size = new System.Drawing.Size(652, 210);
            this.dataGridMov.TabIndex = 0;
            this.dataGridMov.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMov_CellDoubleClick);
            this.dataGridMov.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridMov_RowPrePaint);
            // 
            // SearchMovimentiForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 644);
            this.Controls.Add(this.splitContainer);
            this.Name = "SearchMovimentiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ricerca movimenti";
            this.Load += new System.EventHandler(this.SearchMovimentiForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.grpScad.ResumeLayout(false);
            this.grpScad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblUtente;
        private System.Windows.Forms.ComboBox dropDest;
        private System.Windows.Forms.ComboBox dropUtente;
        private System.Windows.Forms.GroupBox grpScad;
        private System.Windows.Forms.Label lblDataA;
        private System.Windows.Forms.Label lblDataDa;
        private System.Windows.Forms.DateTimePicker dtpickDataDa;
        private System.Windows.Forms.DateTimePicker dtpickDataA;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridMov;
        private System.Windows.Forms.Label lblCriteri;
        private System.Windows.Forms.Label lblRisultati;
        private System.Windows.Forms.Button btnPrint;
    }
}