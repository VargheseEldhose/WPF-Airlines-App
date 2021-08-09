using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    public class Passenger
    {
        private int ID;
        private int customerID;
        private int flightID;

        public Passenger()
        {

        }
        public Passenger(int i, int custid, int flid)
        {
            this.ID = i;
            this.customerID = custid;
            this.flightID =flid;
        }
        public int PassengerID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }
        public int CustomerID_Pasenger
        {
            set { this.customerID = value; }
            get { return this.customerID; }
        }

        public int FlightID_passenger
        { set { this.flightID = value; }
            get { return this.flightID;
            }
        }
    }
}
