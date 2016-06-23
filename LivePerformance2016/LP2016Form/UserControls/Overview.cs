using System;
using System.Windows.Forms;
using LP2016Lib.Classes;
using LP2016Logic.Repositories;
using LP2016Logic.Utilities;
using static LP2016Logic.Utilities.TempratureUtil;

namespace LP2016Form.UserControls
{
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();
            PopulateContracts();
        }

        private void PopulateContracts()
        {
            try
            {
                lbContracts.Items.Clear();

                var contracts = FetchRepository.Instance.GetAllContracts();

                foreach (var contract in contracts)
                {
                    lbContracts.Items.Add(contract);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDetailsBoats.Items.Clear();
            lbDetailsArticles.Items.Clear();
            dgvContractTemprature.Rows.Clear();

            btnDetailsExportTxt.Enabled = lbContracts.SelectedItem != null;
            btnDetailsExportHtml.Enabled = lbContracts.SelectedItem != null;

            var contract = (Contract)lbContracts.SelectedItem;
            var boats = contract.Items.FindAll(x => x is Boat);
            var articles = contract.Items.FindAll(x => x is Article);

            tbDetailsLoaner.Text = "'t Sloepke";
            tbDetailsRenter.Text = contract.Renter.ToString();

            boats.ForEach(x => lbDetailsBoats.Items.Add(x));
            articles.ForEach(x => lbDetailsArticles.Items.Add(x));

            dtpDetailsDateFrom.Value = contract.StartDate;
            dtpDetailsDateTill.Value = contract.EndDate;

            var result = GetTempratureForContract(contract);

            foreach (var pair in result)
            {
                dgvContractTemprature.Rows.Add(pair.Key, pair.Value);
            }
        }

        private void btnDetailsExportTxt_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();

            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExportUtil.ExportContractToTxt(lbContracts.SelectedItem as Contract, dialog.FileName);
                    MessageBox.Show("Succesvol opgeslagen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
