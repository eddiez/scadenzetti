namespace Scadenzetti
{
    partial class MainForm
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
            this.grpElapsedMov = new System.Windows.Forms.GroupBox();
            this.datagridElapsedMov = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaRateazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinatariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutScadenzettiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintMov = new System.Windows.Forms.Button();
            this.btnSearchMov = new System.Windows.Forms.Button();
            this.btnNewMov = new System.Windows.Forms.Button();
            this.grpNextMonth = new System.Windows.Forms.GroupBox();
            this.dataGridNextMonthMov = new System.Windows.Forms.DataGridView();
            this.fatturaMultimovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpElapsedMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridElapsedMov)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpNextMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNextMonthMov)).BeginInit();
            this.SuspendLayout();
            // 
            // grpElapsedMov
            // 
            this.grpElapsedMov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpElapsedMov.Controls.Add(this.datagridElapsedMov);
            this.grpElapsedMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElapsedMov.Location = new System.Drawing.Point(69, 315);
            this.grpElapsedMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpElapsedMov.Name = "grpElapsedMov";
            this.grpElapsedMov.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpElapsedMov.Size = new System.Drawing.Size(727, 219);
            this.grpElapsedMov.TabIndex = 1;
            this.grpElapsedMov.TabStop = false;
            this.grpElapsedMov.Text = "Movimenti scaduti";
            // 
            // datagridElapsedMov
            // 
            this.datagridElapsedMov.AllowUserToAddRows = false;
            this.datagridElapsedMov.AllowUserToDeleteRows = false;
            this.datagridElapsedMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridElapsedMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridElapsedMov.Location = new System.Drawing.Point(8, 27);
            this.datagridElapsedMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagridElapsedMov.Name = "datagridElapsedMov";
            this.datagridElapsedMov.ReadOnly = true;
            this.datagridElapsedMov.RowHeadersVisible = false;
            this.datagridElapsedMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridElapsedMov.Size = new System.Drawing.Size(711, 185);
            this.datagridElapsedMov.TabIndex = 0;
            this.datagridElapsedMov.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridElapsedMov_CellDoubleClick);
            this.datagridElapsedMov.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.datagridElapsedMov_RowPrePaint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utentiToolStripMenuItem,
            this.destinatariToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "mainmenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaRateazioneToolStripMenuItem,
            this.fatturaMultimovimentoToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nuovaRateazioneToolStripMenuItem
            // 
            this.nuovaRateazioneToolStripMenuItem.Name = "nuovaRateazioneToolStripMenuItem";
            this.nuovaRateazioneToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.nuovaRateazioneToolStripMenuItem.Text = "Nuova rateazione";
            this.nuovaRateazioneToolStripMenuItem.Click += new System.EventHandler(this.nuovaRateazioneToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // utentiToolStripMenuItem
            // 
            this.utentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.utentiToolStripMenuItem.Name = "utentiToolStripMenuItem";
            this.utentiToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.utentiToolStripMenuItem.Text = "Utenti";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.aggiungiToolStripMenuItem.Text = "Aggiungi";
            this.aggiungiToolStripMenuItem.Click += new System.EventHandler(this.aggiungiToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // destinatariToolStripMenuItem
            // 
            this.destinatariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem1,
            this.listaToolStripMenuItem1});
            this.destinatariToolStripMenuItem.Name = "destinatariToolStripMenuItem";
            this.destinatariToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.destinatariToolStripMenuItem.Text = "Destinatari";
            // 
            // aggiungiToolStripMenuItem1
            // 
            this.aggiungiToolStripMenuItem1.Name = "aggiungiToolStripMenuItem1";
            this.aggiungiToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.aggiungiToolStripMenuItem1.Text = "Aggiungi";
            this.aggiungiToolStripMenuItem1.Click += new System.EventHandler(this.aggiungiToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.listaToolStripMenuItem1.Text = "Lista";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem2,
            this.listaToolStripMenuItem2});
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.categorieToolStripMenuItem.Text = "Categorie";
            // 
            // aggiungiToolStripMenuItem2
            // 
            this.aggiungiToolStripMenuItem2.Name = "aggiungiToolStripMenuItem2";
            this.aggiungiToolStripMenuItem2.Size = new System.Drawing.Size(139, 24);
            this.aggiungiToolStripMenuItem2.Text = "Aggiungi";
            this.aggiungiToolStripMenuItem2.Click += new System.EventHandler(this.aggiungiToolStripMenuItem2_Click);
            // 
            // listaToolStripMenuItem2
            // 
            this.listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            this.listaToolStripMenuItem2.Size = new System.Drawing.Size(139, 24);
            this.listaToolStripMenuItem2.Text = "Lista";
            this.listaToolStripMenuItem2.Click += new System.EventHandler(this.listaToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutScadenzettiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutScadenzettiToolStripMenuItem
            // 
            this.aboutScadenzettiToolStripMenuItem.Name = "aboutScadenzettiToolStripMenuItem";
            this.aboutScadenzettiToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.aboutScadenzettiToolStripMenuItem.Text = "About Scadenzetti";
            this.aboutScadenzettiToolStripMenuItem.Click += new System.EventHandler(this.aboutScadenzettiToolStripMenuItem_Click);
            // 
            // btnPrintMov
            // 
            this.btnPrintMov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrintMov.BackgroundImage = global::Scadenzetti.Properties.Resources.printer;
            this.btnPrintMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrintMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMov.Location = new System.Drawing.Point(561, 75);
            this.btnPrintMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintMov.Name = "btnPrintMov";
            this.btnPrintMov.Size = new System.Drawing.Size(235, 217);
            this.btnPrintMov.TabIndex = 2;
            this.btnPrintMov.Text = "Stampa movimenti";
            this.btnPrintMov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintMov.UseVisualStyleBackColor = true;
            this.btnPrintMov.Click += new System.EventHandler(this.btnPrintMov_Click);
            // 
            // btnSearchMov
            // 
            this.btnSearchMov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchMov.BackgroundImage = global::Scadenzetti.Properties.Resources.Sherlock;
            this.btnSearchMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMov.Location = new System.Drawing.Point(319, 75);
            this.btnSearchMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchMov.Name = "btnSearchMov";
            this.btnSearchMov.Size = new System.Drawing.Size(235, 217);
            this.btnSearchMov.TabIndex = 1;
            this.btnSearchMov.Text = "Ricerca Movimenti";
            this.btnSearchMov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchMov.UseVisualStyleBackColor = true;
            this.btnSearchMov.Click += new System.EventHandler(this.btnSearchMov_Click);
            // 
            // btnNewMov
            // 
            this.btnNewMov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewMov.BackgroundImage = global::Scadenzetti.Properties.Resources._1248512766_Money_Pig;
            this.btnNewMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMov.Location = new System.Drawing.Point(69, 75);
            this.btnNewMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewMov.Name = "btnNewMov";
            this.btnNewMov.Size = new System.Drawing.Size(235, 217);
            this.btnNewMov.TabIndex = 0;
            this.btnNewMov.Text = "Nuovo Movimento";
            this.btnNewMov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewMov.UseVisualStyleBackColor = true;
            this.btnNewMov.Click += new System.EventHandler(this.btnNewMov_Click);
            // 
            // grpNextMonth
            // 
            this.grpNextMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpNextMonth.Controls.Add(this.dataGridNextMonthMov);
            this.grpNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNextMonth.Location = new System.Drawing.Point(69, 551);
            this.grpNextMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNextMonth.Name = "grpNextMonth";
            this.grpNextMonth.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNextMonth.Size = new System.Drawing.Size(727, 219);
            this.grpNextMonth.TabIndex = 1;
            this.grpNextMonth.TabStop = false;
            this.grpNextMonth.Text = "Movimenti prossimo mese";
            // 
            // dataGridNextMonthMov
            // 
            this.dataGridNextMonthMov.AllowUserToAddRows = false;
            this.dataGridNextMonthMov.AllowUserToDeleteRows = false;
            this.dataGridNextMonthMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridNextMonthMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNextMonthMov.Location = new System.Drawing.Point(8, 27);
            this.dataGridNextMonthMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridNextMonthMov.Name = "dataGridNextMonthMov";
            this.dataGridNextMonthMov.ReadOnly = true;
            this.dataGridNextMonthMov.RowHeadersVisible = false;
            this.dataGridNextMonthMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNextMonthMov.Size = new System.Drawing.Size(711, 185);
            this.dataGridNextMonthMov.TabIndex = 0;
            this.dataGridNextMonthMov.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNextMonthMov_CellDoubleClick);
            this.dataGridNextMonthMov.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridNextMonthMov_RowPrePaint);
            // 
            // fatturaMultimovimentoToolStripMenuItem
            // 
            this.fatturaMultimovimentoToolStripMenuItem.Name = "fatturaMultimovimentoToolStripMenuItem";
            this.fatturaMultimovimentoToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.fatturaMultimovimentoToolStripMenuItem.Text = "Fattura multi-movimento";
            this.fatturaMultimovimentoToolStripMenuItem.Click += new System.EventHandler(this.fatturaMultimovimentoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 785);
            this.Controls.Add(this.grpNextMonth);
            this.Controls.Add(this.grpElapsedMov);
            this.Controls.Add(this.btnPrintMov);
            this.Controls.Add(this.btnSearchMov);
            this.Controls.Add(this.btnNewMov);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scadenzetti";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpElapsedMov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridElapsedMov)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpNextMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNextMonthMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewMov;
        private System.Windows.Forms.Button btnSearchMov;
        private System.Windows.Forms.Button btnPrintMov;
        private System.Windows.Forms.GroupBox grpElapsedMov;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinatariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutScadenzettiToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpNextMonth;
        private System.Windows.Forms.DataGridView datagridElapsedMov;
        private System.Windows.Forms.DataGridView dataGridNextMonthMov;
        private System.Windows.Forms.ToolStripMenuItem nuovaRateazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatturaMultimovimentoToolStripMenuItem;
    }
}

