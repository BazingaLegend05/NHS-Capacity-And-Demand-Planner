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
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
            panel1.Visible = false; // Start with the panel hidden
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Opens scheduler window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SchedulerWindow schedulerWindow = new SchedulerWindow();
            schedulerWindow.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible; // Toggle visibility of the panel
        }
        /// <summary>
        /// ====================================================================================================================================================
        /// I want to make this so that when the button 3 is clicked, it shows the panel and it takes the size of the text that is inside of it.
        /// If there are no notifications, there will be text in the pannel saying no notifications.
        /// This will be set up with an alert system that will be on every window as will the notification centre. It does not need to be done until later tho.
        /// ===================================================================================================================================================
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Opens the Statistics window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            StatisticsWindow statWindow = new StatisticsWindow();
            statWindow.Show();
            this.Hide();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
