using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Account
    {
        //Fields
        private int id;
        private string gebruikersnaam;
        private string email;
        private string activatiehash;
        private bool geactiveerd;

        //Properties
        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Activatiehash
        {
            get { return activatiehash; }
            set { activatiehash = value; }
        }

        public bool Geactiveerd
        {
            get { return geactiveerd; }
            set { geactiveerd = value; }
        }
        #endregion

        //Constructor
        public Account(int id, string gebruikersnaam, string email, string activatiehash, bool geactiveerd)
        {
            this.id = id;
            this.gebruikersnaam = gebruikersnaam;
            this.email = email;
            this.activatiehash = activatiehash;
            this.geactiveerd = geactiveerd;
        }
    }
}