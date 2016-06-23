using System;
using System.Linq;
using System.Windows.Forms;
using LP2016Lib.Classes;
using LP2016Lib.Enums;
using LP2016Logic.Repositories;

namespace LP2016Form.UserControls
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            foreach (BoatType type in Enum.GetValues(typeof (BoatType)))
            {
                cbContractBoatType.Items.Add(type);
            }
            cbContractBoatType.SelectedIndex = 0;

            RefreshAll();
        }

        private void RefreshAll()
        {
            PopulateRenterComboBox();
            PopulateArticleComboBox();
            PopulateBoatComboBox();
        }

        /// <summary>
        /// Populates the combobox for the renters.
        /// </summary>
        private void PopulateRenterComboBox()
        {
            try
            {
                cbContractRenter.Items.Clear();

                var renters = FetchRepository.Instance.GetAllRenters();

                foreach (var renter in renters)
                {
                    cbContractRenter.Items.Add(renter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateBoatComboBox()
        {
            try
            {
                cbContractBoatName.SelectedItem = null;
                cbContractBoatName.Items.Clear();
                cbContractBoatName.DisplayMember = "Name";

                var boats =
                    FetchRepository.Instance.GetAllBoats()
                        .FindAll(x => x.Type == (BoatType) cbContractBoatType.SelectedItem);

                foreach (var boat in boats)
                {
                    cbContractBoatName.Items.Add(boat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateBoatComboBox(object sender, EventArgs e) => PopulateBoatComboBox();

        private void PopulateArticleComboBox()
        {
            try
            {
                cbContractArticle.Items.Clear();

                var articles = FetchRepository.Instance.GetAllArticles();

                foreach (var article in articles)
                {
                    cbContractArticle.Items.Add(article);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAddUser()
        {
            tbName.Text = "";
            tbEmail.Text = "";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                SaveRepository.Instance.SaveRenter(tbName.Text, tbEmail.Text);

                PopulateRenterComboBox();

                MessageBox.Show($"{tbName.Text} is toegevoegd!");
                ClearAddUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContractBoatAdd_Click(object sender, EventArgs e)
        {
            if (!lbContractBoats.Items.Contains(cbContractBoatName.SelectedItem))
                lbContractBoats.Items.Add(cbContractBoatName.SelectedItem);
        }

        private void btnContractArticleAdd_Click(object sender, EventArgs e)
        {
            if (!lbContractArticles.Items.Contains(cbContractArticle.SelectedItem))
                lbContractArticles.Items.Add(cbContractArticle.SelectedItem);
        }

        private void dtpContractDateFrom_ValueChanged(object sender, EventArgs e) => dtpContractDateTill.MinDate = dtpContractDateFrom.Value;

        private void dtpContractDateTill_ValueChanged(object sender, EventArgs e) => dtpContractDateFrom.MaxDate = dtpContractDateTill.Value;

        private void btnContractBoatRemove_Click(object sender, EventArgs e) =>
            lbContractBoats.Items.Remove(lbContractBoats.SelectedItem);

        private void lbContractBoats_SelectedIndexChanged(object sender, EventArgs e) =>
            btnContractBoatRemove.Enabled = lbContractBoats.SelectedItem != null;

        private void btnContractArticleRemove_Click(object sender, EventArgs e) =>
            lbContractArticles.Items.Remove(lbContractArticles.SelectedItem);

        private void lbContractArticles_SelectedIndexChanged(object sender, EventArgs e) =>
            btnContractArticleRemove.Enabled = lbContractArticles.SelectedItem != null;

        private void btnContractSave_Click(object sender, EventArgs e)
        {
            try
            {
                var startDate = dtpContractDateFrom.Value;
                var endDate = dtpContractDateTill.Value;
                var renter = (Renter)cbContractRenter.SelectedItem;
                var boats = lbContractBoats.Items.Cast<Boat>().ToList();
                var articles = lbContractArticles.Items.Cast<Article>().ToList();

                SaveRepository.Instance.SaveContract(startDate, endDate, renter, boats, articles);
                MessageBox.Show($"Het contract met {renter.Name} is succesvol toegevoegd!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
