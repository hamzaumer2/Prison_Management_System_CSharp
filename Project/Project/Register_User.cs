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
    public partial class Register_User : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        private int i = 0;

        private string[] firstname = new string[100],
            lastname = new string[100];

        public static string[] date = new string[100];
            

        public static string[] username = new string[100];
        public static string[] password = new string[100];
        public static int[] phone = new int[100];
        private bool[] gender = new bool[100];
        string
            tempfn = "",
            templn = "",
            tempusername = "",
            tempdate,
            temppass = "",
            tempemail = "";
        int tempphone;
        private bool temp_gender, isNumeric;
        public Register_User()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            tempfn = RegisterFN.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            templn = RegisterLN.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            tempusername = RegisterUsername.Text;
        }

        private void Register_User_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            tempdate = RegisterDate.Value.ToString("yyyy-MM-dd");
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (RegisterPhone.Text != "")
            {
                int n;
                isNumeric = int.TryParse(RegisterPhone.Text, out n);
                if (isNumeric)
                {
                    label6.Text = "";
                    tempphone = Convert.ToInt32(RegisterPhone.Text);
                }
                else
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Enter a Valid Number Please!!";
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            temppass = RegisterPassword.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label7.Text = "";
                temp_gender = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label7.Text = "";
                temp_gender = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tempusername == "" || tempphone == 0 || tempfn == "" || templn == ""|| temppass == "" || isNumeric == false)
            {
                if (tempfn == "")
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Enter First Name";
                }

                if (templn == "")
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Enter Last Name";
                }

                if (tempusername == "")
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Enter Username";
                }

                if (temppass == "")
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Enter Password";
                }

                if (tempphone == 0)
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Enter Phone Number";
                }

                if (!(radioButton1.Checked && radioButton2.Checked))
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "Enter Gender";
                }

                if (isNumeric == false)
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Enter a Valid Number";
                }
            }

            else
            {
                foreach (int ph in phone)
                {
                    if (phone[ph] == 0)
                    {
                        cn = new SqlConnection(
                            @"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
                        cn.Open();

                        cmd = new SqlCommand("insert into [dbo].[Table] values (@un, @pw, @fn, @ln, @contact)", cn);
                        cmd.Parameters.AddWithValue("un", tempusername);
                        cmd.Parameters.AddWithValue("pw", temppass);
                        cmd.Parameters.AddWithValue("fn", tempfn);
                        cmd.Parameters.AddWithValue("ln", templn);
                        cmd.Parameters.AddWithValue("contact", tempphone);
                        cmd.ExecuteNonQuery();

                        firstname[i] = tempfn;
                        lastname[i] = templn;
                        username[i] = tempusername;
                        date[i] = tempdate;
                        phone[i] = tempphone;
                        password[i] = temppass;
                        gender[i] = temp_gender;
                        i++;
                        MessageBox.Show("Your Account is created . Please login now.",
                            "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        LoginPage mainPage = new LoginPage();
                        mainPage.Closed += (s, args) => this.Close();
                        mainPage.Show();
                    }

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            LoginPage mainPage = new LoginPage();
            mainPage.Closed += (s, args) => this.Close();
            mainPage.Show();
        }

    }
}
