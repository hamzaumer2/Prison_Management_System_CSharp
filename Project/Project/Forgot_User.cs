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
    public partial class Forgot_User : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;
        private string forgotuser = "`", forgotDOB = "`", newpassword = "`";
        private int forgotphone;
        private bool isNumeric;
        private bool isuser = false;
        public Forgot_User()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            forgotuser = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            forgotDOB = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int n;
                isNumeric = int.TryParse(textBox3.Text, out n);
                if (isNumeric)
                {
                    label4.Text = "";
                    forgotphone = Convert.ToInt32(textBox3.Text);
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Enter a Valid Number Please!!";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            newpassword = textBox4.Text;
        }

        private void Forgot_User_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label3.ForeColor = Color.Red;

                    label3.Text = "Enter Username";
                }

                if (textBox3.Text == "")
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Enter Phone Number";
                }

                if (textBox4.Text == "")
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Enter Password";
                }
            }
            else
            {
                cn = new SqlConnection(
                    @"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
                cn.Open();
                int i = 0;
                
                    cmd = new SqlCommand("select * from [dbo].[Table] where username = @user and phone = @number", cn);
                    cmd.Parameters.AddWithValue("user", forgotuser);
                    cmd.Parameters.AddWithValue("number", forgotphone);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();

                        cmd = new SqlCommand("update [dbo].[Table] set password = @pw where username = @user", cn);
                        cmd.Parameters.AddWithValue("username", forgotuser);
                        cmd.Parameters.AddWithValue("password", newpassword);
                        MessageBox.Show("DB Pass Change Success");
                        this.Hide();

                        LoginPage mainPage = new LoginPage();
                        mainPage.Closed += (s, args) => this.Close();
                        mainPage.Show();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Incorrect Credentials");
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
