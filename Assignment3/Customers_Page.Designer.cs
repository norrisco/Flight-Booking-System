namespace Assignment3
{
    partial class Customers_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtDeleteCustomer = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.Black;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBookings.Location = new System.Drawing.Point(494, 11);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(155, 55);
            this.btnBookings.TabIndex = 6;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            this.btnBookings.MouseEnter += new System.EventHandler(this.btnBookings_MouseEnter);
            this.btnBookings.MouseLeave += new System.EventHandler(this.btnBookings_MouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomers.Enabled = false;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(172, 11);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(155, 55);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.Black;
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFlights.Location = new System.Drawing.Point(333, 11);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(155, 55);
            this.btnFlights.TabIndex = 5;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = false;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            this.btnFlights.MouseEnter += new System.EventHandler(this.btnFlights_MouseEnter);
            this.btnFlights.MouseLeave += new System.EventHandler(this.btnFlights_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnHome.Location = new System.Drawing.Point(11, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(155, 55);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(1235, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 55);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.Location = new System.Drawing.Point(1233, 90);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 65);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Location = new System.Drawing.Point(1069, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Berlin Sans FB", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(31, 226);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1359, 494);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // txtDeleteCustomer
            // 
            this.txtDeleteCustomer.BackColor = System.Drawing.Color.Black;
            this.txtDeleteCustomer.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteCustomer.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtDeleteCustomer.Location = new System.Drawing.Point(1233, 90);
            this.txtDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeleteCustomer.Name = "txtDeleteCustomer";
            this.txtDeleteCustomer.Size = new System.Drawing.Size(157, 24);
            this.txtDeleteCustomer.TabIndex = 3;
            this.txtDeleteCustomer.TextChanged += new System.EventHandler(this.txtDeleteCustomer_TextChanged);
            this.txtDeleteCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeleteCustomer_KeyPress);
            this.txtDeleteCustomer.Leave += new System.EventHandler(this.txtDeleteCustomer_Leave);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Navy;
            this.lblError.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblError.Location = new System.Drawing.Point(1085, 159);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customers";
            // 
            // lblCustPhoneNumber
            // 
            this.lblCustPhoneNumber.AutoSize = true;
            this.lblCustPhoneNumber.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblCustPhoneNumber.Location = new System.Drawing.Point(606, 187);
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            this.lblCustPhoneNumber.Size = new System.Drawing.Size(259, 35);
            this.lblCustPhoneNumber.TabIndex = 0;
            this.lblCustPhoneNumber.Text = "[ Phone Number ]";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.White;
            this.lblCustName.Location = new System.Drawing.Point(217, 187);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(271, 35);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "[ Customer Name ]";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.Color.White;
            this.lblCustID.Location = new System.Drawing.Point(35, 187);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(86, 35);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "[ ID ]";
            // 
            // Customers_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1419, 752);
            this.Controls.Add(this.lblCustPhoneNumber);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDeleteCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customers_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_Page_FormClosing);
            this.Load += new System.EventHandler(this.Customers_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtDeleteCustomer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustPhoneNumber;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustID;
    }
}