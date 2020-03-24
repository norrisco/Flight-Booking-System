using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BookingManager
    {
        private static int currentBookingId;
        private int maxNumBookings;
        private int numBookings;
        private Booking[] bookingList;

        public BookingManager(int cbn, int max)
        {
            currentBookingId = cbn;
            maxNumBookings = max;
            numBookings = 0;
            bookingList = new Booking[maxNumBookings];
        }

        public bool addBooking(string bDate, Customer bCust, Flight bFlight)
        {
            if (!(bFlight.addPassenger(bCust))) { return false; }
            bCust.addNumBooking();
            Booking c = new Booking(currentBookingId, bDate, bCust, bFlight);
            currentBookingId++;
            bookingList[numBookings] = c;
            numBookings++;
            return true;
        }

        private int findBooking(int bId)
        {
            for (int x = 0; x < numBookings; x++)
            {
                if (bookingList[x].getBookingId() == bId)
                    return x;
            }
            return -1;
        }

        public bool bookingExist(int bId)
        {
            int loc = findBooking(bId);
            if (loc == -1) { return false; }
            return true;
        }

        public Booking getBooking(int bId)
        {
            int loc = findBooking(bId);
            if (loc == -1) { return null; }
            return bookingList[loc];
        }

        public string getBookingList()
        {
            string s = "";
            for (int x = 0; x < numBookings; x++)
            {
                s = s + "\t" + bookingList[x].getBookingId() + "\t\t" + bookingList[x].getBookingDate() + "\t\t      " + bookingList[x].getBookingFlight().getFlightNumber() + "\t\t    " + bookingList[x].getBookingCustomer().getFirstName() + " " + bookingList[x].getBookingCustomer().getLastName() + "\n";
            }
            return s;
        }

    }

}
