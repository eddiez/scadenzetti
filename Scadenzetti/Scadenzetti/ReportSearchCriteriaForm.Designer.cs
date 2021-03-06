﻿namespace Scadenzetti
{
    partial class ReportSearchCriteriaForm
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
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabPageUsciteMensili = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.numAnno = new System.Windows.Forms.NumericUpDown();
            this.btnCreateMonthlyExpense = new System.Windows.Forms.Button();
            this.cbxMese = new System.Windows.Forms.ComboBox();
            this.lblUtente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMese = new System.Windows.Forms.Label();
            this.tabPageYearMatrix = new System.Windows.Forms.TabPage();
            this.numericUpDownMatrix = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnnoMatrix = new System.Windows.Forms.Label();
            this.btnCreateMatrixReport = new System.Windows.Forms.Button();
            this.tabPageCategoriaMov = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateCategoryReport = new System.Windows.Forms.Button();
            this.tabPagePersonalizzato = new System.Windows.Forms.TabPage();
            this.btnCreateAllReport = new System.Windows.Forms.Button();
            this.dtDataTo = new System.Windows.Forms.DateTimePicker();
            this.dtDataFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDataTo = new System.Windows.Forms.Label();
            this.lblMovFrom = new System.Windows.Forms.Label();
            this.lblHeadPers = new System.Windows.Forms.Label();
            this.tabReports.SuspendLayout();
            this.tabPageUsciteMensili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnno)).BeginInit();
            this.tabPageYearMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrix)).BeginInit();
            this.tabPageCategoriaMov.SuspendLayout();
            this.tabPagePersonalizzato.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabPageCategoriaMov);
            this.tabReports.Controls.Add(this.tabPageUsciteMensili);
            this.tabReports.Controls.Add(this.tabPageYearMatrix);
            this.tabReports.Controls.Add(this.tabPagePersonalizzato);
            this.tabReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReports.Location = new System.Drawing.Point(4, 15);
            this.tabReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(659, 421);
            this.tabReports.TabIndex = 0;
            // 
            // tabPageUsciteMensili
            // 
            this.tabPageUsciteMensili.Controls.Add(this.flowLayoutPanelUsers);
            this.tabPageUsciteMensili.Controls.Add(this.numAnno);
            this.tabPageUsciteMensili.Controls.Add(this.btnCreateMonthlyExpense);
            this.tabPageUsciteMensili.Controls.Add(this.cbxMese);
            this.tabPageUsciteMensili.Controls.Add(this.lblUtente);
            this.tabPageUsciteMensili.Controls.Add(this.label1);
            this.tabPageUsciteMensili.Controls.Add(this.label2);
            this.tabPageUsciteMensili.Controls.Add(this.lblMese);
            this.tabPageUsciteMensili.Location = new System.Drawing.Point(4, 29);
            this.tabPageUsciteMensili.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUsciteMensili.Name = "tabPageUsciteMensili";
            this.tabPageUsciteMensili.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUsciteMensili.Size = new System.Drawing.Size(651, 388);
            this.tabPageUsciteMensili.TabIndex = 0;
            this.tabPageUsciteMensili.Text = "Uscite mensili";
            this.tabPageUsciteMensili.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelUsers
            // 
            this.flowLayoutPanelUsers.AutoScroll = true;
            this.flowLayoutPanelUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelUsers.Location = new System.Drawing.Point(195, 156);
            this.flowLayoutPanelUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            this.flowLayoutPanelUsers.Size = new System.Drawing.Size(419, 102);
            this.flowLayoutPanelUsers.TabIndex = 5;
            // 
            // numAnno
            // 
            this.numAnno.Location = new System.Drawing.Point(503, 100);
            this.numAnno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numAnno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnno.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numAnno.Name = "numAnno";
            this.numAnno.ReadOnly = true;
            this.numAnno.Size = new System.Drawing.Size(112, 26);
            this.numAnno.TabIndex = 4;
            this.numAnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAnno.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btnCreateMonthlyExpense
            // 
            this.btnCreateMonthlyExpense.Location = new System.Drawing.Point(469, 313);
            this.btnCreateMonthlyExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateMonthlyExpense.Name = "btnCreateMonthlyExpense";
            this.btnCreateMonthlyExpense.Size = new System.Drawing.Size(145, 38);
            this.btnCreateMonthlyExpense.TabIndex = 3;
            this.btnCreateMonthlyExpense.Text = "Genera";
            this.btnCreateMonthlyExpense.UseVisualStyleBackColor = true;
            this.btnCreateMonthlyExpense.Click += new System.EventHandler(this.btnCreateMonthlyExpense_Click);
            // 
            // cbxMese
            // 
            this.cbxMese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMese.FormattingEnabled = true;
            this.cbxMese.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.cbxMese.Location = new System.Drawing.Point(201, 98);
            this.cbxMese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMese.Name = "cbxMese";
            this.cbxMese.Size = new System.Drawing.Size(217, 28);
            this.cbxMese.TabIndex = 1;
            // 
            // lblUtente
            // 
            this.lblUtente.AutoSize = true;
            this.lblUtente.Location = new System.Drawing.Point(23, 156);
            this.lblUtente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtente.Name = "lblUtente";
            this.lblUtente.Size = new System.Drawing.Size(53, 20);
            this.lblUtente.TabIndex = 0;
            this.lblUtente.Text = "Utenti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uscite Mensili non saldate";
            // 
            // lblMese
            // 
            this.lblMese.AutoSize = true;
            this.lblMese.Location = new System.Drawing.Point(23, 102);
            this.lblMese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMese.Name = "lblMese";
            this.lblMese.Size = new System.Drawing.Size(50, 20);
            this.lblMese.TabIndex = 0;
            this.lblMese.Text = "Mese";
            // 
            // tabPageYearMatrix
            // 
            this.tabPageYearMatrix.Controls.Add(this.numericUpDownMatrix);
            this.tabPageYearMatrix.Controls.Add(this.label3);
            this.tabPageYearMatrix.Controls.Add(this.lblAnnoMatrix);
            this.tabPageYearMatrix.Controls.Add(this.btnCreateMatrixReport);
            this.tabPageYearMatrix.Location = new System.Drawing.Point(4, 29);
            this.tabPageYearMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageYearMatrix.Name = "tabPageYearMatrix";
            this.tabPageYearMatrix.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageYearMatrix.Size = new System.Drawing.Size(651, 388);
            this.tabPageYearMatrix.TabIndex = 4;
            this.tabPageYearMatrix.Text = "Uscite Annuali";
            this.tabPageYearMatrix.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMatrix
            // 
            this.numericUpDownMatrix.Location = new System.Drawing.Point(272, 156);
            this.numericUpDownMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMatrix.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownMatrix.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownMatrix.Name = "numericUpDownMatrix";
            this.numericUpDownMatrix.ReadOnly = true;
            this.numericUpDownMatrix.Size = new System.Drawing.Size(112, 26);
            this.numericUpDownMatrix.TabIndex = 5;
            this.numericUpDownMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMatrix.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Uscite annuali saldate e non";
            // 
            // lblAnnoMatrix
            // 
            this.lblAnnoMatrix.AutoSize = true;
            this.lblAnnoMatrix.Location = new System.Drawing.Point(188, 159);
            this.lblAnnoMatrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnoMatrix.Name = "lblAnnoMatrix";
            this.lblAnnoMatrix.Size = new System.Drawing.Size(47, 20);
            this.lblAnnoMatrix.TabIndex = 1;
            this.lblAnnoMatrix.Text = "Anno";
            // 
            // btnCreateMatrixReport
            // 
            this.btnCreateMatrixReport.Location = new System.Drawing.Point(471, 325);
            this.btnCreateMatrixReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateMatrixReport.Name = "btnCreateMatrixReport";
            this.btnCreateMatrixReport.Size = new System.Drawing.Size(145, 38);
            this.btnCreateMatrixReport.TabIndex = 0;
            this.btnCreateMatrixReport.Text = "Genera";
            this.btnCreateMatrixReport.UseVisualStyleBackColor = true;
            this.btnCreateMatrixReport.Click += new System.EventHandler(this.btnCreateMatrixReport_Click);
            // 
            // tabPageCategoriaMov
            // 
            this.tabPageCategoriaMov.Controls.Add(this.label4);
            this.tabPageCategoriaMov.Controls.Add(this.lblCat);
            this.tabPageCategoriaMov.Controls.Add(this.flowLayoutPanelCategories);
            this.tabPageCategoriaMov.Controls.Add(this.btnCreateCategoryReport);
            this.tabPageCategoriaMov.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategoriaMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageCategoriaMov.Name = "tabPageCategoriaMov";
            this.tabPageCategoriaMov.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageCategoriaMov.Size = new System.Drawing.Size(651, 388);
            this.tabPageCategoriaMov.TabIndex = 1;
            this.tabPageCategoriaMov.Text = "Categoria";
            this.tabPageCategoriaMov.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tutti i movimenti (entrate/uscite) saldati e non di una categoria";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(27, 84);
            this.lblCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(162, 20);
            this.lblCat.TabIndex = 8;
            this.lblCat.Text = "Categoria movimenti";
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.AutoScroll = true;
            this.flowLayoutPanelCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(253, 84);
            this.flowLayoutPanelCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(353, 178);
            this.flowLayoutPanelCategories.TabIndex = 6;
            // 
            // btnCreateCategoryReport
            // 
            this.btnCreateCategoryReport.Location = new System.Drawing.Point(461, 322);
            this.btnCreateCategoryReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCategoryReport.Name = "btnCreateCategoryReport";
            this.btnCreateCategoryReport.Size = new System.Drawing.Size(145, 38);
            this.btnCreateCategoryReport.TabIndex = 1;
            this.btnCreateCategoryReport.Text = "Genera";
            this.btnCreateCategoryReport.UseVisualStyleBackColor = true;
            this.btnCreateCategoryReport.Click += new System.EventHandler(this.btnCreateCategoryReport_Click);
            // 
            // tabPagePersonalizzato
            // 
            this.tabPagePersonalizzato.Controls.Add(this.btnCreateAllReport);
            this.tabPagePersonalizzato.Controls.Add(this.dtDataTo);
            this.tabPagePersonalizzato.Controls.Add(this.dtDataFrom);
            this.tabPagePersonalizzato.Controls.Add(this.lblDataTo);
            this.tabPagePersonalizzato.Controls.Add(this.lblMovFrom);
            this.tabPagePersonalizzato.Controls.Add(this.lblHeadPers);
            this.tabPagePersonalizzato.Location = new System.Drawing.Point(4, 29);
            this.tabPagePersonalizzato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePersonalizzato.Name = "tabPagePersonalizzato";
            this.tabPagePersonalizzato.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePersonalizzato.Size = new System.Drawing.Size(651, 388);
            this.tabPagePersonalizzato.TabIndex = 3;
            this.tabPagePersonalizzato.Text = "Personalizzato";
            this.tabPagePersonalizzato.UseVisualStyleBackColor = true;
            // 
            // btnCreateAllReport
            // 
            this.btnCreateAllReport.Location = new System.Drawing.Point(428, 308);
            this.btnCreateAllReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAllReport.Name = "btnCreateAllReport";
            this.btnCreateAllReport.Size = new System.Drawing.Size(145, 38);
            this.btnCreateAllReport.TabIndex = 12;
            this.btnCreateAllReport.Text = "Genera";
            this.btnCreateAllReport.UseVisualStyleBackColor = true;
            this.btnCreateAllReport.Click += new System.EventHandler(this.btnCreateAllReport_Click);
            // 
            // dtDataTo
            // 
            this.dtDataTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataTo.Location = new System.Drawing.Point(307, 174);
            this.dtDataTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataTo.Name = "dtDataTo";
            this.dtDataTo.Size = new System.Drawing.Size(265, 26);
            this.dtDataTo.TabIndex = 11;
            // 
            // dtDataFrom
            // 
            this.dtDataFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFrom.Location = new System.Drawing.Point(307, 84);
            this.dtDataFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataFrom.Name = "dtDataFrom";
            this.dtDataFrom.Size = new System.Drawing.Size(265, 26);
            this.dtDataFrom.TabIndex = 11;
            // 
            // lblDataTo
            // 
            this.lblDataTo.AutoSize = true;
            this.lblDataTo.Location = new System.Drawing.Point(23, 180);
            this.lblDataTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataTo.Name = "lblDataTo";
            this.lblDataTo.Size = new System.Drawing.Size(106, 20);
            this.lblDataTo.TabIndex = 10;
            this.lblDataTo.Text = "Data termine";
            // 
            // lblMovFrom
            // 
            this.lblMovFrom.AutoSize = true;
            this.lblMovFrom.Location = new System.Drawing.Point(23, 90);
            this.lblMovFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovFrom.Name = "lblMovFrom";
            this.lblMovFrom.Size = new System.Drawing.Size(115, 20);
            this.lblMovFrom.TabIndex = 10;
            this.lblMovFrom.Text = "Data partenza";
            // 
            // lblHeadPers
            // 
            this.lblHeadPers.AutoSize = true;
            this.lblHeadPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadPers.Location = new System.Drawing.Point(23, 31);
            this.lblHeadPers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadPers.Name = "lblHeadPers";
            this.lblHeadPers.Size = new System.Drawing.Size(149, 20);
            this.lblHeadPers.TabIndex = 9;
            this.lblHeadPers.Text = "Tutti i movimenti";
            // 
            // ReportSearchCriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.tabReports);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ReportSearchCriteriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criteri di creazione report di stampa";
            this.tabReports.ResumeLayout(false);
            this.tabPageUsciteMensili.ResumeLayout(false);
            this.tabPageUsciteMensili.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnno)).EndInit();
            this.tabPageYearMatrix.ResumeLayout(false);
            this.tabPageYearMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrix)).EndInit();
            this.tabPageCategoriaMov.ResumeLayout(false);
            this.tabPageCategoriaMov.PerformLayout();
            this.tabPagePersonalizzato.ResumeLayout(false);
            this.tabPagePersonalizzato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabPageUsciteMensili;
        private System.Windows.Forms.TabPage tabPageCategoriaMov;
        private System.Windows.Forms.ComboBox cbxMese;
        private System.Windows.Forms.Label lblUtente;
        private System.Windows.Forms.Label lblMese;
        private System.Windows.Forms.TabPage tabPagePersonalizzato;
        private System.Windows.Forms.Button btnCreateMonthlyExpense;
        private System.Windows.Forms.NumericUpDown numAnno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsers;
        private System.Windows.Forms.TabPage tabPageYearMatrix;
        private System.Windows.Forms.Button btnCreateMatrixReport;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrix;
        private System.Windows.Forms.Label lblAnnoMatrix;
        private System.Windows.Forms.Button btnCreateCategoryReport;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDataTo;
        private System.Windows.Forms.Label lblMovFrom;
        private System.Windows.Forms.Label lblHeadPers;
        private System.Windows.Forms.Button btnCreateAllReport;
        private System.Windows.Forms.DateTimePicker dtDataTo;
        private System.Windows.Forms.DateTimePicker dtDataFrom;
    }
}