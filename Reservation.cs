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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {




        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text) ||
        string.IsNullOrWhiteSpace(txt_firstname.Text) ||
        string.IsNullOrWhiteSpace(txt_lastname.Text) ||
        string.IsNullOrWhiteSpace(txt_email.Text) ||
        string.IsNullOrWhiteSpace(txt_phonenumber.Text) )
            {
                MessageBox.Show("Please Fill all sections.", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
                string register = "INSERT INTO Customer (Id, first_name,last_name,email,phone_number) VALUES (@ID, @first_name,@last_name,@email,@phone_number)";
                SqlCommand cmd = new SqlCommand(register, connect);
                cmd.Parameters.AddWithValue("@Id", txt_id.Text.Trim());
                cmd.Parameters.AddWithValue("@first_name", txt_firstname.Text.Trim());
                cmd.Parameters.AddWithValue("@last_name", txt_lastname.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_number", txt_phonenumber.Text.Trim());


                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                cmd.ExecuteNonQuery();

                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }


                new Categories().Show();
                this.Hide();
            }
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

