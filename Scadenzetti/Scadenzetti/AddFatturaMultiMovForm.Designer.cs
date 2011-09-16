namespace Scadenzetti
{
    partial class AddFatturaMultiMovForm
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
            this.flowLayoutPanelMovs = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCausale = new System.Windows.Forms.TextBox();
            this.lblCausale = new System.Windows.Forms.Label();
            this.dtpickScadenza = new System.Windows.Forms.DateTimePicker();
            this.lblScadenza = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblUtente = new System.Windows.Forms.Label();
            this.dropDest = new System.Windows.Forms.ComboBox();
            this.dropUtente = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblCatMovs = new System.Windows.Forms.Label();
            this.btnAddDest = new System.Windows.Forms.Button();
            this.lblNumMovFattura = new System.Windows.Forms.Label();
            this.btnAddMovFattura = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotFattura = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMovs
            // 
            this.flowLayoutPanelMovs.AutoScroll = true;
            this.flowLayoutPanelMovs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMovs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMovs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanelMovs.Location = new System.Drawing.Point(69, 223);
            this.flowLayoutPanelMovs.MaximumSize = new System.Drawing.Size(588, 2500);
            this.flowLayoutPanelMovs.Name = "flowLayoutPanelMovs";
            this.flowLayoutPanelMovs.Size = new System.Drawing.Size(588, 565);
            this.flowLayoutPanelMovs.TabIndex = 5;
            this.flowLayoutPanelMovs.WrapContents = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "*";
            // 
            // txtCausale
            // 
            this.txtCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausale.Location = new System.Drawing.Point(328, 130);
            this.txtCausale.Margin = new System.Windows.Forms.Padding(4);
            this.txtCausale.Multiline = true;
            this.txtCausale.Name = "txtCausale";
            this.txtCausale.Size = new System.Drawing.Size(329, 28);
            this.txtCausale.TabIndex = 4;
            // 
            // lblCausale
            // 
            this.lblCausale.AutoSize = true;
            this.lblCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausale.Location = new System.Drawing.Point(65, 133);
            this.lblCausale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCausale.Name = "lblCausale";
            this.lblCausale.Size = new System.Drawing.Size(149, 24);
            this.lblCausale.TabIndex = 29;
            this.lblCausale.Text = "Prefisso Causale";
            // 
            // dtpickScadenza
            // 
            this.dtpickScadenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickScadenza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickScadenza.Location = new System.Drawing.Point(328, 93);
            this.dtpickScadenza.Margin = new System.Windows.Forms.Padding(4);
            this.dtpickScadenza.Name = "dtpickScadenza";
            this.dtpickScadenza.Size = new System.Drawing.Size(329, 29);
            this.dtpickScadenza.TabIndex = 3;
            // 
            // lblScadenza
            // 
            this.lblScadenza.AutoSize = true;
            this.lblScadenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScadenza.Location = new System.Drawing.Point(66, 97);
            this.lblScadenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScadenza.Name = "lblScadenza";
            this.lblScadenza.Size = new System.Drawing.Size(133, 24);
            this.lblScadenza.TabIndex = 23;
            this.lblScadenza.Text = "Data scadenza";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.Location = new System.Drawing.Point(65, 56);
            this.lblDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(107, 24);
            this.lblDest.TabIndex = 18;
            this.lblDest.Text = "Destinatario";
            // 
            // lblUtente
            // 
            this.lblUtente.AutoSize = true;
            this.lblUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtente.Location = new System.Drawing.Point(65, 17);
            this.lblUtente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtente.Name = "lblUtente";
            this.lblUtente.Size = new System.Drawing.Size(64, 24);
            this.lblUtente.TabIndex = 21;
            this.lblUtente.Text = "Utente";
            // 
            // dropDest
            // 
            this.dropDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDest.FormattingEnabled = true;
            this.dropDest.Location = new System.Drawing.Point(328, 53);
            this.dropDest.Margin = new System.Windows.Forms.Padding(4);
            this.dropDest.Name = "dropDest";
            this.dropDest.Size = new System.Drawing.Size(329, 32);
            this.dropDest.Sorted = true;
            this.dropDest.TabIndex = 1;
            // 
            // dropUtente
            // 
            this.dropUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropUtente.FormattingEnabled = true;
            this.dropUtente.Location = new System.Drawing.Point(328, 13);
            this.dropUtente.Margin = new System.Windows.Forms.Padding(4);
            this.dropUtente.Name = "dropUtente";
            this.dropUtente.Size = new System.Drawing.Size(329, 32);
            this.dropUtente.Sorted = true;
            this.dropUtente.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(759, 855);
            this.shapeContainer1.TabIndex = 39;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -14;
            this.lineShape1.X2 = 770;
            this.lineShape1.Y1 = 173;
            this.lineShape1.Y2 = 173;
            // 
            // lblCatMovs
            // 
            this.lblCatMovs.AutoSize = true;
            this.lblCatMovs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatMovs.Location = new System.Drawing.Point(65, 184);
            this.lblCatMovs.Name = "lblCatMovs";
            this.lblCatMovs.Size = new System.Drawing.Size(184, 25);
            this.lblCatMovs.TabIndex = 41;
            this.lblCatMovs.Text = "Movimenti fattura:";
            // 
            // btnAddDest
            // 
            this.btnAddDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddDest.BackgroundImage = global::Scadenzetti.Properties.Resources.Add_24x24;
            this.btnAddDest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddDest.Location = new System.Drawing.Point(670, 48);
            this.btnAddDest.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDest.Name = "btnAddDest";
            this.btnAddDest.Size = new System.Drawing.Size(51, 43);
            this.btnAddDest.TabIndex = 2;
            this.btnAddDest.UseVisualStyleBackColor = false;
            this.btnAddDest.Click += new System.EventHandler(this.btnAddDest_Click);
            // 
            // lblNumMovFattura
            // 
            this.lblNumMovFattura.AutoSize = true;
            this.lblNumMovFattura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMovFattura.Location = new System.Drawing.Point(255, 184);
            this.lblNumMovFattura.Name = "lblNumMovFattura";
            this.lblNumMovFattura.Size = new System.Drawing.Size(24, 25);
            this.lblNumMovFattura.TabIndex = 41;
            this.lblNumMovFattura.Text = "2";
            // 
            // btnAddMovFattura
            // 
            this.btnAddMovFattura.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddMovFattura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovFattura.Location = new System.Drawing.Point(618, 187);
            this.btnAddMovFattura.Name = "btnAddMovFattura";
            this.btnAddMovFattura.Size = new System.Drawing.Size(39, 30);
            this.btnAddMovFattura.TabIndex = 42;
            this.btnAddMovFattura.Text = "+";
            this.btnAddMovFattura.UseVisualStyleBackColor = false;
            this.btnAddMovFattura.Click += new System.EventHandler(this.btnAddMovFattura_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(324, 809);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(500, 809);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTotFattura
            // 
            this.lblTotFattura.AutoSize = true;
            this.lblTotFattura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotFattura.Location = new System.Drawing.Point(323, 184);
            this.lblTotFattura.Name = "lblTotFattura";
            this.lblTotFattura.Size = new System.Drawing.Size(70, 25);
            this.lblTotFattura.TabIndex = 41;
            this.lblTotFattura.Text = "TOT: ";
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(388, 184);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(24, 25);
            this.lblTotale.TabIndex = 41;
            this.lblTotale.Text = "0";
            // 
            // AddFatturaMultiMovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 855);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.lblTotFattura);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMovFattura);
            this.Controls.Add(this.lblNumMovFattura);
            this.Controls.Add(this.lblCatMovs);
            this.Controls.Add(this.flowLayoutPanelMovs);
            this.Controls.Add(this.btnAddDest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCausale);
            this.Controls.Add(this.lblCausale);
            this.Controls.Add(this.dtpickScadenza);
            this.Controls.Add(this.lblScadenza);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblUtente);
            this.Controls.Add(this.dropDest);
            this.Controls.Add(this.dropUtente);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "AddFatturaMultiMovForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi fattura multi-movimento";
            this.Load += new System.EventHandler(this.AddFatturaMultiMovForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCausale;
        private System.Windows.Forms.Label lblCausale;
        private System.Windows.Forms.DateTimePicker dtpickScadenza;
        private System.Windows.Forms.Label lblScadenza;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblUtente;
        private System.Windows.Forms.ComboBox dropDest;
        private System.Windows.Forms.ComboBox dropUtente;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovs;
        private System.Windows.Forms.Label lblCatMovs;
        private System.Windows.Forms.Label lblNumMovFattura;
        private System.Windows.Forms.Button btnAddMovFattura;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotFattura;
        private System.Windows.Forms.Label lblTotale;
    }
}