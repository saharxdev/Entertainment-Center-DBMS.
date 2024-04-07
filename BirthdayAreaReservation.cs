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
    public partial class BirthdayAreaReservation : Form
    {
        public BirthdayAreaReservation()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void btn_package_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_capacity.Text == "" || txt_location.Text == "" )
            {
                MessageBox.Show("Please fill all blank fields!", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string register = "INSERT INTO BirthdayArea (Id, capacity,location) VALUES (@Id, @capacity,@location)";
                SqlCommand cmd = new SqlCommand(register, connect);
                cmd.Parameters.AddWithValue("@Id", txt_id.Text.Trim());
                cmd.Parameters.AddWithValue("@capacity", txt_capacity.Text.Trim());
                cmd.Parameters.AddWithValue("@location", txt_location.Text.Trim());


                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                cmd.ExecuteNonQuery();

                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }


                MessageBox.Show("Your reservation has been successfully reserved", "Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new ChoosePackage().Show();
                this.Hide();

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
