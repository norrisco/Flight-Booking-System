namespace Assignment3
{
    partial class Bookings_Page
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.richTextBoxCL = new System.Windows.Forms.RichTextBox();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxFL = new System.Windows.Forms.RichTextBox();
            this.lblErrorCustomerID = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblFlightList = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustPhoneNumber = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblFlightNum = new System.Windows.Forms.Label();
            this.lblFlight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookingNumber = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(31, 516);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1359, 204);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBookings.Enabled = false;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.Black;
            this.btnBookings.Location = new System.Drawing.Point(495, 11);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(155, 55);
            this.btnBookings.TabIndex = 0;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.Black;
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFlights.Location = new System.Drawing.Point(334, 11);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(155, 55);
            this.btnFlights.TabIndex = 6;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = false;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            this.btnFlights.MouseEnter += new System.EventHandler(this.btnFlights_MouseEnter);
            this.btnFlights.MouseLeave += new System.EventHandler(this.btnFlights_MouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Black;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCustomers.Location = new System.Drawing.Point(173, 11);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(155, 55);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnCustomers.MouseEnter += new System.EventHandler(this.btnCustomers_MouseEnter);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.btnCustomers_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnHome.Location = new System.Drawing.Point(12, 11);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bookings";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Navy;
            this.lblError.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblError.Location = new System.Drawing.Point(985, 159);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 23;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.Black;
            this.txtCustomerID.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtCustomerID.Location = new System.Drawing.Point(1159, 91);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(65, 29);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Location = new System.Drawing.Point(1233, 91);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 64);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.BackColor = System.Drawing.Color.Black;
            this.txtFlightNumber.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtFlightNumber.Location = new System.Drawing.Point(1159, 125);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(65, 29);
            this.txtFlightNumber.TabIndex = 3;
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            this.txtFlightNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightNumber_KeyPress);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomerID.Location = new System.Drawing.Point(1037, 94);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(117, 23);
            this.lblCustomerID.TabIndex = 25;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFlightNumber.Location = new System.Drawing.Point(1019, 128);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(135, 23);
            this.lblFlightNumber.TabIndex = 26;
            this.lblFlightNumber.Text = "Flight Number:";
            // 
            // richTextBoxCL
            // 
            this.richTextBoxCL.BackColor = System.Drawing.Color.Black;
            this.richTextBoxCL.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxCL.Location = new System.Drawing.Point(31, 236);
            this.richTextBoxCL.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxCL.Name = "richTextBoxCL";
            this.richTextBoxCL.ReadOnly = true;
            this.richTextBoxCL.Size = new System.Drawing.Size(677, 194);
            this.richTextBoxCL.TabIndex = 0;
            this.richTextBoxCL.Text = "";
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerList.ForeColor = System.Drawing.Color.White;
            this.lblCustomerList.Location = new System.Drawing.Point(25, 177);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(196, 35);
            this.lblCustomerList.TabIndex = 0;
            this.lblCustomerList.Text = "Customer List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Booking List";
            // 
            // richTextBoxFL
            // 
            this.richTextBoxFL.BackColor = System.Drawing.Color.Black;
            this.richTextBoxFL.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxFL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxFL.Location = new System.Drawing.Point(713, 236);
            this.richTextBoxFL.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxFL.Name = "richTextBoxFL";
            this.richTextBoxFL.ReadOnly = true;
            this.richTextBoxFL.Size = new System.Drawing.Size(677, 194);
            this.richTextBoxFL.TabIndex = 0;
            this.richTextBoxFL.Text = "";
            // 
            // lblErrorCustomerID
            // 
            this.lblErrorCustomerID.AutoSize = true;
            this.lblErrorCustomerID.BackColor = System.Drawing.Color.Navy;
            this.lblErrorCustomerID.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCustomerID.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblErrorCustomerID.Location = new System.Drawing.Point(985, 68);
            this.lblErrorCustomerID.Name = "lblErrorCustomerID";
            this.lblErrorCustomerID.Size = new System.Drawing.Size(0, 19);
            this.lblErrorCustomerID.TabIndex = 31;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Navy;
            this.lblSuccess.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblSuccess.Location = new System.Drawing.Point(985, 159);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 19);
            this.lblSuccess.TabIndex = 32;
            // 
            // lblFlightList
            // 
            this.lblFlightList.AutoSize = true;
            this.lblFlightList.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightList.ForeColor = System.Drawing.Color.White;
            this.lblFlightList.Location = new System.Drawing.Point(707, 177);
            this.lblFlightList.Name = "lblFlightList";
            this.lblFlightList.Size = new System.Drawing.Size(147, 35);
            this.lblFlightList.TabIndex = 0;
            this.lblFlightList.Text = "Flight List";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.Color.White;
            this.lblCustID.Location = new System.Drawing.Point(27, 212);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(55, 24);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "[ ID ]";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.White;
            this.lblCustName.Location = new System.Drawing.Point(120, 212);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(181, 24);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "[ Customer Name ]";
            // 
            // lblCustPhoneNumber
            // 
            this.lblCustPhoneNumber.AutoSize = true;
            this.lblCustPhoneNumber.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblCustPhoneNumber.Location = new System.Drawing.Point(330, 212);
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            this.lblCustPhoneNumber.Size = new System.Drawing.Size(172, 24);
            this.lblCustPhoneNumber.TabIndex = 0;
            this.lblCustPhoneNumber.Text = "[ Phone Number ]";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.White;
            this.lblDestination.Location = new System.Drawing.Point(1073, 212);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(139, 24);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "[ Destination ]";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.ForeColor = System.Drawing.Color.White;
            this.lblOrigin.Location = new System.Drawing.Point(908, 212);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(91, 24);
            this.lblOrigin.TabIndex = 0;
            this.lblOrigin.Text = "[ Origin ]";
            // 
            // lblFlightNum
            // 
            this.lblFlightNum.AutoSize = true;
            this.lblFlightNum.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNum.ForeColor = System.Drawing.Color.White;
            this.lblFlightNum.Location = new System.Drawing.Point(709, 212);
            this.lblFlightNum.Name = "lblFlightNum";
            this.lblFlightNum.Size = new System.Drawing.Size(166, 24);
            this.lblFlightNum.TabIndex = 0;
            this.lblFlightNum.Text = "[ Flight Number ]";
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.ForeColor = System.Drawing.Color.White;
            this.lblFlight.Location = new System.Drawing.Point(637, 488);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(87, 24);
            this.lblFlight.TabIndex = 0;
            this.lblFlight.Text = "[ Flight ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "[ Date ]";
            // 
            // lblBookingNumber
            // 
            this.lblBookingNumber.AutoSize = true;
            this.lblBookingNumber.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNumber.ForeColor = System.Drawing.Color.White;
            this.lblBookingNumber.Location = new System.Drawing.Point(27, 488);
            this.lblBookingNumber.Name = "lblBookingNumber";
            this.lblBookingNumber.Size = new System.Drawing.Size(189, 24);
            this.lblBookingNumber.TabIndex = 0;
            this.lblBookingNumber.Text = "[ Booking Number ]";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(818, 488);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(121, 24);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "[ Customer ]";
            // 
            // Bookings_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1419, 752);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBookingNumber);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblFlightNum);
            this.Controls.Add(this.lblCustPhoneNumber);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblFlightList);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblErrorCustomerID);
            this.Controls.Add(this.richTextBoxFL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.richTextBoxCL);
            this.Controls.Add(this.lblFlightNumber);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bookings_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bookings_Page_FormClosing);
            this.Load += new System.EventHandler(this.Bookings_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.RichTextBox richTextBoxCL;
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxFL;
        private System.Windows.Forms.Label lblErrorCustomerID;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblFlightList;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustPhoneNumber;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblFlightNum;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookingNumber;
        private System.Windows.Forms.Label lblCustomer;
    }
}