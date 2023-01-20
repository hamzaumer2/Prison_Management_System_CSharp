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
    public partial class Release : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        public Release()
        {
            InitializeComponent();
        }

        private int temp_PrisonerID;
        private bool isNumeric;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int n;
                isNumeric = int.TryParse(textBox1.Text, out n);
                if (isNumeric)
                {
                    label21.Text = "";
                    temp_PrisonerID = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    label21.ForeColor = Color.Red;
                    label21.Text = "Enter a Valid ID Please!!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label21.ForeColor = Color.Red;


                label21.Text = "Enter Prisoner ID";
            }

            else
            {
                int check = 0;
                foreach (var i in New_Prisoner.PrisonerID)
                {
                    if (New_Prisoner.PrisonerID[check] == Convert.ToInt32(textBox1.Text))
                    {
                        if (New_Prisoner.PrisonTime[check] <= 0)
                        {
                            cmd = new SqlCommand("delete" +
                                                 " from [dbo].[prisoner] where Id = @pid", cn);
                            cmd.Parameters.AddWithValue("pid", textBox1.Text);
                            cmd.ExecuteNonQuery();
                            New_Prisoner.PrisonerID[check] = 0;
                            New_Prisoner.PrisonerFname[check] = "";
                            New_Prisoner.PrisonerLName[check] = "";
                            New_Prisoner.PrisonerCNIC[check] = 0;
                            New_Prisoner.PrisonerPhone[check] = 0;
                            New_Prisoner.PrisonerCrime[check] = "";
                            New_Prisoner.PrisonTime[check] = 0;
                            MessageBox.Show("Prisoner Released Successfully.");
                            this.Hide();

                            After_Login afterLogin = new After_Login();
                            afterLogin.Closed += (s, args) => this.Close();
                            afterLogin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Prisoner Not Eligible for Release");
                        }

                    }

                    check++;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
            if (textBox1.Text == "")
            {
                label21.ForeColor = Color.Red;


                label21.Text = "Enter Prisoner ID";
            }

            else
            {
                cmd = new SqlCommand("select * from [dbo].[prisoner] where Id = @pid",cn);
                cmd.Parameters.AddWithValue("pid", textBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("RELEASE CHECK SUCCESSFUL");
                    dr.Close();
                }
                dr.Close();


                int check = 0;
                foreach (var i in New_Prisoner.PrisonerID)
                {
                    if (New_Prisoner.PrisonerID[check] == Convert.ToInt32(textBox1.Text))
                    {
                        label8.Text = New_Prisoner.PrisonerID[check].ToString();
                        label4.Text = New_Prisoner.PrisonerFname[check];
                        label6.Text = New_Prisoner.PrisonerLName[check];
                        label10.Text = New_Prisoner.PrisonerCNIC[check].ToString();
                        label14.Text = New_Prisoner.PrisonerPhone[check].ToString();
                        label16.Text = New_Prisoner.PrisonerCrime[check];
                        label18.Text = New_Prisoner.PrisonTime[check].ToString();

                        if (New_Prisoner.PrisonTime[check] <= 0)
                        {
                            label20.ForeColor = Color.Blue;
                            label20.Text = "YES";
                        }
                        else
                        {
                            label20.ForeColor = Color.Red;
                            label20.Text = "NO";
                        }

                    }

                    check++;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            After_Login afterLogin = new After_Login();
            afterLogin.Closed += (s, args) => this.Close();
            afterLogin.Show();
        }

        private void Release_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }
    }
}
