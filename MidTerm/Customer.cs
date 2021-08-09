using System;
using System.Collections.Generic;
using System.Text;


namespace MidTerm
{
    public class Customer
    {

        private int ID;
        private string name;
        private string address;
        private string email;
        private string phone;
        

        public Customer()
        {

        }
        public Customer(int id,string n,string a,string e,string p)
        {
            this.ID = id;
            this.name = n;
            this.address = a;
            this.email = e;
            this.phone = p;
        }

        public int Customer_ID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public string Cust_Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Cust_Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Cust_email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Cust_Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        
        
        

    }
}
