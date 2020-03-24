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
    public partial class AddFlight_Page : Form
    {
        public static bool flightAdded = false;

        public AddFlight_Page()
        {
            InitializeComponent();
        }
        private void AddFlight_Page_Load(object sender, EventArgs e)
        {
            btnAddFlight.Enabled = false;
        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);
        }
        public void validate()
        {
            btnAddFlight.Enabled = false;
            if (!(txtFlightNumber.Text == "" || txtMaxSeats.Text == "" || txtPortOfOrigin.Text == "" || txtDestinationPort.Text == ""))
            {
                btnAddFlight.Enabled = true;
            }
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string origin = txtPortOfOrigin.Text;
            string destination = txtDestinationPort.Text;

            if (checkInteger(txtFlightNumber) && checkInteger(txtMaxSeats))
            {
                int flightNo = Convert.ToInt32(txtFlightNumber.Text);
                int maxSeats = Convert.ToInt32(txtMaxSeats.Text);
                Program.aCoord.addFlight(flightNo, origin, destination, maxSeats);
                
            }
            flightAdded = true;
            Flights_Page fp = new Flights_Page();
            Hide();
            fp.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close program?", "Exit Program?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
        }
        private void btnAddFlight_MouseEnter(object sender, EventArgs e)
        {
            btnAddFlight.BackColor = Color.White;
            btnAddFlight.ForeColor = Color.Navy;
        }

        private void btnAddFlight_MouseLeave(object sender, EventArgs e)
        {
            btnAddFlight.BackColor = Color.Black;
            btnAddFlight.ForeColor = Color.Lavender;
        }
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.White;
            btnBack.ForeColor = Color.Navy;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Black;
            btnBack.ForeColor = Color.Lavender;
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


        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {
            btnAddFlight.Enabled = false;
            lblErrorFlightNumber.Text = " Please enter a Flight Number. ";
            int flightId;
            if (Program.isInteger(txtFlightNumber, out flightId))
            {
                lblErrorFlightNumber.Text = "";
                validate();
            }else if (txtFlightNumber.Text == "")
            {

            }
            else
                lblErrorFlightNumber.Text = " Please enter an integer value. ";
      
        }

        private void txtMaxSeats_TextChanged(object sender, EventArgs e)
        {
            btnAddFlight.Enabled = false;
            lblErrorMaxSeats.Text = " Please enter the max number of seats. ";
            int maxSeats;
            if (Program.isInteger(txtMaxSeats, out maxSeats))
            {
                lblErrorMaxSeats.Text = "";
                validate();
            }
            else if (txtMaxSeats.Text == "")
            {

            }
            else
                lblErrorMaxSeats.Text = " Please enter an integer value. ";
        }
        private void txtPortOfOrigin_TextChanged(object sender, EventArgs e)
        {
            btnAddFlight.Enabled = false;
            lblErrorPortOfOrigin.Text = " Please enter a Port of Origin. ";

            if (!(Program.isStringEmpty(txtPortOfOrigin)))
            {
                lblErrorPortOfOrigin.Text = "";
                validate();

            }
        }
        private void txtDestinationPort_TextChanged(object sender, EventArgs e)
        {
            btnAddFlight.Enabled = false;
            lblErrorDestinationPort.Text = " Please enter a destination. ";

            if (!(Program.isStringEmpty(txtDestinationPort)))
            {
                lblErrorDestinationPort.Text = "";
                validate();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Flights_Page fp = new Flights_Page();
            Hide();
            fp.Show();
        }

        private void AddFlight_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }

        private void txtFlightNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddFlight.Enabled == true)
                btnAddFlight_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtMaxSeats.Focus();
        }

        private void txtMaxSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddFlight.Enabled == true)
                btnAddFlight_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtPortOfOrigin.Focus();
        }

        private void txtPortOfOrigin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddFlight.Enabled == true)
                btnAddFlight_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtDestinationPort.Focus();
        }

        private void txtDestinationPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddFlight.Enabled == true)
                btnAddFlight_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtFlightNumber.Focus();
        }
    }
}
