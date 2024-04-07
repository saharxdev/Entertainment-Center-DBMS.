using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entertainment_Center_Database_Project
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_bowling_Click(object sender, EventArgs e)
        {
            new BowlingReservation().Show();
            this.Hide();
        }

        private void btn_birthday_Click(object sender, EventArgs e)
        {
            new BirthdayAreaReservation().Show();
            this.Hide();
        }
    }
}
