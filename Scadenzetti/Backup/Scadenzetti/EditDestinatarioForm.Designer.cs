namespace Scadenzetti
{
    partial class EditDestinatarioForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblPiva = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.txtPiva = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(209, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(128, 255);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(47, 255);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 30);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<-";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(290, 255);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 30);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(49, 123);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(87, 18);
            this.lblDescr.TabIndex = 14;
            this.lblDescr.Text = "Descrizione";
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(49, 93);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(42, 18);
            this.lblSede.TabIndex = 11;
            this.lblSede.Text = "Sede";
            // 
            // lblPiva
            // 
            this.lblPiva.AutoSize = true;
            this.lblPiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiva.Location = new System.Drawing.Point(49, 63);
            this.lblPiva.Name = "lblPiva";
            this.lblPiva.Size = new System.Drawing.Size(75, 18);
            this.lblPiva.TabIndex = 10;
            this.lblPiva.Text = "Partita IVA";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(49, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtDescr
            // 
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(173, 120);
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(197, 100);
            this.txtDescr.TabIndex = 3;
            // 
            // txtSede
            // 
            this.txtSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSede.Location = new System.Drawing.Point(173, 90);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(197, 24);
            this.txtSede.TabIndex = 2;
            // 
            // txtPiva
            // 
            this.txtPiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiva.Location = new System.Drawing.Point(173, 60);
            this.txtPiva.Name = "txtPiva";
            this.txtPiva.Size = new System.Drawing.Size(197, 24);
            this.txtPiva.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(173, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 24);
            this.txtNome.TabIndex = 0;
            // 
            // EditDestinatarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 313);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblPiva);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.txtPiva);
            this.Controls.Add(this.txtNome);
            this.Name = "EditDestinatarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista destinatari movimenti";
            this.Load += new System.EventHandler(this.EditDestinatarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblPiva;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.TextBox txtPiva;
        private System.Windows.Forms.TextBox txtNome;
    }
}