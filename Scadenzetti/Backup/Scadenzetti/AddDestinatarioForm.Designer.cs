namespace Scadenzetti
{
    partial class AddDestinatarioForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.lblSede = new System.Windows.Forms.Label();
            this.txtPiva = new System.Windows.Forms.TextBox();
            this.lblPiva = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(207, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(293, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDescr
            // 
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(211, 114);
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(162, 75);
            this.txtDescr.TabIndex = 3;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(38, 117);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(87, 18);
            this.lblDescr.TabIndex = 8;
            this.lblDescr.Text = "Descrizione";
            // 
            // txtSede
            // 
            this.txtSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSede.Location = new System.Drawing.Point(211, 88);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(162, 24);
            this.txtSede.TabIndex = 2;
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(38, 91);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(42, 18);
            this.lblSede.TabIndex = 9;
            this.lblSede.Text = "Sede";
            // 
            // txtPiva
            // 
            this.txtPiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiva.Location = new System.Drawing.Point(211, 62);
            this.txtPiva.Name = "txtPiva";
            this.txtPiva.Size = new System.Drawing.Size(162, 24);
            this.txtPiva.TabIndex = 1;
            // 
            // lblPiva
            // 
            this.lblPiva.AutoSize = true;
            this.lblPiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiva.Location = new System.Drawing.Point(38, 65);
            this.lblPiva.Name = "lblPiva";
            this.lblPiva.Size = new System.Drawing.Size(75, 18);
            this.lblPiva.TabIndex = 10;
            this.lblPiva.Text = "Partita IVA";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(38, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(211, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 24);
            this.txtNome.TabIndex = 0;
            // 
            // AddDestinatarioForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(411, 263);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.txtPiva);
            this.Controls.Add(this.lblPiva);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "AddDestinatarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi destinatario movimenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.TextBox txtPiva;
        private System.Windows.Forms.Label lblPiva;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}