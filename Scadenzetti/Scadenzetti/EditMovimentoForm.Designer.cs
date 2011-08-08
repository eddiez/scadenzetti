namespace Scadenzetti
{
    partial class EditMovimentoForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtCausale = new System.Windows.Forms.TextBox();
            this.txtImportoNetto = new System.Windows.Forms.TextBox();
            this.txtImportoIvato = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbxImpAppross = new System.Windows.Forms.CheckBox();
            this.lblCausale = new System.Windows.Forms.Label();
            this.cbxScadAppross = new System.Windows.Forms.CheckBox();
            this.lblImportoNetto = new System.Windows.Forms.Label();
            this.dtpickScadenza = new System.Windows.Forms.DateTimePicker();
            this.lblImportoIvato = new System.Windows.Forms.Label();
            this.lblImpAppross = new System.Windows.Forms.Label();
            this.lblScadAppross = new System.Windows.Forms.Label();
            this.lblScadenza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUltim = new System.Windows.Forms.CheckBox();
            this.lblDataUlt = new System.Windows.Forms.Label();
            this.dtpickUltim = new System.Windows.Forms.DateTimePicker();
            this.lblUtenteValue = new System.Windows.Forms.Label();
            this.lblDestValue = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(433, 641);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(530, 641);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(91, 33);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(12, 641);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(342, 356);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(250, 67);
            this.txtNote.TabIndex = 9;
            // 
            // txtCausale
            // 
            this.txtCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausale.Location = new System.Drawing.Point(342, 283);
            this.txtCausale.Multiline = true;
            this.txtCausale.Name = "txtCausale";
            this.txtCausale.Size = new System.Drawing.Size(250, 67);
            this.txtCausale.TabIndex = 8;
            // 
            // txtImportoNetto
            // 
            this.txtImportoNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportoNetto.Location = new System.Drawing.Point(342, 243);
            this.txtImportoNetto.Name = "txtImportoNetto";
            this.txtImportoNetto.Size = new System.Drawing.Size(248, 24);
            this.txtImportoNetto.TabIndex = 7;
            // 
            // txtImportoIvato
            // 
            this.txtImportoIvato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportoIvato.Location = new System.Drawing.Point(342, 166);
            this.txtImportoIvato.Name = "txtImportoIvato";
            this.txtImportoIvato.Size = new System.Drawing.Size(248, 24);
            this.txtImportoIvato.TabIndex = 5;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(17, 359);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(40, 18);
            this.lblNote.TabIndex = 20;
            this.lblNote.Text = "Note";
            // 
            // cbxImpAppross
            // 
            this.cbxImpAppross.AutoSize = true;
            this.cbxImpAppross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxImpAppross.Location = new System.Drawing.Point(342, 212);
            this.cbxImpAppross.Name = "cbxImpAppross";
            this.cbxImpAppross.Size = new System.Drawing.Size(15, 14);
            this.cbxImpAppross.TabIndex = 6;
            this.cbxImpAppross.UseVisualStyleBackColor = true;
            // 
            // lblCausale
            // 
            this.lblCausale.AutoSize = true;
            this.lblCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausale.Location = new System.Drawing.Point(15, 286);
            this.lblCausale.Name = "lblCausale";
            this.lblCausale.Size = new System.Drawing.Size(62, 18);
            this.lblCausale.TabIndex = 22;
            this.lblCausale.Text = "Causale";
            // 
            // cbxScadAppross
            // 
            this.cbxScadAppross.AutoSize = true;
            this.cbxScadAppross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxScadAppross.Location = new System.Drawing.Point(342, 137);
            this.cbxScadAppross.Name = "cbxScadAppross";
            this.cbxScadAppross.Size = new System.Drawing.Size(15, 14);
            this.cbxScadAppross.TabIndex = 4;
            this.cbxScadAppross.UseVisualStyleBackColor = true;
            // 
            // lblImportoNetto
            // 
            this.lblImportoNetto.AutoSize = true;
            this.lblImportoNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportoNetto.Location = new System.Drawing.Point(15, 246);
            this.lblImportoNetto.Name = "lblImportoNetto";
            this.lblImportoNetto.Size = new System.Drawing.Size(149, 18);
            this.lblImportoNetto.TabIndex = 23;
            this.lblImportoNetto.Text = "Importo (IVA esclusa)";
            // 
            // dtpickScadenza
            // 
            this.dtpickScadenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickScadenza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickScadenza.Location = new System.Drawing.Point(341, 90);
            this.dtpickScadenza.Name = "dtpickScadenza";
            this.dtpickScadenza.Size = new System.Drawing.Size(248, 24);
            this.dtpickScadenza.TabIndex = 3;
            // 
            // lblImportoIvato
            // 
            this.lblImportoIvato.AutoSize = true;
            this.lblImportoIvato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportoIvato.Location = new System.Drawing.Point(15, 169);
            this.lblImportoIvato.Name = "lblImportoIvato";
            this.lblImportoIvato.Size = new System.Drawing.Size(165, 18);
            this.lblImportoIvato.TabIndex = 17;
            this.lblImportoIvato.Text = "Importo (IVA compresa)";
            // 
            // lblImpAppross
            // 
            this.lblImpAppross.AutoSize = true;
            this.lblImpAppross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpAppross.Location = new System.Drawing.Point(15, 209);
            this.lblImpAppross.Name = "lblImpAppross";
            this.lblImpAppross.Size = new System.Drawing.Size(154, 18);
            this.lblImpAppross.TabIndex = 19;
            this.lblImpAppross.Text = "Importo approssimato";
            // 
            // lblScadAppross
            // 
            this.lblScadAppross.AutoSize = true;
            this.lblScadAppross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScadAppross.Location = new System.Drawing.Point(15, 131);
            this.lblScadAppross.Name = "lblScadAppross";
            this.lblScadAppross.Size = new System.Drawing.Size(168, 18);
            this.lblScadAppross.TabIndex = 18;
            this.lblScadAppross.Text = "Scadenza approssimata";
            // 
            // lblScadenza
            // 
            this.lblScadenza.AutoSize = true;
            this.lblScadenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScadenza.Location = new System.Drawing.Point(14, 95);
            this.lblScadenza.Name = "lblScadenza";
            this.lblScadenza.Size = new System.Drawing.Size(107, 18);
            this.lblScadenza.TabIndex = 16;
            this.lblScadenza.Text = "Data scadenza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stato";
            // 
            // cbxUltim
            // 
            this.cbxUltim.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxUltim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUltim.Location = new System.Drawing.Point(342, 9);
            this.cbxUltim.Name = "cbxUltim";
            this.cbxUltim.Size = new System.Drawing.Size(250, 33);
            this.cbxUltim.TabIndex = 1;
            this.cbxUltim.Text = "incassato";
            this.cbxUltim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxUltim.UseVisualStyleBackColor = true;
            this.cbxUltim.CheckedChanged += new System.EventHandler(this.cbxUltim_CheckedChanged);
            // 
            // lblDataUlt
            // 
            this.lblDataUlt.AutoSize = true;
            this.lblDataUlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataUlt.Location = new System.Drawing.Point(15, 53);
            this.lblDataUlt.Name = "lblDataUlt";
            this.lblDataUlt.Size = new System.Drawing.Size(95, 18);
            this.lblDataUlt.TabIndex = 16;
            this.lblDataUlt.Text = "Data incasso";
            // 
            // dtpickUltim
            // 
            this.dtpickUltim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickUltim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickUltim.Location = new System.Drawing.Point(342, 48);
            this.dtpickUltim.Name = "dtpickUltim";
            this.dtpickUltim.Size = new System.Drawing.Size(248, 24);
            this.dtpickUltim.TabIndex = 2;
            // 
            // lblUtenteValue
            // 
            this.lblUtenteValue.AutoSize = true;
            this.lblUtenteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtenteValue.Location = new System.Drawing.Point(27, 22);
            this.lblUtenteValue.Name = "lblUtenteValue";
            this.lblUtenteValue.Size = new System.Drawing.Size(57, 18);
            this.lblUtenteValue.TabIndex = 14;
            this.lblUtenteValue.Text = "Utente";
            // 
            // lblDestValue
            // 
            this.lblDestValue.AutoSize = true;
            this.lblDestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestValue.Location = new System.Drawing.Point(351, 22);
            this.lblDestValue.Name = "lblDestValue";
            this.lblDestValue.Size = new System.Drawing.Size(99, 18);
            this.lblDestValue.TabIndex = 13;
            this.lblDestValue.Text = "Destinatario";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.Location = new System.Drawing.Point(292, 22);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(27, 18);
            this.lblArrow.TabIndex = 14;
            this.lblArrow.Text = "-->";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel);
            this.panel1.Controls.Add(this.lblImportoIvato);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.lblScadenza);
            this.panel1.Controls.Add(this.txtCausale);
            this.panel1.Controls.Add(this.lblScadAppross);
            this.panel1.Controls.Add(this.txtImportoNetto);
            this.panel1.Controls.Add(this.lblDataUlt);
            this.panel1.Controls.Add(this.txtImportoIvato);
            this.panel1.Controls.Add(this.lblImpAppross);
            this.panel1.Controls.Add(this.lblCat);
            this.panel1.Controls.Add(this.lblNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxUltim);
            this.panel1.Controls.Add(this.dtpickScadenza);
            this.panel1.Controls.Add(this.cbxImpAppross);
            this.panel1.Controls.Add(this.dtpickUltim);
            this.panel1.Controls.Add(this.lblCausale);
            this.panel1.Controls.Add(this.lblImportoNetto);
            this.panel1.Controls.Add(this.cbxScadAppross);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 581);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(341, 447);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(251, 113);
            this.flowLayoutPanel.TabIndex = 10;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(17, 447);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(173, 18);
            this.lblCat.TabIndex = 20;
            this.lblCat.Text = "Categorie del movimento";
            // 
            // EditMovimentoForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnulla;
            this.ClientSize = new System.Drawing.Size(641, 697);
            this.Controls.Add(this.lblDestValue);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblUtenteValue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "EditMovimentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica singolo movimento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtCausale;
        private System.Windows.Forms.TextBox txtImportoNetto;
        private System.Windows.Forms.TextBox txtImportoIvato;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox cbxImpAppross;
        private System.Windows.Forms.Label lblCausale;
        private System.Windows.Forms.CheckBox cbxScadAppross;
        private System.Windows.Forms.Label lblImportoNetto;
        private System.Windows.Forms.DateTimePicker dtpickScadenza;
        private System.Windows.Forms.Label lblImportoIvato;
        private System.Windows.Forms.Label lblImpAppross;
        private System.Windows.Forms.Label lblScadAppross;
        private System.Windows.Forms.Label lblScadenza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxUltim;
        private System.Windows.Forms.Label lblDataUlt;
        private System.Windows.Forms.DateTimePicker dtpickUltim;
        private System.Windows.Forms.Label lblUtenteValue;
        private System.Windows.Forms.Label lblDestValue;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblCat;
    }
}