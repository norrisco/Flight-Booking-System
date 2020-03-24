/*** Billy Cabic - 101032416 ***/
/*** Norris Co - 101126499 ***/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnFlights_Click(object sender, EventArgs e)
        {
            Flights_Page f = new Flights_Page();
            Hide();
            f.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers_Page f = new Customers_Page();
            Hide();
            f.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Bookings_Page bp = new Bookings_Page();
            Hide();
            bp.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close program?", "Exit Program?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(99, 164, 206);
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Maroon;
            btnExit.ForeColor = Color.Lavender;
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomer.BackColor = Color.White;
            btnCustomer.ForeColor = Color.FromArgb(99, 164, 206);
        }
        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnCustomer.BackColor = Color.Black;
            btnCustomer.ForeColor = Color.Lavender;
        }

        private void btnFlights_MouseEnter(object sender, EventArgs e)
        {
            btnFlights.BackColor = Color.White;
            btnFlights.ForeColor = Color.FromArgb(99, 164, 206);
        }
        private void btnFlights_MouseLeave(object sender, EventArgs e)
        {
            btnFlights.BackColor = Color.Black;
            btnFlights.ForeColor = Color.Lavender;
        }

        private void btnBookings_MouseEnter(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.White;
            btnBookings.ForeColor = Color.FromArgb(99, 164, 206);
        }
        private void btnBookings_MouseLeave(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.Black;
            btnBookings.ForeColor = Color.Lavender;
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
