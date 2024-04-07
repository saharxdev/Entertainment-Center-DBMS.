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
    public partial class Checkout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\pc\OneDrive - Rafic Hariri High School - Saida\Desktop\database project\VSCODE\Entertainment Center Database Project\Entertainment Center Database Project\myDB.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "Select * FROM Reservation";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dv.DataSource = dt;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (txt_date.Text == "" || txt_amount.Text == "" || txt_payement.Text == " ")
            {
                MessageBox.Show("Please fill all blocks.", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string register = "INSERT  INTO users(Date,PaymentMethod,TotalAmount) VALUES (@Date,@PaymentMethod,@TotalAmount)";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.Parameters.AddWithValue("@Date", txt_date.Text);
                cmd.Parameters.AddWithValue("@PaymentMethod", txt_payement.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", txt_amount.Text);

            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Maintenance data has been successfully updated", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception msg)
            {
                MessageBox.Show("An error occurred while registering the user! " + msg.ToString());
            }


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }






            cmd.ExecuteNonQuery();

            MessageBox.Show("Your account has been successfully registered", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
