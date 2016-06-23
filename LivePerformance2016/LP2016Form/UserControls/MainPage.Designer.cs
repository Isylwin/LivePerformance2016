namespace LP2016Form.UserControls
{
    partial class MainPage
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
            this.lblContractBoatName = new System.Windows.Forms.Label();
            this.cbContractBoatType = new System.Windows.Forms.ComboBox();
            this.gbContractTemprature = new System.Windows.Forms.GroupBox();
            this.dgvContractTemprature = new System.Windows.Forms.DataGridView();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContractArticleAdd = new System.Windows.Forms.Button();
            this.btnContractBoatAdd = new System.Windows.Forms.Button();
            this.cbContractArticle = new System.Windows.Forms.ComboBox();
            this.cbContractBoatName = new System.Windows.Forms.ComboBox();
            this.lblContractArticle = new System.Windows.Forms.Label();
            this.lblContractBoatType = new System.Windows.Forms.Label();
            this.cbContractRenter = new System.Windows.Forms.ComboBox();
            this.gbContractArticles = new System.Windows.Forms.GroupBox();
            this.btnContractArticleRemove = new System.Windows.Forms.Button();
            this.btnContractBoatRemove = new System.Windows.Forms.Button();
            this.lbContractBoats = new System.Windows.Forms.ListBox();
            this.lblContractArticlesBoats = new System.Windows.Forms.Label();
            this.lbContractArticles = new System.Windows.Forms.ListBox();
            this.lblContractArticlesArticle = new System.Windows.Forms.Label();
            this.lblContractLoaner = new System.Windows.Forms.Label();
            this.tbContractLoaner = new System.Windows.Forms.TextBox();
            this.btnContractSave = new System.Windows.Forms.Button();
            this.lblContractDateTill = new System.Windows.Forms.Label();
            this.lblContractDateFrom = new System.Windows.Forms.Label();
            this.dtpContractDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpContractDateTill = new System.Windows.Forms.DateTimePicker();
            this.lblContractRenter = new System.Windows.Forms.Label();
            this.gbCalculator = new System.Windows.Forms.GroupBox();
            this.lblContractResult = new System.Windows.Forms.Label();
            this.lblContractLakes = new System.Windows.Forms.Label();
            this.chbContractIJselmeer = new System.Windows.Forms.CheckBox();
            this.chbContractNorthSea = new System.Windows.Forms.CheckBox();
            this.lblContractBudget = new System.Windows.Forms.Label();
            this.nudContractBudget = new System.Windows.Forms.NumericUpDown();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbContractAddUser = new System.Windows.Forms.GroupBox();
            this.gbContract = new System.Windows.Forms.GroupBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.gbContractTemprature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractTemprature)).BeginInit();
            this.gbContractArticles.SuspendLayout();
            this.gbCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContractBudget)).BeginInit();
            this.gbContractAddUser.SuspendLayout();
            this.gbContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContractBoatName
            // 
            this.lblContractBoatName.AutoSize = true;
            this.lblContractBoatName.Location = new System.Drawing.Point(11, 108);
            this.lblContractBoatName.Name = "lblContractBoatName";
            this.lblContractBoatName.Size = new System.Drawing.Size(61, 13);
            this.lblContractBoatName.TabIndex = 57;
            this.lblContractBoatName.Text = "Boot naam:";
            // 
            // cbContractBoatType
            // 
            this.cbContractBoatType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbContractBoatType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContractBoatType.FormattingEnabled = true;
            this.cbContractBoatType.Location = new System.Drawing.Point(14, 84);
            this.cbContractBoatType.Name = "cbContractBoatType";
            this.cbContractBoatType.Size = new System.Drawing.Size(251, 21);
            this.cbContractBoatType.TabIndex = 56;
            this.cbContractBoatType.SelectedIndexChanged += new System.EventHandler(this.PopulateBoatComboBox);
            // 
            // gbContractTemprature
            // 
            this.gbContractTemprature.Controls.Add(this.dgvContractTemprature);
            this.gbContractTemprature.Location = new System.Drawing.Point(8, 256);
            this.gbContractTemprature.Name = "gbContractTemprature";
            this.gbContractTemprature.Size = new System.Drawing.Size(293, 222);
            this.gbContractTemprature.TabIndex = 55;
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
            this.dgvContractTemprature.Location = new System.Drawing.Point(6, 19);
            this.dgvContractTemprature.Name = "dgvContractTemprature";
            this.dgvContractTemprature.Size = new System.Drawing.Size(281, 197);
            this.dgvContractTemprature.TabIndex = 0;
            // 
            // colDay
            // 
            this.colDay.HeaderText = "Dag";
            this.colDay.Name = "colDay";
            // 
            // colTemp
            // 
            this.colTemp.HeaderText = "Tempratuur";
            this.colTemp.Name = "colTemp";
            // 
            // btnContractArticleAdd
            // 
            this.btnContractArticleAdd.Location = new System.Drawing.Point(345, 157);
            this.btnContractArticleAdd.Name = "btnContractArticleAdd";
            this.btnContractArticleAdd.Size = new System.Drawing.Size(107, 23);
            this.btnContractArticleAdd.TabIndex = 54;
            this.btnContractArticleAdd.Text = "Voeg toe";
            this.btnContractArticleAdd.UseVisualStyleBackColor = true;
            this.btnContractArticleAdd.Click += new System.EventHandler(this.btnContractArticleAdd_Click);
            // 
            // btnContractBoatAdd
            // 
            this.btnContractBoatAdd.Location = new System.Drawing.Point(11, 157);
            this.btnContractBoatAdd.Name = "btnContractBoatAdd";
            this.btnContractBoatAdd.Size = new System.Drawing.Size(107, 23);
            this.btnContractBoatAdd.TabIndex = 53;
            this.btnContractBoatAdd.Text = "Voeg toe";
            this.btnContractBoatAdd.UseVisualStyleBackColor = true;
            this.btnContractBoatAdd.Click += new System.EventHandler(this.btnContractBoatAdd_Click);
            // 
            // cbContractArticle
            // 
            this.cbContractArticle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbContractArticle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContractArticle.FormattingEnabled = true;
            this.cbContractArticle.Location = new System.Drawing.Point(345, 84);
            this.cbContractArticle.Name = "cbContractArticle";
            this.cbContractArticle.Size = new System.Drawing.Size(264, 21);
            this.cbContractArticle.TabIndex = 52;
            // 
            // cbContractBoatName
            // 
            this.cbContractBoatName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbContractBoatName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContractBoatName.FormattingEnabled = true;
            this.cbContractBoatName.Location = new System.Drawing.Point(14, 123);
            this.cbContractBoatName.Name = "cbContractBoatName";
            this.cbContractBoatName.Size = new System.Drawing.Size(251, 21);
            this.cbContractBoatName.TabIndex = 51;
            // 
            // lblContractArticle
            // 
            this.lblContractArticle.AutoSize = true;
            this.lblContractArticle.Location = new System.Drawing.Point(342, 68);
            this.lblContractArticle.Name = "lblContractArticle";
            this.lblContractArticle.Size = new System.Drawing.Size(39, 13);
            this.lblContractArticle.TabIndex = 50;
            this.lblContractArticle.Text = "Artikel:";
            // 
            // lblContractBoatType
            // 
            this.lblContractBoatType.AutoSize = true;
            this.lblContractBoatType.Location = new System.Drawing.Point(11, 68);
            this.lblContractBoatType.Name = "lblContractBoatType";
            this.lblContractBoatType.Size = new System.Drawing.Size(55, 13);
            this.lblContractBoatType.TabIndex = 49;
            this.lblContractBoatType.Text = "Boot type:";
            // 
            // cbContractRenter
            // 
            this.cbContractRenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbContractRenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContractRenter.FormattingEnabled = true;
            this.cbContractRenter.Location = new System.Drawing.Point(14, 35);
            this.cbContractRenter.Name = "cbContractRenter";
            this.cbContractRenter.Size = new System.Drawing.Size(251, 21);
            this.cbContractRenter.TabIndex = 48;
            // 
            // gbContractArticles
            // 
            this.gbContractArticles.Controls.Add(this.btnContractArticleRemove);
            this.gbContractArticles.Controls.Add(this.btnContractBoatRemove);
            this.gbContractArticles.Controls.Add(this.lbContractBoats);
            this.gbContractArticles.Controls.Add(this.lblContractArticlesBoats);
            this.gbContractArticles.Controls.Add(this.lbContractArticles);
            this.gbContractArticles.Controls.Add(this.lblContractArticlesArticle);
            this.gbContractArticles.Location = new System.Drawing.Point(659, 13);
            this.gbContractArticles.Name = "gbContractArticles";
            this.gbContractArticles.Size = new System.Drawing.Size(356, 408);
            this.gbContractArticles.TabIndex = 47;
            this.gbContractArticles.TabStop = false;
            this.gbContractArticles.Text = "Artikelen";
            // 
            // btnContractArticleRemove
            // 
            this.btnContractArticleRemove.Enabled = false;
            this.btnContractArticleRemove.Location = new System.Drawing.Point(20, 358);
            this.btnContractArticleRemove.Name = "btnContractArticleRemove";
            this.btnContractArticleRemove.Size = new System.Drawing.Size(140, 23);
            this.btnContractArticleRemove.TabIndex = 21;
            this.btnContractArticleRemove.Text = "Verwijder";
            this.btnContractArticleRemove.UseVisualStyleBackColor = true;
            this.btnContractArticleRemove.Click += new System.EventHandler(this.btnContractArticleRemove_Click);
            // 
            // btnContractBoatRemove
            // 
            this.btnContractBoatRemove.Enabled = false;
            this.btnContractBoatRemove.Location = new System.Drawing.Point(20, 166);
            this.btnContractBoatRemove.Name = "btnContractBoatRemove";
            this.btnContractBoatRemove.Size = new System.Drawing.Size(140, 23);
            this.btnContractBoatRemove.TabIndex = 20;
            this.btnContractBoatRemove.Text = "Verwijder";
            this.btnContractBoatRemove.UseVisualStyleBackColor = true;
            this.btnContractBoatRemove.Click += new System.EventHandler(this.btnContractBoatRemove_Click);
            // 
            // lbContractBoats
            // 
            this.lbContractBoats.FormattingEnabled = true;
            this.lbContractBoats.Location = new System.Drawing.Point(20, 39);
            this.lbContractBoats.Name = "lbContractBoats";
            this.lbContractBoats.Size = new System.Drawing.Size(317, 121);
            this.lbContractBoats.TabIndex = 16;
            this.lbContractBoats.SelectedIndexChanged += new System.EventHandler(this.lbContractBoats_SelectedIndexChanged);
            // 
            // lblContractArticlesBoats
            // 
            this.lblContractArticlesBoats.AutoSize = true;
            this.lblContractArticlesBoats.Location = new System.Drawing.Point(17, 23);
            this.lblContractArticlesBoats.Name = "lblContractArticlesBoats";
            this.lblContractArticlesBoats.Size = new System.Drawing.Size(38, 13);
            this.lblContractArticlesBoats.TabIndex = 17;
            this.lblContractArticlesBoats.Text = "Boten:";
            // 
            // lbContractArticles
            // 
            this.lbContractArticles.FormattingEnabled = true;
            this.lbContractArticles.Location = new System.Drawing.Point(20, 231);
            this.lbContractArticles.Name = "lbContractArticles";
            this.lbContractArticles.Size = new System.Drawing.Size(317, 121);
            this.lbContractArticles.TabIndex = 19;
            this.lbContractArticles.SelectedIndexChanged += new System.EventHandler(this.lbContractArticles_SelectedIndexChanged);
            // 
            // lblContractArticlesArticle
            // 
            this.lblContractArticlesArticle.AutoSize = true;
            this.lblContractArticlesArticle.Location = new System.Drawing.Point(17, 213);
            this.lblContractArticlesArticle.Name = "lblContractArticlesArticle";
            this.lblContractArticlesArticle.Size = new System.Drawing.Size(109, 13);
            this.lblContractArticlesArticle.TabIndex = 18;
            this.lblContractArticlesArticle.Text = "Bijkomende Artikelen:";
            // 
            // lblContractLoaner
            // 
            this.lblContractLoaner.AutoSize = true;
            this.lblContractLoaner.Location = new System.Drawing.Point(342, 19);
            this.lblContractLoaner.Name = "lblContractLoaner";
            this.lblContractLoaner.Size = new System.Drawing.Size(62, 13);
            this.lblContractLoaner.TabIndex = 46;
            this.lblContractLoaner.Text = "Verhuurder:";
            // 
            // tbContractLoaner
            // 
            this.tbContractLoaner.Enabled = false;
            this.tbContractLoaner.Location = new System.Drawing.Point(345, 35);
            this.tbContractLoaner.Name = "tbContractLoaner";
            this.tbContractLoaner.Size = new System.Drawing.Size(264, 20);
            this.tbContractLoaner.TabIndex = 45;
            this.tbContractLoaner.Text = "\'t Sloepke";
            // 
            // btnContractSave
            // 
            this.btnContractSave.Location = new System.Drawing.Point(345, 275);
            this.btnContractSave.Name = "btnContractSave";
            this.btnContractSave.Size = new System.Drawing.Size(194, 23);
            this.btnContractSave.TabIndex = 44;
            this.btnContractSave.Text = "Contract opslaan";
            this.btnContractSave.UseVisualStyleBackColor = true;
            this.btnContractSave.Click += new System.EventHandler(this.btnContractSave_Click);
            // 
            // lblContractDateTill
            // 
            this.lblContractDateTill.AutoSize = true;
            this.lblContractDateTill.Location = new System.Drawing.Point(342, 196);
            this.lblContractDateTill.Name = "lblContractDateTill";
            this.lblContractDateTill.Size = new System.Drawing.Size(56, 13);
            this.lblContractDateTill.TabIndex = 43;
            this.lblContractDateTill.Text = "Datum tot:";
            // 
            // lblContractDateFrom
            // 
            this.lblContractDateFrom.AutoSize = true;
            this.lblContractDateFrom.Location = new System.Drawing.Point(11, 196);
            this.lblContractDateFrom.Name = "lblContractDateFrom";
            this.lblContractDateFrom.Size = new System.Drawing.Size(62, 13);
            this.lblContractDateFrom.TabIndex = 42;
            this.lblContractDateFrom.Text = "Datum van:";
            // 
            // dtpContractDateFrom
            // 
            this.dtpContractDateFrom.Location = new System.Drawing.Point(14, 215);
            this.dtpContractDateFrom.Name = "dtpContractDateFrom";
            this.dtpContractDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpContractDateFrom.TabIndex = 41;
            this.dtpContractDateFrom.ValueChanged += new System.EventHandler(this.dtpContractDateFrom_ValueChanged);
            // 
            // dtpContractDateTill
            // 
            this.dtpContractDateTill.Location = new System.Drawing.Point(345, 215);
            this.dtpContractDateTill.Name = "dtpContractDateTill";
            this.dtpContractDateTill.Size = new System.Drawing.Size(200, 20);
            this.dtpContractDateTill.TabIndex = 40;
            this.dtpContractDateTill.ValueChanged += new System.EventHandler(this.dtpContractDateTill_ValueChanged);
            // 
            // lblContractRenter
            // 
            this.lblContractRenter.AutoSize = true;
            this.lblContractRenter.Location = new System.Drawing.Point(11, 20);
            this.lblContractRenter.Name = "lblContractRenter";
            this.lblContractRenter.Size = new System.Drawing.Size(48, 13);
            this.lblContractRenter.TabIndex = 39;
            this.lblContractRenter.Text = "Huurder:";
            // 
            // gbCalculator
            // 
            this.gbCalculator.Controls.Add(this.btnCalculator);
            this.gbCalculator.Controls.Add(this.lblContractResult);
            this.gbCalculator.Controls.Add(this.lblContractLakes);
            this.gbCalculator.Controls.Add(this.chbContractIJselmeer);
            this.gbCalculator.Controls.Add(this.chbContractNorthSea);
            this.gbCalculator.Controls.Add(this.lblContractBudget);
            this.gbCalculator.Controls.Add(this.nudContractBudget);
            this.gbCalculator.Location = new System.Drawing.Point(659, 441);
            this.gbCalculator.Name = "gbCalculator";
            this.gbCalculator.Size = new System.Drawing.Size(356, 193);
            this.gbCalculator.TabIndex = 58;
            this.gbCalculator.TabStop = false;
            this.gbCalculator.Text = "Calculator";
            // 
            // lblContractResult
            // 
            this.lblContractResult.AutoSize = true;
            this.lblContractResult.Location = new System.Drawing.Point(113, 160);
            this.lblContractResult.Name = "lblContractResult";
            this.lblContractResult.Size = new System.Drawing.Size(13, 13);
            this.lblContractResult.TabIndex = 63;
            this.lblContractResult.Text = "5";
            // 
            // lblContractLakes
            // 
            this.lblContractLakes.AutoSize = true;
            this.lblContractLakes.Location = new System.Drawing.Point(17, 160);
            this.lblContractLakes.Name = "lblContractLakes";
            this.lblContractLakes.Size = new System.Drawing.Size(70, 13);
            this.lblContractLakes.TabIndex = 62;
            this.lblContractLakes.Text = "Friese meren:";
            // 
            // chbContractIJselmeer
            // 
            this.chbContractIJselmeer.AutoSize = true;
            this.chbContractIJselmeer.Location = new System.Drawing.Point(29, 92);
            this.chbContractIJselmeer.Name = "chbContractIJselmeer";
            this.chbContractIJselmeer.Size = new System.Drawing.Size(70, 17);
            this.chbContractIJselmeer.TabIndex = 61;
            this.chbContractIJselmeer.Text = "IJselmeer";
            this.chbContractIJselmeer.UseVisualStyleBackColor = true;
            // 
            // chbContractNorthSea
            // 
            this.chbContractNorthSea.AutoSize = true;
            this.chbContractNorthSea.Location = new System.Drawing.Point(29, 69);
            this.chbContractNorthSea.Name = "chbContractNorthSea";
            this.chbContractNorthSea.Size = new System.Drawing.Size(72, 17);
            this.chbContractNorthSea.TabIndex = 60;
            this.chbContractNorthSea.Text = "Noordzee";
            this.chbContractNorthSea.UseVisualStyleBackColor = true;
            // 
            // lblContractBudget
            // 
            this.lblContractBudget.AutoSize = true;
            this.lblContractBudget.Location = new System.Drawing.Point(26, 31);
            this.lblContractBudget.Name = "lblContractBudget";
            this.lblContractBudget.Size = new System.Drawing.Size(44, 13);
            this.lblContractBudget.TabIndex = 59;
            this.lblContractBudget.Text = "Budget:";
            // 
            // nudContractBudget
            // 
            this.nudContractBudget.Location = new System.Drawing.Point(85, 29);
            this.nudContractBudget.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudContractBudget.Name = "nudContractBudget";
            this.nudContractBudget.Size = new System.Drawing.Size(149, 20);
            this.nudContractBudget.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(59, 90);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(228, 23);
            this.btnAddUser.TabIndex = 63;
            this.btnAddUser.Text = "Voeg Toe";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.AcceptsReturn = true;
            this.tbEmail.Location = new System.Drawing.Point(59, 64);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 20);
            this.tbEmail.TabIndex = 62;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(59, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 20);
            this.tbName.TabIndex = 61;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 60;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 59;
            this.lblName.Text = "Naam:";
            // 
            // gbContractAddUser
            // 
            this.gbContractAddUser.Controls.Add(this.tbEmail);
            this.gbContractAddUser.Controls.Add(this.btnAddUser);
            this.gbContractAddUser.Controls.Add(this.lblName);
            this.gbContractAddUser.Controls.Add(this.lblEmail);
            this.gbContractAddUser.Controls.Add(this.tbName);
            this.gbContractAddUser.Location = new System.Drawing.Point(18, 13);
            this.gbContractAddUser.Name = "gbContractAddUser";
            this.gbContractAddUser.Size = new System.Drawing.Size(293, 128);
            this.gbContractAddUser.TabIndex = 64;
            this.gbContractAddUser.TabStop = false;
            this.gbContractAddUser.Text = "Huurder toevoegen";
            // 
            // gbContract
            // 
            this.gbContract.Controls.Add(this.cbContractRenter);
            this.gbContract.Controls.Add(this.lblContractRenter);
            this.gbContract.Controls.Add(this.dtpContractDateTill);
            this.gbContract.Controls.Add(this.lblContractBoatName);
            this.gbContract.Controls.Add(this.dtpContractDateFrom);
            this.gbContract.Controls.Add(this.cbContractBoatType);
            this.gbContract.Controls.Add(this.lblContractDateFrom);
            this.gbContract.Controls.Add(this.gbContractTemprature);
            this.gbContract.Controls.Add(this.lblContractDateTill);
            this.gbContract.Controls.Add(this.btnContractArticleAdd);
            this.gbContract.Controls.Add(this.btnContractSave);
            this.gbContract.Controls.Add(this.btnContractBoatAdd);
            this.gbContract.Controls.Add(this.tbContractLoaner);
            this.gbContract.Controls.Add(this.cbContractArticle);
            this.gbContract.Controls.Add(this.lblContractLoaner);
            this.gbContract.Controls.Add(this.cbContractBoatName);
            this.gbContract.Controls.Add(this.lblContractBoatType);
            this.gbContract.Controls.Add(this.lblContractArticle);
            this.gbContract.Location = new System.Drawing.Point(18, 156);
            this.gbContract.Name = "gbContract";
            this.gbContract.Size = new System.Drawing.Size(620, 488);
            this.gbContract.TabIndex = 65;
            this.gbContract.TabStop = false;
            this.gbContract.Text = "Contract";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(216, 155);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(121, 23);
            this.btnCalculator.TabIndex = 64;
            this.btnCalculator.Text = "Bereken";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbContract);
            this.Controls.Add(this.gbContractAddUser);
            this.Controls.Add(this.gbCalculator);
            this.Controls.Add(this.gbContractArticles);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1060, 659);
            this.gbContractTemprature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractTemprature)).EndInit();
            this.gbContractArticles.ResumeLayout(false);
            this.gbContractArticles.PerformLayout();
            this.gbCalculator.ResumeLayout(false);
            this.gbCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContractBudget)).EndInit();
            this.gbContractAddUser.ResumeLayout(false);
            this.gbContractAddUser.PerformLayout();
            this.gbContract.ResumeLayout(false);
            this.gbContract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContractBoatName;
        private System.Windows.Forms.ComboBox cbContractBoatType;
        private System.Windows.Forms.GroupBox gbContractTemprature;
        private System.Windows.Forms.DataGridView dgvContractTemprature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.Button btnContractArticleAdd;
        private System.Windows.Forms.Button btnContractBoatAdd;
        private System.Windows.Forms.ComboBox cbContractArticle;
        private System.Windows.Forms.ComboBox cbContractBoatName;
        private System.Windows.Forms.Label lblContractArticle;
        private System.Windows.Forms.Label lblContractBoatType;
        private System.Windows.Forms.ComboBox cbContractRenter;
        private System.Windows.Forms.GroupBox gbContractArticles;
        private System.Windows.Forms.Button btnContractArticleRemove;
        private System.Windows.Forms.Button btnContractBoatRemove;
        private System.Windows.Forms.ListBox lbContractBoats;
        private System.Windows.Forms.Label lblContractArticlesBoats;
        private System.Windows.Forms.ListBox lbContractArticles;
        private System.Windows.Forms.Label lblContractArticlesArticle;
        private System.Windows.Forms.Label lblContractLoaner;
        private System.Windows.Forms.TextBox tbContractLoaner;
        private System.Windows.Forms.Button btnContractSave;
        private System.Windows.Forms.Label lblContractDateTill;
        private System.Windows.Forms.Label lblContractDateFrom;
        private System.Windows.Forms.DateTimePicker dtpContractDateFrom;
        private System.Windows.Forms.DateTimePicker dtpContractDateTill;
        private System.Windows.Forms.Label lblContractRenter;
        private System.Windows.Forms.GroupBox gbCalculator;
        private System.Windows.Forms.Label lblContractResult;
        private System.Windows.Forms.Label lblContractLakes;
        private System.Windows.Forms.CheckBox chbContractIJselmeer;
        private System.Windows.Forms.CheckBox chbContractNorthSea;
        private System.Windows.Forms.Label lblContractBudget;
        private System.Windows.Forms.NumericUpDown nudContractBudget;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbContractAddUser;
        private System.Windows.Forms.GroupBox gbContract;
        private System.Windows.Forms.Button btnCalculator;
    }
}
