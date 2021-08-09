using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
   public class Airlines
    {

        private int ID;
        private string name;
        private string airplane;
        private int seatsAvailable;
        private string mealsAvailable;

        public Airlines()
        {
            
        }
        public Airlines(int i,string n,string airp,int no_seats,string mealAvail)
        {
            this.ID = i;
            this.name = n;
            this.airplane = airp;
            this.seatsAvailable = no_seats;
            this.mealsAvailable = mealAvail;
        }

        public int AirlinesID
        { get { return this.ID; }
            set { this.ID = value; }
        }
        public string NameAirlines
        {
            get { return this.name; }
            set { this.name= value; }
        }
        public  string Airplane
        {
            get { return this.airplane; }
            set { this.airplane = value; }
        }
        public int SeatsAvailable
        {
            get { return this.seatsAvailable; }
            set
            {
                this.seatsAvailable = value;
            }
        }
        public string MealsAvailable
        { set { this.mealsAvailable = value; }
            get { return this.mealsAvailable; }
        }


    }

}
