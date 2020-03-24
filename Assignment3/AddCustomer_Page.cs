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
    public partial class AddCustomer_Page : Form
    {
        public static bool custAdded = false;
        public AddCustomer_Page()
        {
            InitializeComponent();
        }
        private void validate()
        {
            btnAddCustomer.Enabled = false;
            if (!(txtFirstName.Text == "" || txtLastName.Text == "" || txtPhoneNumber.Text == ""))
            {
                btnAddCustomer.Enabled = true;
            }
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            custAdded = true;
            Program.aCoord.addCustomer(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text);
            Customers_Page cp = new Customers_Page();
            Hide();
            cp.Show();
        }

        private void AddCustomer_Page_Load(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            lblErrorFirstName.Text = " Please enter a First Name. ";

            if (!(Program.isStringEmpty(txtFirstName)))
            {
                lblErrorFirstName.Text = "";
                validate();

            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            lblErrorLastName.Text = " Please enter a Last Name. ";

            if (!Program.isStringEmpty(txtLastName))
            {
                lblErrorLastName.Text = "";
                validate();
            }

        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            lblErrorPhoneNumber.Text = " Please enter a Phone Number. ";

            if (!Program.isStringEmpty(txtPhoneNumber))
            {
                lblErrorPhoneNumber.Text = "";
                validate();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close program?", "Exit Program?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
        }
        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.ForeColor = Color.Navy;
        }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnAddCustomer.BackColor = Color.Black;
            btnAddCustomer.ForeColor = Color.Lavender;
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Navy;
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

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
            btnExit.ForeColor = Color.Lavender;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Customers_Page cp = new Customers_Page();
            Hide();
            cp.Show();
        }

        private void AddCustomer_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ClosingButton(sender, e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddCustomer.Enabled == true)
                btnAddCustomer_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtLastName.Focus();
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddCustomer.Enabled == true)
                btnAddCustomer_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtPhoneNumber.Focus();
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddCustomer.Enabled == true)
                btnAddCustomer_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                txtFirstName.Focus();
        }
    }
}
