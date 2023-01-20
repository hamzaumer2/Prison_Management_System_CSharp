using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project
{
    public partial class New_Prisoner : Form
    {
        SqlConnection cn;
        private SqlCommand cmd;
        public static int[] PrisonerID = new int[100];
        public static int[] PrisonTime = new int[100];
        public static string[] PrisonerFname = new string[100];
        public static string[] PrisonerLName = new string[100];
        public static string[] PrisonerCrime = new string[100];
        public static string[] PrisonerDOB = new string[100];
        public static string[] PrisonerArrestDate = new string[100];
        public static long[] PrisonerCNIC = new long[100];
        public static long[] PrisonerPhone = new long[100];

        private int temp_PrisonerID, temp_PrisonTime, temp_PrisonerPhone;
        string temp_PrisonerFname, temp_PrisonerLName, temp_PrisonerCrime, temp_PrisonerDOD,temp_PrisonArrestDate;
        private long temp_PrisonerCNIC;
        private bool isNumeric;
        
        public New_Prisoner()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int n;
                isNumeric = int.TryParse(textBox3.Text, out n);
                if (isNumeric)
                {
                    label5.Text = "";
                    temp_PrisonerID = Convert.ToInt32(textBox3.Text);
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Enter a Valid ID Please!!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            temp_PrisonerID = rnd.Next();
            textBox3.Text = temp_PrisonerID.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "";
            temp_PrisonerFname = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "";
            temp_PrisonerLName = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            temp_PrisonerDOD = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != "")
            {
                int n;
                isNumeric = int.TryParse(textBox4.Text, out n);
                if (isNumeric)
                {
                    label8.Text = "";
                    temp_PrisonerCNIC = Convert.ToInt64(textBox4.Text);
                }
                else
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "Enter a Valid CNIC Please!!";
                }
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int n;
                isNumeric = int.TryParse(textBox5.Text, out n);
                if (isNumeric)
                {
                    label9.Text = "";
                    temp_PrisonerPhone = Convert.ToInt32(textBox5.Text);
                }
                else
                {
                    label9.ForeColor = Color.Red;
                    label9.Text = "Enter a Valid Phone Number Please!!";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                {
                    label10.Text = "";
                    temp_PrisonerCrime = comboBox1.Text;
                    break;
                }
                case 1:
                {
                    label10.Text = "";
                    temp_PrisonerCrime = comboBox1.Text;
                        break;
                }
                case 2:
                {
                    label10.Text = "";
                    temp_PrisonerCrime = comboBox1.Text;
                        break;
                }
                case 3:
                {
                    label10.Text = "";
                        break;
                }
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "";
            if (comboBox1.SelectedIndex == 3)
            {
                temp_PrisonerCrime = textBox6.Text;
            }
        }

        private void New_Prisoner_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


            if (textBox7.Text != "")
            {
                int n;
                isNumeric = int.TryParse(textBox7.Text, out n);
                if (isNumeric)
                {
                    label12.Text = "";
                    temp_PrisonTime = Convert.ToInt32(textBox7.Text);
                }
                else
                {
                    label12.ForeColor = Color.Red;
                    label12.Text = "Enter a Valid Prison Time Please!!";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            temp_PrisonArrestDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int check1 = 0;
            foreach (var i in New_Prisoner.PrisonerID)
            {
                if (New_Prisoner.PrisonerID[check1] == Convert.ToInt32(textBox3.Text))
                {
                    label5.ForeColor = Color.Red;

                    label5.Text = "Prisoner ID Already exists";
                    textBox3.PlaceholderText = textBox3.Text;
                    textBox3.Text = "";

                    break;
                }
                check1++;
            }


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Enter First Name";}

                if (textBox2.Text == "")
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "Enter Last Name";
                }

                if (textBox3.Text == "")
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Enter Prisoner ID";
                }

                if (textBox4.Text == "")
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "Enter CNIC";
                }

                if (textBox5.Text == "")
                {
                    label9.ForeColor = Color.Red;
                    label9.Text = "Enter Phone Number";
                }

                if (comboBox1.Text == "Other" || comboBox1.Text == "Crime")
                {
                    if (textBox6.Text == "")
                    {
                        label11.ForeColor = Color.Red;
                        label11.Text = "Enter Crime";
                    }
                    if (comboBox1.Text == "Other")
                    {
                        label11.ForeColor = Color.Red;
                        label11.Text = "Enter Crime";
                    }
                }

                if (textBox7.Text == "")
                {
                    label12.ForeColor = Color.Red;
                    label12.Text = "Enter Time for Arrest";
                }

                if (comboBox1.Text == "Crime")
                {
                    label10.ForeColor = Color.Red;
                    label10.Text = "Enter Crime";
                }

            }

            else
            {
                cn = new SqlConnection(
                    @"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
                cn.Open();

                cmd = new SqlCommand("insert into [dbo].[prisoner] values (@id, @fn, @ln, @cr, @pt, @cnic, @phn");
                cmd.Parameters.AddWithValue("id", temp_PrisonerID);
                cmd.Parameters.AddWithValue("fn", temp_PrisonerFname);
                cmd.Parameters.AddWithValue("ln", temp_PrisonerLName);
                cmd.Parameters.AddWithValue("cr", temp_PrisonerCrime);
                cmd.Parameters.AddWithValue("pt", temp_PrisonTime);
                cmd.Parameters.AddWithValue("cnic", temp_PrisonerCNIC);
                cmd.Parameters.AddWithValue("phn", temp_PrisonerPhone);



                int check = 0;
                foreach (var i in PrisonerID)
                {
                    if (PrisonerID[check] == 0)
                    {

                        PrisonerID[check] = temp_PrisonerID;
                        PrisonerFname[check] = temp_PrisonerFname;
                        PrisonerLName[check] = temp_PrisonerLName;
                        PrisonerDOB[check] = temp_PrisonerDOD;
                        PrisonerCNIC[check] = temp_PrisonerCNIC;
                        PrisonerPhone[check] = temp_PrisonerPhone;
                        PrisonerCrime[check] = temp_PrisonerCrime;
                        PrisonTime[check] = temp_PrisonTime;
                        PrisonerArrestDate[check] = temp_PrisonArrestDate;
                        MessageBox.Show("Prisoner Added Successfully");
                        this.Hide();

                        After_Login afterLogin = new After_Login();
                        afterLogin.Closed += (s, args) => this.Close();
                        afterLogin.Show();
                        break;
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


    }
}
