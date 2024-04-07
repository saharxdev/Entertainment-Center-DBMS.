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
    public partial class ChoosePackage : Form
    {
        public ChoosePackage()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btn_funfiesta_Click(object sender, EventArgs e)
        {
           
                string register = "INSERT INTO BirthdayPackage (name, description,price) VALUES (@name, @description,@price)";
                SqlCommand cmd = new SqlCommand(register, connect);
                cmd.Parameters.AddWithValue("@name", "Fun Fiesta");
                cmd.Parameters.AddWithValue("@description", "Mid bouncy castle, hand painting, glitter tattoo, and balloon sculpting");
                cmd.Parameters.AddWithValue("@price", 388);


            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }

            cmd.ExecuteNonQuery();

            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }


            MessageBox.Show("Your reservation has been successful", "Booking Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Checkout().Show();
                this.Hide();

            }

        private void btn_party_Click(object sender, EventArgs e)
        {
            connect.Open();
            string register = "INSERT INTO BirthdayPackage (name, description,price) VALUES (@name, @description,@price)";
            SqlCommand cmd = new SqlCommand(register, connect);
            cmd.Parameters.AddWithValue("@name", "Enchanting Party");
            cmd.Parameters.AddWithValue("@description", "Kid's Magic Show,Games & prizes,Mascot Appearance, hand painting and balloon sculpting");
            cmd.Parameters.AddWithValue("@price", 458);

            cmd.ExecuteNonQuery();
            connect.Close();


            MessageBox.Show("Your reservation has been successful", "Booking Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Checkout().Show();
            this.Hide();

        }
    }
}
