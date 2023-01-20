using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/hamza-umer-farooq/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/hamzaumer2",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/hadi-abbas-2a16b6239",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            LoginPage mainPage = new LoginPage();
            mainPage.Closed += (s, args) => this.Close();
            mainPage.Show();
        }


        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/haroon-abdullah-jul192001/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
