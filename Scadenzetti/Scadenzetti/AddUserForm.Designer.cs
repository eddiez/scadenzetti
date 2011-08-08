namespace Scadenzetti
{
    partial class AddUserForm
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
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPiva = new System.Windows.Forms.TextBox();
            this.lblPiva = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtCf = new System.Windows.Forms.TextBox();
            this.lblCF = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Società",
            "Persona Fisica"});
            this.cbxTipo.Location = new System.Drawing.Point(197, 43);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(162, 26);
            this.cbxTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(24, 46);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(81, 18);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo utente";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(197, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 24);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtPiva
            // 
            this.txtPiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiva.Location = new System.Drawing.Point(197, 122);
            this.txtPiva.Name = "txtPiva";
            this.txtPiva.Size = new System.Drawing.Size(162, 24);
            this.txtPiva.TabIndex = 3;
            // 
            // lblPiva
            // 
            this.lblPiva.AutoSize = true;
            this.lblPiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiva.Location = new System.Drawing.Point(24, 125);
            this.lblPiva.Name = "lblPiva";
            this.lblPiva.Size = new System.Drawing.Size(166, 18);
            this.lblPiva.TabIndex = 1;
            this.lblPiva.Text = "Partita IVA (se presente)";
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(24, 151);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(42, 18);
            this.lblSede.TabIndex = 1;
            this.lblSede.Text = "Sede";
            // 
            // txtSede
            // 
            this.txtSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSede.Location = new System.Drawing.Point(197, 148);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(162, 24);
            this.txtSede.TabIndex = 4;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(24, 177);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(87, 18);
            this.lblDescr.TabIndex = 1;
            this.lblDescr.Text = "Descrizione";
            // 
            // txtDescr
            // 
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(197, 174);
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(162, 75);
            this.txtDescr.TabIndex = 5;
            // 
            // txtCf
            // 
            this.txtCf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCf.Location = new System.Drawing.Point(197, 96);
            this.txtCf.Name = "txtCf";
            this.txtCf.Size = new System.Drawing.Size(162, 24);
            this.txtCf.TabIndex = 2;
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF.Location = new System.Drawing.Point(24, 99);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(106, 18);
            this.lblCF.TabIndex = 1;
            this.lblCF.Text = "Codice Fiscale";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(279, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(193, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUserForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(371, 313);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.txtPiva);
            this.Controls.Add(this.lblPiva);
            this.Controls.Add(this.lblCF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbxTipo);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi Utente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPiva;
        private System.Windows.Forms.Label lblPiva;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtCf;
        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;

    }
}