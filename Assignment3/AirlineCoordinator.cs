using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookingManager;

        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights, int bookingIdSeed, int maxBookings)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            bookingManager = new BookingManager(bookingIdSeed, maxBookings);
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public bool addBooking(string bDate, int cId, int flNo)
        {
            if (flManager.flightExists(flNo) && custManager.customerExist(cId))
            {
                return bookingManager.addBooking(bDate, custManager.getCustomer(cId), flManager.getFlight(flNo));
            }
            else
                return false;
        }
        public string flightList()
        {
            return flManager.getFlightList();
        }

        public string customerList()
        {
            return custManager.getCustomerList();
        }

        public string bookingList()
        {
            return bookingManager.getBookingList();
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

    }

}
