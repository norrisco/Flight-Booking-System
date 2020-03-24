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
    public partial class Bookings_Page : Form
    {
        string custID;
        string flNo;
        bool custIDValid = false;
        bool flNoValid = false;
        int cId;
        int fNum;

        public Bookings_Page()
        {
            InitializeComponent();
            txtCustomerID.Hide();
            txtFlightNumber.Hide();
            lblCustomerID.Hide();
            lblFlightNumber.Hide();
        }

        private void Bookings_Page_Load(object sender, EventArgs e)
        {
            richTextBoxCL.AppendText(Program.aCoord.customerList());
            richTextBoxFL.AppendText(Program.aCoord.flightList());
            richTextBox1.AppendText(Program.aCoord.bookingList());
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            Hide();
            f.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close program?", "Exit Program?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
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

        private void btnFlights_MouseEnter(object sender, EventArgs e)
        {
            btnFlights.BackColor = Color.White;
            btnFlights.ForeColor = Color.Navy;
        }
        private void btnFlights_MouseLeave(object sender, EventArgs e)
        {
            btnFlights.BackColor = Color.Black;
            btnFlights.ForeColor = Color.Lavender;
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.Black;
            btnCustomers.ForeColor = Color.Lavender;
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.White;
            btnCustomers.ForeColor = Color.Navy;
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
        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Visible == false && txtFlightNumber.Visible == false && lblCustomerID.Visible == false && lblFlightNumber.Visible == false)
            {
                btnAdd.Text = "Add Booking";
                txtCustomerID.Show();
                txtFlightNumber.Show();
                lblCustomerID.Show();
                lblFlightNumber.Show();
                txtCustomerID.Focus();
                btnAdd.Enabled = false;
            }
            else
            {
                if (checkInteger(txtCustomerID) && checkInteger(txtFlightNumber))
                {
                    lblError.Text = "";
                    lblErrorCustomerID.Text = "";
                    string bDate = DateTime.Now.ToString();
                    int id = Convert.ToInt32(txtCustomerID.Text);
                    int flNo = Convert.ToInt32(txtFlightNumber.Text);
                    if (Program.aCoord.addBooking(bDate,id,flNo))
                    {
                        txtCustomerID.Text = "";
                        txtFlightNumber.Text = "";
                        lblError.Text = "";
                        lblErrorCustomerID.Text = "";
                        lblSuccess.Text = " Customer (" + id + ") has been added to Flight (" + flNo + ") ";
                    }
                    else
                    {
                        lblSuccess.Text = "";
                        lblError.Text = " Could not add customer to booking. ";
                    }
                    richTextBox1.Clear();
                    richTextBox1.AppendText(Program.aCoord.bookingList());
                }
                else
                {
                    if (checkInteger(txtCustomerID) == false)
                        lblErrorCustomerID.Text = " Invalid Customer ID. ";
                    else
                        lblError.Text = " Invalid Flight Number. ";
                }
            }
        }
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAdd.Enabled == true)
                btnAdd_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtFlightNumber.Focus();
        }
        private void txtFlightNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAdd.Enabled == true)
                btnAdd_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtCustomerID.Focus();
        }
        public void validate()
        {
            btnAdd.Enabled = false;
            if (custIDValid && flNoValid)
            {
                btnAdd.Enabled = true;
                btnAdd.NotifyDefault(true);
            }
                
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblSuccess.Text = "";
            custIDValid = false;
            validate();
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                lblErrorCustomerID.Text = " Please enter a Customer ID. ";
            }
            else if (!Int32.TryParse(txtCustomerID.Text, out cId))
            {
                lblErrorCustomerID.Text = " Please enter an integer value. ";
            }
            else
            {
                lblErrorCustomerID.Text = "";
                custID = txtCustomerID.Text;
                custIDValid = true;
                validate();
            }
        }
        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {
            lblSuccess.Text = "";
            flNoValid = false;
            validate();
            if (string.IsNullOrWhiteSpace(txtFlightNumber.Text))
            {
                lblError.Text = " Please enter a Flight Number. ";
            }
                
            else if (!Int32.TryParse(txtFlightNumber.Text, out fNum))
            {
                lblError.Text = " Please enter an integer value. ";
            }
            else
            {
                lblError.Text = "";
                flNo = txtFlightNumber.Text;
                flNoValid = true;
                validate();
            }

        }

        private void Bookings_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }
    }
}
