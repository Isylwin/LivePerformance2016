namespace LP2016Form.UserControls
{
    partial class Overview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbContractDetails = new System.Windows.Forms.GroupBox();
            this.lblDetailsLoaner = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDetailsExportHtml = new System.Windows.Forms.Button();
            this.btnDetailsExportTxt = new System.Windows.Forms.Button();
            this.lblDateTill = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDetailsFrom = new System.Windows.Forms.DateTimePicker();
            this.dtmDetailsTill = new System.Windows.Forms.DateTimePicker();
            this.lbDetailsArticles = new System.Windows.Forms.ListBox();
            this.lblDetailsArticles = new System.Windows.Forms.Label();
            this.lblDetailsBoats = new System.Windows.Forms.Label();
            this.lbDetailsBoats = new System.Windows.Forms.ListBox();
            this.lblDetailsRenter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbContracts = new System.Windows.Forms.GroupBox();
            this.lbContracts = new System.Windows.Forms.ListBox();
            this.gbContractDetails.SuspendLayout();
            this.gbContracts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContractDetails
            // 
            this.gbContractDetails.Controls.Add(this.lblDetailsLoaner);
            this.gbContractDetails.Controls.Add(this.textBox2);
            this.gbContractDetails.Controls.Add(this.btnDetailsExportHtml);
            this.gbContractDetails.Controls.Add(this.btnDetailsExportTxt);
            this.gbContractDetails.Controls.Add(this.lblDateTill);
            this.gbContractDetails.Controls.Add(this.lblDateFrom);
            this.gbContractDetails.Controls.Add(this.dtpDetailsFrom);
            this.gbContractDetails.Controls.Add(this.dtmDetailsTill);
            this.gbContractDetails.Controls.Add(this.lbDetailsArticles);
            this.gbContractDetails.Controls.Add(this.lblDetailsArticles);
            this.gbContractDetails.Controls.Add(this.lblDetailsBoats);
            this.gbContractDetails.Controls.Add(this.lbDetailsBoats);
            this.gbContractDetails.Controls.Add(this.lblDetailsRenter);
            this.gbContractDetails.Controls.Add(this.textBox1);
            this.gbContractDetails.Location = new System.Drawing.Point(356, 13);
            this.gbContractDetails.Name = "gbContractDetails";
            this.gbContractDetails.Size = new System.Drawing.Size(694, 633);
            this.gbContractDetails.TabIndex = 4;
            this.gbContractDetails.TabStop = false;
            this.gbContractDetails.Text = "Details";
            // 
            // lblDetailsLoaner
            // 
            this.lblDetailsLoaner.AutoSize = true;
            this.lblDetailsLoaner.Location = new System.Drawing.Point(376, 31);
            this.lblDetailsLoaner.Name = "lblDetailsLoaner";
            this.lblDetailsLoaner.Size = new System.Drawing.Size(59, 13);
            this.lblDetailsLoaner.TabIndex = 13;
            this.lblDetailsLoaner.Text = "Verhuurder";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(379, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 12;
            // 
            // btnDetailsExportHtml
            // 
            this.btnDetailsExportHtml.Location = new System.Drawing.Point(379, 369);
            this.btnDetailsExportHtml.Name = "btnDetailsExportHtml";
            this.btnDetailsExportHtml.Size = new System.Drawing.Size(194, 23);
            this.btnDetailsExportHtml.TabIndex = 11;
            this.btnDetailsExportHtml.Text = "Exporteren naar html";
            this.btnDetailsExportHtml.UseVisualStyleBackColor = true;
            // 
            // btnDetailsExportTxt
            // 
            this.btnDetailsExportTxt.Location = new System.Drawing.Point(30, 369);
            this.btnDetailsExportTxt.Name = "btnDetailsExportTxt";
            this.btnDetailsExportTxt.Size = new System.Drawing.Size(194, 23);
            this.btnDetailsExportTxt.TabIndex = 10;
            this.btnDetailsExportTxt.Text = "Exporteren naar tekst";
            this.btnDetailsExportTxt.UseVisualStyleBackColor = true;
            // 
            // lblDateTill
            // 
            this.lblDateTill.AutoSize = true;
            this.lblDateTill.Location = new System.Drawing.Point(376, 262);
            this.lblDateTill.Name = "lblDateTill";
            this.lblDateTill.Size = new System.Drawing.Size(56, 13);
            this.lblDateTill.TabIndex = 9;
            this.lblDateTill.Text = "Datum tot:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(24, 262);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(62, 13);
            this.lblDateFrom.TabIndex = 8;
            this.lblDateFrom.Text = "Datum van:";
            // 
            // dtpDetailsFrom
            // 
            this.dtpDetailsFrom.Enabled = false;
            this.dtpDetailsFrom.Location = new System.Drawing.Point(24, 281);
            this.dtpDetailsFrom.Name = "dtpDetailsFrom";
            this.dtpDetailsFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDetailsFrom.TabIndex = 7;
            // 
            // dtmDetailsTill
            // 
            this.dtmDetailsTill.Enabled = false;
            this.dtmDetailsTill.Location = new System.Drawing.Point(379, 281);
            this.dtmDetailsTill.Name = "dtmDetailsTill";
            this.dtmDetailsTill.Size = new System.Drawing.Size(200, 20);
            this.dtmDetailsTill.TabIndex = 6;
            // 
            // lbDetailsArticles
            // 
            this.lbDetailsArticles.Enabled = false;
            this.lbDetailsArticles.FormattingEnabled = true;
            this.lbDetailsArticles.Location = new System.Drawing.Point(379, 114);
            this.lbDetailsArticles.Name = "lbDetailsArticles";
            this.lbDetailsArticles.Size = new System.Drawing.Size(264, 121);
            this.lbDetailsArticles.TabIndex = 5;
            // 
            // lblDetailsArticles
            // 
            this.lblDetailsArticles.AutoSize = true;
            this.lblDetailsArticles.Location = new System.Drawing.Point(376, 98);
            this.lblDetailsArticles.Name = "lblDetailsArticles";
            this.lblDetailsArticles.Size = new System.Drawing.Size(109, 13);
            this.lblDetailsArticles.TabIndex = 4;
            this.lblDetailsArticles.Text = "Bijkomende Artikelen:";
            // 
            // lblDetailsBoats
            // 
            this.lblDetailsBoats.AutoSize = true;
            this.lblDetailsBoats.Location = new System.Drawing.Point(21, 98);
            this.lblDetailsBoats.Name = "lblDetailsBoats";
            this.lblDetailsBoats.Size = new System.Drawing.Size(38, 13);
            this.lblDetailsBoats.TabIndex = 3;
            this.lblDetailsBoats.Text = "Boten:";
            // 
            // lbDetailsBoats
            // 
            this.lbDetailsBoats.Enabled = false;
            this.lbDetailsBoats.FormattingEnabled = true;
            this.lbDetailsBoats.Location = new System.Drawing.Point(24, 114);
            this.lbDetailsBoats.Name = "lbDetailsBoats";
            this.lbDetailsBoats.Size = new System.Drawing.Size(291, 121);
            this.lbDetailsBoats.TabIndex = 2;
            // 
            // lblDetailsRenter
            // 
            this.lblDetailsRenter.AutoSize = true;
            this.lblDetailsRenter.Location = new System.Drawing.Point(21, 31);
            this.lblDetailsRenter.Name = "lblDetailsRenter";
            this.lblDetailsRenter.Size = new System.Drawing.Size(48, 13);
            this.lblDetailsRenter.TabIndex = 1;
            this.lblDetailsRenter.Text = "Huurder:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(24, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 0;
            // 
            // gbContracts
            // 
            this.gbContracts.Controls.Add(this.lbContracts);
            this.gbContracts.Location = new System.Drawing.Point(10, 13);
            this.gbContracts.Name = "gbContracts";
            this.gbContracts.Size = new System.Drawing.Size(340, 633);
            this.gbContracts.TabIndex = 3;
            this.gbContracts.TabStop = false;
            this.gbContracts.Text = "Lijst van contracten";
            // 
            // lbContracts
            // 
            this.lbContracts.FormattingEnabled = true;
            this.lbContracts.Location = new System.Drawing.Point(6, 19);
            this.lbContracts.Name = "lbContracts";
            this.lbContracts.Size = new System.Drawing.Size(328, 602);
            this.lbContracts.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbContractDetails);
            this.Controls.Add(this.gbContracts);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1060, 659);
            this.gbContractDetails.ResumeLayout(false);
            this.gbContractDetails.PerformLayout();
            this.gbContracts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContractDetails;
        private System.Windows.Forms.Label lblDetailsLoaner;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDetailsExportHtml;
        private System.Windows.Forms.Button btnDetailsExportTxt;
        private System.Windows.Forms.Label lblDateTill;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDetailsFrom;
        private System.Windows.Forms.DateTimePicker dtmDetailsTill;
        private System.Windows.Forms.ListBox lbDetailsArticles;
        private System.Windows.Forms.Label lblDetailsArticles;
        private System.Windows.Forms.Label lblDetailsBoats;
        private System.Windows.Forms.ListBox lbDetailsBoats;
        private System.Windows.Forms.Label lblDetailsRenter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbContracts;
        private System.Windows.Forms.ListBox lbContracts;
    }
}
