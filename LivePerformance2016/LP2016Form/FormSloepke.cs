using System.Windows.Forms;
using LP2016Form.UserControls;

namespace LP2016Form
{
    public partial class FormSloepke : Form
    {
        public FormSloepke()
        {
            InitializeComponent();

            tpMain.Controls.Add(new MainPage());
        }

        private void tcMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "tpMain":
                    tpMain.Controls.Add(new MainPage());
                    break;
                case "tpOverview":
                    tpOverview.Controls.Add(new Overview());
                    break;
            }
        }

        private void tcMain_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            e.TabPage.Controls.Clear();
        }
    }
}
