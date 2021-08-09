using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
   public class Flights
    {
        private int ID;
        private int airlineID;
        private string departureCity;
        private string destinationCity;
        private string departureDate;
        private double flightTime;
        public Flights()
        {
            
        }

        public Flights(int i,int aid, string deptC,string destC,string deptT,double time)
        {
            this.ID = i;
            this.airlineID = aid;
            this.departureCity = deptC;
            this.destinationCity = destC;
            this.DepartureDate = deptT;
            this.flightTime = time;

        }
        public int FlightID
        { get { return this.ID; } set { this.ID = value; } }

        public int AirlineID
        {
            get { return this.airlineID; }
            set { this.airlineID = value; }
        }

        public string DepartureCity
        {
            get { return this.departureCity; }
            set { this.departureCity = value; }
        }
        public double FlightTime
        {
            get { return this.flightTime; }
            set
            {
                this.flightTime = value;
            }
        }

        public string DestinationCity
        {
            get { return this.destinationCity; }
            set { this.destinationCity = value; }
        }

        public string DepartureDate
        {
            get { return this.departureDate; }
            set { this.departureDate = value; }
        }
       

    }
  

}
