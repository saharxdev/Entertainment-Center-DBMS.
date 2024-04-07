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
    public partial class Maintenance : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public Maintenance()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click_2(object sender, EventArgs e)
        {

        }

        private void Btn_updatedata_Click(object sender, EventArgs e)
        {
            if (txt_date.Text == "" || txt_description.Text == "" || txt_cost.Text == " ")
            {
                MessageBox.Show("Please fill all blocks.", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                string register = "INSERT  INTO Maintenance(Date,Description,Cost) VALUES (@Date,@Description,@Cost)";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.Parameters.AddWithValue("@Date", txt_date.Text);
                cmd.Parameters.AddWithValue("@Description", txt_description.Text);
                cmd.Parameters.AddWithValue("@Cost", int.Parse(txt_cost.Text));

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Maintenance data has been successfully updated", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
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
            

        }

    }
}

