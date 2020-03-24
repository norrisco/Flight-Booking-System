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
    public partial class Customers_Page : Form
    {
        int customerId;
        public Customers_Page()
        {
            InitializeComponent();
            txtDeleteCustomer.Hide();
            
        }

        private void Customers_Page_Load(object sender, EventArgs e)
        {
            if (AddCustomer_Page.custAdded == true)
            {
                lblError.Text = " New customer has been added. ";
                AddCustomer_Page.custAdded = false;
            }
            richTextBox1.AppendText(Program.aCoord.customerList());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Hide();
            h.Show();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            Flights_Page fp = new Flights_Page();
            Hide();
            fp.Show();
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
            AddCustomer_Page addcp = new AddCustomer_Page();
            Hide();
            addcp.Show();
        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteCustomer.Visible == false)
            {
                btnDelete.Size = new Size(120,30);
                btnDelete.Location = new Point(924, 95);
                txtDeleteCustomer.Show();
                btnDelete.Enabled = false;
                txtDeleteCustomer.Focus();
            }
            else
            {
                if (checkInteger(txtDeleteCustomer))
                {
                    lblError.Text = "";
                    int id = Convert.ToInt32(txtDeleteCustomer.Text);
                    txtDeleteCustomer.Clear();
                    if (Program.aCoord.deleteCustomer(id))
                    {
                        lblError.Text = " Customer (" + id + ") has been deleted. ";
                    } else
                    {
                        lblError.Text = " Customer (" + id + ") does not exist. ";
                    }
                    richTextBox1.Clear();
                    richTextBox1.AppendText(Program.aCoord.customerList());
                    
                } else
                {
                    lblError.Text = " Invalid Customer ID. ";
                }
            }
        }

        private void txtDeleteCustomer_Leave(object sender, EventArgs e)
        {
            if (!checkInteger(txtDeleteCustomer))
                lblError.Text = " Please enter an integer value. ";
            else
                lblError.Text = "";
        }

        private void txtDeleteCustomer_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            if (txtDeleteCustomer.Text.Equals(""))
                lblError.Text = " Please enter a Customer ID. ";
            else if (!Int32.TryParse(txtDeleteCustomer.Text, out customerId))
                lblError.Text = " Please enter an integer value. ";
            else
            {
                lblError.Text = "";
                btnDelete.Enabled = true;
                btnDelete.NotifyDefault(true);
            }
        }

        private void txtDeleteCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnDelete.Enabled == true)
                btnDelete_Click(sender, e);
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
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Navy;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.Lavender;
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

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }

        private void Customers_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }
    }
}
