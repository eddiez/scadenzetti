namespace Scadenzetti
{
    partial class AddRateazioneForm
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
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnInsertRate = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtCausale = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblCausale = new System.Windows.Forms.Label();
            this.rateUpDown = new System.Windows.Forms.NumericUpDown();
            this.cbxTipo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblUtente = new System.Windows.Forms.Label();
            this.dropDest = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dropUtente = new System.Windows.Forms.ComboBox();
            this.lblDettRate = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(373, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCategorie
            // 
            this.btnCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.Location = new System.Drawing.Point(241, 408);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(108, 30);
            this.btnCategorie.TabIndex = 7;
            this.btnCategorie.Text = "seleziona";
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // btnInsertRate
            // 
            this.btnInsertRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertRate.Location = new System.Drawing.Point(241, 54);
            this.btnInsertRate.Name = "btnInsertRate";
            this.btnInsertRate.Size = new System.Drawing.Size(108, 30);
            this.btnInsertRate.TabIndex = 1;
            this.btnInsertRate.Text = "Inserisci";
            this.btnInsertRate.UseVisualStyleBackColor = true;
            this.btnInsertRate.Click += new System.EventHandler(this.btnInsertRate_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(241, 329);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(250, 67);
            this.txtNote.TabIndex = 6;
            // 
            // txtCausale
            // 
            this.txtCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausale.Location = new System.Drawing.Point(241, 256);
            this.txtCausale.Multiline = true;
            this.txtCausale.Name = "txtCausale";
            this.txtCausale.Size = new System.Drawing.Size(250, 67);
            this.txtCausale.TabIndex = 5;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(44, 414);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(145, 18);
            this.lblCategorie.TabIndex = 26;
            this.lblCategorie.Text = "Categorie rateazione";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(44, 329);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(40, 18);
            this.lblNote.TabIndex = 27;
            this.lblNote.Text = "Note";
            // 
            // lblCausale
            // 
            this.lblCausale.AutoSize = true;
            this.lblCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausale.Location = new System.Drawing.Point(44, 259);
            this.lblCausale.Name = "lblCausale";
            this.lblCausale.Size = new System.Drawing.Size(62, 18);
            this.lblCausale.TabIndex = 28;
            this.lblCausale.Text = "Causale";
            // 
            // rateUpDown
            // 
            this.rateUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateUpDown.Location = new System.Drawing.Point(243, 14);
            this.rateUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.rateUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rateUpDown.Name = "rateUpDown";
            this.rateUpDown.Size = new System.Drawing.Size(78, 24);
            this.rateUpDown.TabIndex = 0;
            this.rateUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbxTipo
            // 
            this.cbxTipo.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxTipo.BackColor = System.Drawing.Color.Red;
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxTipo.Location = new System.Drawing.Point(243, 189);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(248, 39);
            this.cbxTipo.TabIndex = 4;
            this.cbxTipo.Text = "uscita";
            this.cbxTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxTipo.UseVisualStyleBackColor = false;
            this.cbxTipo.CheckedChanged += new System.EventHandler(this.cbxTipo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.Location = new System.Drawing.Point(46, 149);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(87, 18);
            this.lblDest.TabIndex = 17;
            this.lblDest.Text = "Destinatario";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(46, 20);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(54, 18);
            this.lblRate.TabIndex = 19;
            this.lblRate.Text = "N° rate";
            // 
            // lblUtente
            // 
            this.lblUtente.AutoSize = true;
            this.lblUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtente.Location = new System.Drawing.Point(46, 104);
            this.lblUtente.Name = "lblUtente";
            this.lblUtente.Size = new System.Drawing.Size(51, 18);
            this.lblUtente.TabIndex = 19;
            this.lblUtente.Text = "Utente";
            // 
            // dropDest
            // 
            this.dropDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDest.FormattingEnabled = true;
            this.dropDest.Location = new System.Drawing.Point(243, 146);
            this.dropDest.Name = "dropDest";
            this.dropDest.Size = new System.Drawing.Size(248, 26);
            this.dropDest.Sorted = true;
            this.dropDest.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(46, 199);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(110, 18);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo rateazione";
            // 
            // dropUtente
            // 
            this.dropUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropUtente.FormattingEnabled = true;
            this.dropUtente.Location = new System.Drawing.Point(243, 101);
            this.dropUtente.Name = "dropUtente";
            this.dropUtente.Size = new System.Drawing.Size(248, 26);
            this.dropUtente.Sorted = true;
            this.dropUtente.TabIndex = 2;
            // 
            // lblDettRate
            // 
            this.lblDettRate.AutoSize = true;
            this.lblDettRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDettRate.Location = new System.Drawing.Point(46, 60);
            this.lblDettRate.Name = "lblDettRate";
            this.lblDettRate.Size = new System.Drawing.Size(86, 18);
            this.lblDettRate.TabIndex = 26;
            this.lblDettRate.Text = "Dettagli rate";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(241, 479);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 30);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // AddRateazioneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(527, 521);
            this.Controls.Add(this.btnCategorie);
            this.Controls.Add(this.btnInsertRate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtCausale);
            this.Controls.Add(this.lblDettRate);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblCausale);
            this.Controls.Add(this.rateUpDown);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblUtente);
            this.Controls.Add(this.dropDest);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.dropUtente);
            this.Name = "AddRateazioneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi rateazione movimenti";
            this.Load += new System.EventHandler(this.AddRateazioneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rateUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblUtente;
        private System.Windows.Forms.ComboBox dropDest;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox dropUtente;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown rateUpDown;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnInsertRate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtCausale;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblCausale;
        private System.Windows.Forms.Label lblDettRate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
    }
}