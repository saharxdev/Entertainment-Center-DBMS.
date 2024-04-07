using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Entertainment_Center_Database_Project
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da= new SqlDataAdapter();

        public Register()
        {
            InitializeComponent();
            
        }
        
       

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
                if (txt_username.Text == "" && txt_password.Text == "" && txt_confirmpassword.Text == " ")
                {
                    MessageBox.Show("Username and Password are empty", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_password.Text == txt_confirmpassword.Text)
                {

                    string register = "INSERT  INTO users(username,password) VALUES (@username,@password)";
                    SqlCommand cmd = new SqlCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);


                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    try
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Your account has been successfully registered", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception msg)
                {
                    MessageBox.Show("An error occurred while registering the user! " + msg.ToString());
                }


                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Passwords does not match, Please Re-Enter!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_password.Text = "";
                    txt_confirmpassword.Text = "";
                    txt_password.Focus();
                }

        }

        private void check_showpassword_CheckedChanged(object sender, EventArgs e)
        {


        }


        private void check_confirmpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (check_confirmpassword.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_confirmpassword.PasswordChar = '\0';


            }
            else
            {
                txt_password.PasswordChar = '*';
                txt_confirmpassword.PasswordChar = '*';
            }
        }

        private void link_return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

