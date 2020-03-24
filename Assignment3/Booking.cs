using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Booking
    {
        private int bookingId;
        private string bookingDate;
        private Customer bookingCustomer;
        private Flight bookingFlight;

        public Booking(int bId, string bDate, Customer bCust, Flight bFlight)
        {
            bookingId = bId;
            bookingDate = bDate;
            bookingCustomer = bCust;
            bookingFlight = bFlight;
        }

        public int getBookingId() { return bookingId; }
        public string getBookingDate() { return bookingDate; }
        public Customer getBookingCustomer() { return bookingCustomer; }
        public Flight getBookingFlight() { return bookingFlight; }

        public string toString()
        {
            string s = "Booking " + bookingId;
            s = s + "\nBooking Date " + bookingDate;
            s = s + "\nCustomer " + bookingCustomer.getFirstName() + " " + bookingCustomer.getLastName();
            s = s + "\nFlight " + bookingFlight.getFlightNumber();
            return s;
        }

    }

}
