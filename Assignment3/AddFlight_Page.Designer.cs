namespace Assignment3
{
    partial class AddFlight_Page
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPortOfOrigin = new System.Windows.Forms.TextBox();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblErrorFlightNumber = new System.Windows.Forms.Label();
            this.lblPortOfOrigin = new System.Windows.Forms.Label();
            this.lblMaxSeats = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.lblDestinationPort = new System.Windows.Forms.Label();
            this.lblErrorMaxSeats = new System.Windows.Forms.Label();
            this.lblErrorPortOfOrigin = new System.Windows.Forms.Label();
            this.lblErrorDestinationPort = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(160, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Flight Information";
            // 
            // txtPortOfOrigin
            // 
            this.txtPortOfOrigin.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortOfOrigin.Location = new System.Drawing.Point(260, 298);
            this.txtPortOfOrigin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPortOfOrigin.Name = "txtPortOfOrigin";
            this.txtPortOfOrigin.Size = new System.Drawing.Size(232, 29);
            this.txtPortOfOrigin.TabIndex = 3;
            this.txtPortOfOrigin.TextChanged += new System.EventHandler(this.txtPortOfOrigin_TextChanged);
            this.txtPortOfOrigin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortOfOrigin_KeyPress);
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSeats.Location = new System.Drawing.Point(260, 222);
            this.txtMaxSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(232, 29);
            this.txtMaxSeats.TabIndex = 2;
            this.txtMaxSeats.TextChanged += new System.EventHandler(this.txtMaxSeats_TextChanged);
            this.txtMaxSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxSeats_KeyPress);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.Black;
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAddFlight.Location = new System.Drawing.Point(322, 446);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(170, 65);
            this.btnAddFlight.TabIndex = 5;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            this.btnAddFlight.MouseEnter += new System.EventHandler(this.btnAddFlight_MouseEnter);
            this.btnAddFlight.MouseLeave += new System.EventHandler(this.btnAddFlight_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(504, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // lblErrorFlightNumber
            // 
            this.lblErrorFlightNumber.AutoSize = true;
            this.lblErrorFlightNumber.BackColor = System.Drawing.Color.Navy;
            this.lblErrorFlightNumber.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFlightNumber.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblErrorFlightNumber.Location = new System.Drawing.Point(256, 126);
            this.lblErrorFlightNumber.Name = "lblErrorFlightNumber";
            this.lblErrorFlightNumber.Size = new System.Drawing.Size(0, 19);
            this.lblErrorFlightNumber.TabIndex = 0;
            // 
            // lblPortOfOrigin
            // 
            this.lblPortOfOrigin.AutoSize = true;
            this.lblPortOfOrigin.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortOfOrigin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPortOfOrigin.Location = new System.Drawing.Point(102, 298);
            this.lblPortOfOrigin.Name = "lblPortOfOrigin";
            this.lblPortOfOrigin.Size = new System.Drawing.Size(146, 26);
            this.lblPortOfOrigin.TabIndex = 0;
            this.lblPortOfOrigin.Text = "Port of Origin";
            // 
            // lblMaxSeats
            // 
            this.lblMaxSeats.AutoSize = true;
            this.lblMaxSeats.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSeats.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaxSeats.Location = new System.Drawing.Point(83, 222);
            this.lblMaxSeats.Name = "lblMaxSeats";
            this.lblMaxSeats.Size = new System.Drawing.Size(170, 26);
            this.lblMaxSeats.TabIndex = 0;
            this.lblMaxSeats.Text = "Maximum Seats";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.Location = new System.Drawing.Point(260, 148);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(232, 29);
            this.txtFlightNumber.TabIndex = 1;
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            this.txtFlightNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightNumber_KeyPress);
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFlightNumber.Location = new System.Drawing.Point(94, 148);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(156, 26);
            this.lblFlightNumber.TabIndex = 0;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationPort.Location = new System.Drawing.Point(260, 376);
            this.txtDestinationPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.Size = new System.Drawing.Size(232, 29);
            this.txtDestinationPort.TabIndex = 4;
            this.txtDestinationPort.TextChanged += new System.EventHandler(this.txtDestinationPort_TextChanged);
            this.txtDestinationPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestinationPort_KeyPress);
            // 
            // lblDestinationPort
            // 
            this.lblDestinationPort.AutoSize = true;
            this.lblDestinationPort.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationPort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDestinationPort.Location = new System.Drawing.Point(79, 376);
            this.lblDestinationPort.Name = "lblDestinationPort";
            this.lblDestinationPort.Size = new System.Drawing.Size(174, 26);
            this.lblDestinationPort.TabIndex = 0;
            this.lblDestinationPort.Text = "Destination Port";
            // 
            // lblErrorMaxSeats
            // 
            this.lblErrorMaxSeats.AutoSize = true;
            this.lblErrorMaxSeats.BackColor = System.Drawing.Color.Navy;
            this.lblErrorMaxSeats.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMaxSeats.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblErrorMaxSeats.Location = new System.Drawing.Point(256, 200);
            this.lblErrorMaxSeats.Name = "lblErrorMaxSeats";
            this.lblErrorMaxSeats.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMaxSeats.TabIndex = 0;
            // 
            // lblErrorPortOfOrigin
            // 
            this.lblErrorPortOfOrigin.AutoSize = true;
            this.lblErrorPortOfOrigin.BackColor = System.Drawing.Color.Navy;
            this.lblErrorPortOfOrigin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPortOfOrigin.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblErrorPortOfOrigin.Location = new System.Drawing.Point(256, 276);
            this.lblErrorPortOfOrigin.Name = "lblErrorPortOfOrigin";
            this.lblErrorPortOfOrigin.Size = new System.Drawing.Size(0, 19);
            this.lblErrorPortOfOrigin.TabIndex = 0;
            // 
            // lblErrorDestinationPort
            // 
            this.lblErrorDestinationPort.AutoSize = true;
            this.lblErrorDestinationPort.BackColor = System.Drawing.Color.Navy;
            this.lblErrorDestinationPort.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDestinationPort.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblErrorDestinationPort.Location = new System.Drawing.Point(256, 354);
            this.lblErrorDestinationPort.Name = "lblErrorDestinationPort";
            this.lblErrorDestinationPort.Size = new System.Drawing.Size(0, 19);
            this.lblErrorDestinationPort.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 38);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // AddFlight_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(619, 552);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblErrorDestinationPort);
            this.Controls.Add(this.lblErrorPortOfOrigin);
            this.Controls.Add(this.lblErrorMaxSeats);
            this.Controls.Add(this.txtDestinationPort);
            this.Controls.Add(this.lblDestinationPort);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPortOfOrigin);
            this.Controls.Add(this.txtMaxSeats);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblErrorFlightNumber);
            this.Controls.Add(this.lblPortOfOrigin);
            this.Controls.Add(this.lblMaxSeats);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.lblFlightNumber);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Name = "AddFlight_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Flight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFlight_Page_FormClosing);
            this.Load += new System.EventHandler(this.AddFlight_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPortOfOrigin;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblErrorFlightNumber;
        private System.Windows.Forms.Label lblPortOfOrigin;
        private System.Windows.Forms.Label lblMaxSeats;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.Label lblDestinationPort;
        private System.Windows.Forms.Label lblErrorMaxSeats;
        private System.Windows.Forms.Label lblErrorPortOfOrigin;
        private System.Windows.Forms.Label lblErrorDestinationPort;
        private System.Windows.Forms.Button btnBack;
    }
}