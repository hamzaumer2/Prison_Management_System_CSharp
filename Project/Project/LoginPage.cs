
using System.Data.SqlClient;

namespace Project
{
    public partial class LoginPage : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        public static string enteredusername = "";
        string enteredpassword = "";
        string adminLogin = "admin";
        string adminPassword = "admin";
        public LoginPage()
        {
            

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            enteredusername = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            enteredpassword = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();

            if (enteredusername == "" || enteredpassword == "")
            {
                if(enteredusername == "")
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Enter Username";
                }
                if(enteredpassword =="")
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Enter Password";
                }
            }
            else
            {
                if (textBox1.Text == adminLogin && textBox2.Text == adminPassword)
                {
                    this.Hide();

                    After_Login afterLogin = new After_Login();
                    afterLogin.Closed += (s, args) => this.Close();
                    afterLogin.Show();
                }
                else
                {
                    cn = new SqlConnection(
                        @"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
                    cn.Open();
                    cmd = new SqlCommand("select * from [dbo].[Table] where username = @user and password = @pass", cn);
                    cmd.Parameters.AddWithValue("user", enteredusername);
                    cmd.Parameters.AddWithValue("pass", enteredpassword);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        MessageBox.Show("DB Success");
                        After_Login afterLogin = new After_Login();
                        afterLogin.Closed += (s, args) => this.Close();
                        afterLogin.Show();

                        dr.Close();
                    }
                    
                    else
                    {
                        MessageBox.Show("INCORRECT CREDENTIALS");
                    }

                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Forgot_User forgot = new Forgot_User();
            forgot.Closed += (s, args) => this.Close();
            forgot.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Register_User register = new Register_User();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Closed += (s, args) => this.Close();
            about.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HUSKY\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            cn.Open();
        }
    }
}