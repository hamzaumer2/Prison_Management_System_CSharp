using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class After_Login : Form
    {
        public After_Login()
        {
            InitializeComponent();
        }

        private void After_Login_Load(object sender, EventArgs e)
        {
            label2.Text = LoginPage.enteredusername;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Attendance attendance = new Attendance();
            attendance.Closed += (s, args) => this.Close();
            attendance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            New_Prisoner newPrisoner = new New_Prisoner();
            newPrisoner.Closed += (s, args) => this.Close();
            newPrisoner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewSearch viewSearch = new ViewSearch();
            viewSearch.Closed += (s, args) => this.Close();
            viewSearch.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Release bailRelease = new Release();
            bailRelease.Closed += (s, args) => this.Close();
            bailRelease.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginPage mainPage = new LoginPage();
            mainPage.Closed += (s, args) => this.Close();
            mainPage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();


            if(label2.Text == "admin")
            {
                Approve_Bail approveBail = new Approve_Bail();
                approveBail.Closed += (s, args) => this.Close();
                approveBail.Show();
            }
            else
            {
                Request_Bail requestBail = new Request_Bail();
                requestBail.Closed += (s, args) => this.Close();
                requestBail.Show();
            }
        }
    }
}
