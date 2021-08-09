using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Data
    {

        private static List<Passenger> passengerDetails = new List<Passenger>();
        private static Queue<Customer> customerDetails = new Queue<Customer>();
        private static List<Airlines> airlinesList = new List<Airlines>();
        private static Stack<Flights> flightDetails = new Stack<Flights>();
        private static Dictionary<string, Logins> loginDict = new Dictionary<string, Logins>();
        private static int UserType;



        public static int USERType
        {
            get { return UserType; }
            set { UserType = value; }
        }
        public static Dictionary<string,Logins> LOGIN
        {
            get { return loginDict; }
        }

        public static List<Passenger> Pass
        {
            get { return passengerDetails; }
        }
        public static Queue<Customer> Queu
        {
            get { return customerDetails; }
        }
        public static Stack<Flights> FlightDET
        {
            get { return flightDetails; }
        }
        public static List<Airlines> AirList
        {
            get
            {
                return airlinesList;
            }

        }
        public List<Passenger> PASS
        {
            get { return passengerDetails; }
        }

        public static void addPassenger()
        {
            Passenger p1 = new Passenger(0, 0, 0);
            Passenger p2 = new Passenger(1, 1, 1);
            Passenger p3 = new Passenger(2, 0, 1);
            Passenger p4 = new Passenger(3, 2, 3);
            Passenger p5 = new Passenger(4, 4, 4);

            passengerDetails.Add(p1);

            passengerDetails.Add(p2);
            passengerDetails.Add(p3);
            passengerDetails.Add(p4);
            passengerDetails.Add(p5);
        }
        public static void addAirlines()
        {

            Airlines a1 = new Airlines(0, "Jet", "Boeing77", 50, "Breakfast");
            Airlines a2 = new Airlines(1, "Jet", "Airbus", 23, "Dinner");
            Airlines a3 = new Airlines(2, "AirCanada", "Nimbus2000", 40, "Lunch");
            Airlines a4 = new Airlines(3, "AirIndia", "Ryuuk", 33, "Breakfast");
            Airlines a5 = new Airlines(4, "Jet", "Genos", 28, "Breakfast");

            Data.AirList.Add(a1);
            Data.AirList.Add(a2);
            Data.AirList.Add(a3);
            Data.AirList.Add(a4);
            Data.AirList.Add(a5);
        }

        public static void addFlights()
        {
            Flights f1 = new Flights(0, 0, "Lisgar", "Chicago", "23-12-12", 2);
            Flights f2 = new Flights(1, 1, "Brampton", "Toronto", "21-11-12", 3);
            Flights f3 = new Flights(2, 2, "Milton", "Mississauga", "20-12-12", 3);
            Flights f4 = new Flights(3, 3, "Brooklyn", "Stanford", "13-12-12", 20);
            Flights f5 = new Flights(4, 4, "Queen", "London", "7-12-12", 13);
            flightDetails.Push(f1);
            flightDetails.Push(f2);
            flightDetails.Push(f3);
            flightDetails.Push(f4);
            flightDetails.Push(f5);
        }
        public static void addCustomer()
        {
            Customer c1 = new Customer(0, "Varghese", "13 Lakersfiled", "v@gmail.com", "2345768907");
            Customer c2 = new Customer(1, "Eldhose", "14 Bakersfiled", "e2@gmail.com", "2349588907");
            Customer c3 = new Customer(2, "Jawaad", "11 Lakersfiled", "J@gmail.com", "23447894");
            Customer c4 = new Customer(3, "Sherin", "11 Lakersfiled", "S@gmail.com", "234789243");
            Customer c5 = new Customer(4, "Ann", "10 Lakersfiled", "Ann@gmail.com", "2345768904");


            
            Data.customerDetails.Enqueue(c1);
            Data.customerDetails.Enqueue(c2);
            Data.customerDetails.Enqueue(c3);
            Data.customerDetails.Enqueue(c4);
            Data.customerDetails.Enqueue(c5);
        }
        public static void addLogins()
        {
            Logins l1 = new Logins(0, "Varghese", "12345", 1);
            Logins l2 = new Logins(1, "Jawaad", "Sheik", 1);
            Logins l3 = new Logins(2, "Spock", "000", 0);
            Logins l4 = new Logins(3, "Cap_Kirk", "1390", 0);
            Logins l5 = new Logins(4, "Yagami", "Kira", 0);

            LOGIN[l1.Username] = l1;
            LOGIN[l2.Username] = l2;
            LOGIN[l3.Username] = l3;
            LOGIN[l4.Username] = l4;
            LOGIN[l5.Username] = l5;
        }
    }
  
    
}
