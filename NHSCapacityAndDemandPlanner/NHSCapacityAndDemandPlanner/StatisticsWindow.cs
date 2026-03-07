using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHSCapacityAndDemandPlanner
{
    public partial class StatisticsWindow : Form
    {
        public StatisticsWindow()
        {
            InitializeComponent();
        }
        private void StatisticsWindow_Load(object sender, EventArgs e)
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Hide();
        }
        public EventHandler SchedulerWindow_Load { get; private set; }
    }
}
