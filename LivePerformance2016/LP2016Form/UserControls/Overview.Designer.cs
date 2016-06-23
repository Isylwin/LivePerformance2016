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
            this.tbDetailsLoaner = new System.Windows.Forms.TextBox();
            this.btnDetailsExportHtml = new System.Windows.Forms.Button();
            this.btnDetailsExportTxt = new System.Windows.Forms.Button();
            this.lblDateTill = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDetailsDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDetailsDateTill = new System.Windows.Forms.DateTimePicker();
            this.lbDetailsArticles = new System.Windows.Forms.ListBox();
            this.lblDetailsArticles = new System.Windows.Forms.Label();
            this.lblDetailsBoats = new System.Windows.Forms.Label();
            this.lbDetailsBoats = new System.Windows.Forms.ListBox();
            this.lblDetailsRenter = new System.Windows.Forms.Label();
            this.tbDetailsRenter = new System.Windows.Forms.TextBox();
            this.gbContracts = new System.Windows.Forms.GroupBox();
            this.lbContracts = new System.Windows.Forms.ListBox();
            this.gbContractTemprature = new System.Windows.Forms.GroupBox();
            this.dgvContractTemprature = new System.Windows.Forms.DataGridView();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContractDetails.SuspendLayout();
            this.gbContracts.SuspendLayout();
            this.gbContractTemprature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractTemprature)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContractDetails
            // 
            this.gbContractDetails.Controls.Add(this.gbContractTemprature);
            this.gbContractDetails.Controls.Add(this.lblDetailsLoaner);
            this.gbContractDetails.Controls.Add(this.tbDetailsLoaner);
            this.gbContractDetails.Controls.Add(this.btnDetailsExportHtml);
            this.gbContractDetails.Controls.Add(this.btnDetailsExportTxt);
            this.gbContractDetails.Controls.Add(this.lblDateTill);
            this.gbContractDetails.Controls.Add(this.lblDateFrom);
            this.gbContractDetails.Controls.Add(this.dtpDetailsDateFrom);
            this.gbContractDetails.Controls.Add(this.dtpDetailsDateTill);
            this.gbContractDetails.Controls.Add(this.lbDetailsArticles);
            this.gbContractDetails.Controls.Add(this.lblDetailsArticles);
            this.gbContractDetails.Controls.Add(this.lblDetailsBoats);
            this.gbContractDetails.Controls.Add(this.lbDetailsBoats);
            this.gbContractDetails.Controls.Add(this.lblDetailsRenter);
            this.gbContractDetails.Controls.Add(this.tbDetailsRenter);
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
            // tbDetailsLoaner
            // 
            this.tbDetailsLoaner.Enabled = false;
            this.tbDetailsLoaner.Location = new System.Drawing.Point(379, 47);
            this.tbDetailsLoaner.Name = "tbDetailsLoaner";
            this.tbDetailsLoaner.Size = new System.Drawing.Size(264, 20);
            this.tbDetailsLoaner.TabIndex = 12;
            // 
            // btnDetailsExportHtml
            // 
            this.btnDetailsExportHtml.Enabled = false;
            this.btnDetailsExportHtml.Location = new System.Drawing.Point(379, 424);
            this.btnDetailsExportHtml.Name = "btnDetailsExportHtml";
            this.btnDetailsExportHtml.Size = new System.Drawing.Size(194, 23);
            this.btnDetailsExportHtml.TabIndex = 11;
            this.btnDetailsExportHtml.Text = "Exporteren naar html";
            this.btnDetailsExportHtml.UseVisualStyleBackColor = true;
            // 
            // btnDetailsExportTxt
            // 
            this.btnDetailsExportTxt.Enabled = false;
            this.btnDetailsExportTxt.Location = new System.Drawing.Point(379, 395);
            this.btnDetailsExportTxt.Name = "btnDetailsExportTxt";
            this.btnDetailsExportTxt.Size = new System.Drawing.Size(194, 23);
            this.btnDetailsExportTxt.TabIndex = 10;
            this.btnDetailsExportTxt.Text = "Exporteren naar tekst";
            this.btnDetailsExportTxt.UseVisualStyleBackColor = true;
            this.btnDetailsExportTxt.Click += new System.EventHandler(this.btnDetailsExportTxt_Click);
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
            // dtpDetailsDateFrom
            // 
            this.dtpDetailsDateFrom.Enabled = false;
            this.dtpDetailsDateFrom.Location = new System.Drawing.Point(24, 281);
            this.dtpDetailsDateFrom.Name = "dtpDetailsDateFrom";
            this.dtpDetailsDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDetailsDateFrom.TabIndex = 7;
            // 
            // dtpDetailsDateTill
            // 
            this.dtpDetailsDateTill.Enabled = false;
            this.dtpDetailsDateTill.Location = new System.Drawing.Point(379, 281);
            this.dtpDetailsDateTill.Name = "dtpDetailsDateTill";
            this.dtpDetailsDateTill.Size = new System.Drawing.Size(200, 20);
            this.dtpDetailsDateTill.TabIndex = 6;
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
            // tbDetailsRenter
            // 
            this.tbDetailsRenter.Enabled = false;
            this.tbDetailsRenter.Location = new System.Drawing.Point(24, 47);
            this.tbDetailsRenter.Name = "tbDetailsRenter";
            this.tbDetailsRenter.Size = new System.Drawing.Size(291, 20);
            this.tbDetailsRenter.TabIndex = 0;
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
            this.lbContracts.SelectedIndexChanged += new System.EventHandler(this.lbContracts_SelectedIndexChanged);
            // 
            // gbContractTemprature
            // 
            this.gbContractTemprature.Controls.Add(this.dgvContractTemprature);
            this.gbContractTemprature.Location = new System.Drawing.Point(22, 341);
            this.gbContractTemprature.Name = "gbContractTemprature";
            this.gbContractTemprature.Size = new System.Drawing.Size(224, 222);
            this.gbContractTemprature.TabIndex = 56;
            this.gbContractTemprature.TabStop = false;
            this.gbContractTemprature.Text = "Temperatuur";
            // 
            // dgvContractTemprature
            // 
            this.dgvContractTemprature.AllowUserToAddRows = false;
            this.dgvContractTemprature.AllowUserToDeleteRows = false;
            this.dgvContractTemprature.AllowUserToOrderColumns = true;
            this.dgvContractTemprature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractTemprature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay,
            this.colTemp});
            this.dgvContractTemprature.Enabled = false;
            this.dgvContractTemprature.Location = new System.Drawing.Point(6, 19);
            this.dgvContractTemprature.Name = "dgvContractTemprature";
            this.dgvContractTemprature.RowHeadersVisible = false;
            this.dgvContractTemprature.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractTemprature.Size = new System.Drawing.Size(206, 197);
            this.dgvContractTemprature.TabIndex = 0;
            // 
            // colDay
            // 
            this.colDay.HeaderText = "Dag";
            this.colDay.Name = "colDay";
            // 
            // colTemp
            // 
            this.colTemp.HeaderText = "Temperatuur";
            this.colTemp.Name = "colTemp";
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
            this.gbContractTemprature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractTemprature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContractDetails;
        private System.Windows.Forms.Label lblDetailsLoaner;
        private System.Windows.Forms.TextBox tbDetailsLoaner;
        private System.Windows.Forms.Button btnDetailsExportHtml;
        private System.Windows.Forms.Button btnDetailsExportTxt;
        private System.Windows.Forms.Label lblDateTill;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDetailsDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDetailsDateTill;
        private System.Windows.Forms.ListBox lbDetailsArticles;
        private System.Windows.Forms.Label lblDetailsArticles;
        private System.Windows.Forms.Label lblDetailsBoats;
        private System.Windows.Forms.ListBox lbDetailsBoats;
        private System.Windows.Forms.Label lblDetailsRenter;
        private System.Windows.Forms.TextBox tbDetailsRenter;
        private System.Windows.Forms.GroupBox gbContracts;
        private System.Windows.Forms.ListBox lbContracts;
        private System.Windows.Forms.GroupBox gbContractTemprature;
        private System.Windows.Forms.DataGridView dgvContractTemprature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
    }
}
