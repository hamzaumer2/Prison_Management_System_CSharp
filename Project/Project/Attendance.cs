using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Attendance : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;

        public Attendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
            listView1.Items.Clear();
            listView1.CheckBoxes = true;

            cmd = new SqlCommand("select * from [dbo].[prisoner]", cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Attendance DB Shown");
            }
            rdr.Close();
            int check = 0;
            foreach (var i in New_Prisoner.PrisonerID)
            {
                if (New_Prisoner.PrisonerID[check] != 0)    
                {
                    string[] show = new string[] { New_Prisoner.PrisonerID[check].ToString(), New_Prisoner.PrisonerFname[check], New_Prisoner.PrisonTime[check].ToString()};
                    ListViewItem item = new ListViewItem(show);
                    listView1.Items.Add(item);
                    this.listView1.View = View.Details;
                }
                check++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
            int check = 0;
            foreach (var i in New_Prisoner.PrisonerID)
            {
                if (New_Prisoner.PrisonerID[check] != 0)
                {
                    if (listView1.CheckBoxes == true)
                    {
                        int pri_time = New_Prisoner.PrisonTime[check] -1;
                        cmd = new SqlCommand("update [dbo].[prisoner] set PrisonTime = @pt where Id = @pid", cn);
                        cmd.Parameters.AddWithValue("pt", pri_time);
                        cmd.Parameters.AddWithValue("pid", New_Prisoner.PrisonerID[check]);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Attendance Marked");

                        New_Prisoner.PrisonTime[check] -= 1;

                        break;
                    }
                }
                check++;
            }
            this.Hide();

            After_Login afterLogin = new After_Login();
            afterLogin.Closed += (s, args) => this.Close();
            afterLogin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            After_Login afterLogin = new After_Login();
            afterLogin.Closed += (s, args) => this.Close();
            afterLogin.Show();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }
    }
}
