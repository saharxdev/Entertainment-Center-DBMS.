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
    public partial class BowlingReservation : Form
    {
        public BowlingReservation()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

            if (txt_lanenumber.Text == "" || txt_maxplayers.Text == "" || txt_currentplayers.Text == "" || txt_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string register = "INSERT INTO BowlingLanes (laneId, status,max_players,current_players) VALUES (@laneId, @status,@max_players,@current_players)";
                SqlCommand cmd = new SqlCommand(register, connect);
                cmd.Parameters.AddWithValue("@laneId", txt_lanenumber.Text);
                cmd.Parameters.AddWithValue("@status", txt_status.Text);
                cmd.Parameters.AddWithValue("@max_players", txt_maxplayers.Text);
                cmd.Parameters.AddWithValue("@current_players", txt_currentplayers.Text);

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
                new Checkout().Show();
                this.Hide();

            }
        
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_maxplayers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
