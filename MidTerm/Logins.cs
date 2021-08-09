using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Logins
    {
        private int ID;
        private string username;
        private string password;
        private int superUser;
       
      
        public Logins()
        {

        }

        public  Logins(int i,string u,string p, int su)
        {
            this.ID = i;
            username = u;
            this.password = p;
            this.superUser = su;
        }

        public int LoginID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public string Username
        { set { this.username = value; }
            get { return this.username; }
        }
        public string Password
        {   set { this.password = value; }
            get { return this.password; }
        }

        public int SuperUser
        {   get { return this.superUser; }
            set { this.superUser = value; }
        }
       
       
       

        
    } 
}
