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

namespace Project
{
    public partial class ViewSearch : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        private string searchby;
        public ViewSearch()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                {
                    searchby = "ID";
                    break;
                }
                case 1:
                {
                    searchby = "Name";
                    break;
                }
                case 2:
                {
                    searchby = "CNIC";
                    break;
                }
                case 3:
                {
                    searchby = "Phone";
                    break;
                }
                case 4:
                {
                    searchby = "Crime";
                    break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();

            if (comboBox1.Text == "Search By:" || textBox1.Text == "")
            {
                if (comboBox1.Text == "Search By:")
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Enter Search By!";
                }

                if (textBox1.Text == "")
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Enter Keyword to Search";
                }

            }

            else
            {
                cmd = new SqlCommand("select * from [dbo].[prisoner] where Id = @id OR FName = @fn OR LName = @ln OR Crime = @crme OR CNIC = @nic OR Phone = @number", cn);
                cmd.Parameters.AddWithValue("id", textBox1.Text);
                cmd.Parameters.AddWithValue("fn", textBox1.Text);
                cmd.Parameters.AddWithValue("ln", textBox1.Text);
                cmd.Parameters.AddWithValue("crme", textBox1.Text);
                cmd.Parameters.AddWithValue("nic", textBox1.Text);
                cmd.Parameters.AddWithValue("number", textBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("DB VIEW SUCCESSFUL");
                    dr.Close();
                }


                if (comboBox1.Text == "PrisonerID")
                {
                    listView1.Items.Clear();
                    int check = 0;
                    foreach (var i in New_Prisoner.PrisonerID)
                    {
                        if (New_Prisoner.PrisonerID[check] == Convert.ToInt32(textBox1.Text))
                        {
                            string[] show = new string[] { New_Prisoner.PrisonerID[check].ToString(), New_Prisoner.PrisonerFname[check], New_Prisoner.PrisonerLName[check], New_Prisoner.PrisonerCrime[check], New_Prisoner.PrisonerCNIC[check].ToString(), New_Prisoner.PrisonTime[check].ToString() };
                            ListViewItem item = new ListViewItem(show);
                            listView1.Items.Add(item);
                            this.listView1.View = View.Details;
                        }
                        check++;
                    }

                }
                else if (comboBox1.Text == "Name(First or Last)")
                {
                    listView1.Items.Clear();
                    int check1 = 0;
                    int check2 = 0;
                    foreach (var i in New_Prisoner.PrisonerFname)
                    {
                        if (textBox1.Text == New_Prisoner.PrisonerFname[check1] || textBox1.Text == New_Prisoner.PrisonerLName[check2])
                        {
                            string[] show = new string[] { New_Prisoner.PrisonerID[check1].ToString(), New_Prisoner.PrisonerFname[check1], New_Prisoner.PrisonerLName[check1], New_Prisoner.PrisonerCrime[check1],New_Prisoner.PrisonTime[check1].ToString() , New_Prisoner.PrisonerCNIC[check1].ToString(), New_Prisoner.PrisonTime[check1].ToString()};
                            ListViewItem item = new ListViewItem(show);
                            listView1.Items.Add(item);
                            this.listView1.View = View.Details;
                        }
                        check1++;

                    }

                    //foreach (var i in New_Prisoner.PrisonerLName)
                    //{
                    //    if (textBox1.Text == New_Prisoner.PrisonerLName[check2])
                    //    {
                    //        string[] show = new string[] { New_Prisoner.PrisonerID[check2].ToString(), New_Prisoner.PrisonerFname[check2], New_Prisoner.PrisonerLName[check2], New_Prisoner.PrisonerCrime[check2], New_Prisoner.PrisonTime[check2].ToString(), New_Prisoner.PrisonerCNIC[check2].ToString() };
                    //        ListViewItem item = new ListViewItem(show);
                    //        listView1.Items.Add(item);
                    //        this.listView1.View = View.Details;
                    //    }
                    //    check2++;
                    //}
                }
                else if(comboBox1.Text == "CNIC")
                {
                    listView1.Items.Clear();
                    int check = 0;
                    
                    foreach (var i in New_Prisoner.PrisonerCNIC)
                    {
                        if (New_Prisoner.PrisonerCNIC[check] == Convert.ToInt32(textBox1.Text))
                        {
                            string[] show = new string[] { New_Prisoner.PrisonerID[check].ToString(), New_Prisoner.PrisonerFname[check], New_Prisoner.PrisonerLName[check], New_Prisoner.PrisonerCrime[check], New_Prisoner.PrisonTime[check].ToString(), New_Prisoner.PrisonerCNIC[check].ToString(), New_Prisoner.PrisonTime[check].ToString() };
                            ListViewItem item = new ListViewItem(show);
                            listView1.Items.Add(item);
                            this.listView1.View = View.Details;
                        }
                        check++;
                    }
                }
                else if (comboBox1.Text == "Phone Number")
                {
                    listView1.Items.Clear();
                    int check = 0;

                    foreach (var i in New_Prisoner.PrisonerPhone)
                    {
                        if (New_Prisoner.PrisonerPhone[check] == Convert.ToInt32(textBox1.Text))
                        {
                            string[] show = new string[] { New_Prisoner.PrisonerID[check].ToString(), New_Prisoner.PrisonerFname[check], New_Prisoner.PrisonerLName[check], New_Prisoner.PrisonerCrime[check], New_Prisoner.PrisonTime[check].ToString(), New_Prisoner.PrisonerCNIC[check].ToString(), New_Prisoner.PrisonTime[check].ToString() };
                            ListViewItem item = new ListViewItem(show);
                            listView1.Items.Add(item);
                            this.listView1.View = View.Details;
                        }
                        check++;
                    }
                }
                else if (comboBox1.Text == "Crime")
                {
                    listView1.Items.Clear();
                    int check = 0;
                    foreach (var i in New_Prisoner.PrisonerCrime)
                    {

                        if (textBox1.Text == New_Prisoner.PrisonerCrime[check])
                        {

                            string[] show = new string[] {New_Prisoner.PrisonerID[check].ToString(), New_Prisoner.PrisonerFname[check], New_Prisoner.PrisonerLName[check], New_Prisoner.PrisonerCrime[check], New_Prisoner.PrisonTime[check].ToString(), New_Prisoner.PrisonerCNIC[check].ToString(), New_Prisoner.PrisonTime[check].ToString() };
                            ListViewItem item = new ListViewItem(show);
                            listView1.Items.Add(item);
                            this.listView1.View = View.Details;
                        }
                        check++;
                    }
                }

                //listView1.Items.Clear();
                //string[] mysample = { "Sample A", "Sample B", "Sample C" };
                //string[] myquantity = { "1", "2", "3" };

                //for (int i = 0; i < mysample.Length; i++)
                //{
                //    string[] subitems = new string[] { mysample[i], myquantity[i] };
                //    ListViewItem item = new ListViewItem(subitems);
                //    listView1.Items.Add(item);
                //    this.listView1.View = View.Details;
                //}
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            After_Login afterLogin = new After_Login();
            afterLogin.Closed += (s, args) => this.Close();
            afterLogin.Show();
        }

        private void ViewSearch_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }
    }
}
