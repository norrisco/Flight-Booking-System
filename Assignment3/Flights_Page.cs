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
    public partial class Flights_Page : Form
    {
        public Flights_Page()
        {
            InitializeComponent();
        }
        private bool isFlightsEmpty()
        {
            return Program.aCoord.flightList().Equals("Flight List:");
        }
        private void Flights_Load(object sender, EventArgs e)
        {
            if (AddFlight_Page.flightAdded == true)
            {
                lblError.Text = " New flight has been added. ";
                AddFlight_Page.flightAdded = false;
            }
            if (!isFlightsEmpty())
                richTextBox1.Text = Program.aCoord.flightList();
        }
        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home f = new Home();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFlight_Page addfl = new AddFlight_Page();
            Hide();
            addfl.Show();
        }
        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.White;
            btnHome.ForeColor = Color.Navy;
        }
        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
            btnHome.ForeColor = Color.Lavender;
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.White;
            btnCustomers.ForeColor = Color.Navy;
        }
        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.Black;
            btnCustomers.ForeColor = Color.Lavender;
        }
        
        private void btnBookings_MouseEnter(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.White;
            btnBookings.ForeColor = Color.Navy;
        }
        private void btnBookings_MouseLeave(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.Black;
            btnBookings.ForeColor = Color.Lavender;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Navy;
        }
       private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.ForeColor = Color.Lavender;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Navy;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
            btnExit.ForeColor = Color.Lavender;
        }

        private void Flights_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }
    }
}
