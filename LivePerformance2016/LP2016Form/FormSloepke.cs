using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            tpOverview.Controls.Add(new Overview());
        }
    }
}
