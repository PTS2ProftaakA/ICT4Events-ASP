using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Account : Database.IDatabase
    {
        //Fields
        private int _id;
        private string _gebruikersnaam;
        private string _email;
        private string _activatieHash;
        private bool _geactiveerd;
        private List<Bijdrage> _bijdrages;


        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Gebruikersnaam
        {
            get { return _gebruikersnaam; }
            set { _gebruikersnaam = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Activatiehash
        {
            get { return _activatieHash; }
            set { _activatieHash = value; }
        }

        public bool Geactiveerd
        {
            get { return _geactiveerd; }
            set { _geactiveerd = value; }
        }

        public List<Bijdrage> Bijdrages
        {
            get { return _bijdrages; }
            set { _bijdrages = value; }
        }
        #endregion

        //Constructor
        public Account(int id, string gebruikersnaam, string email, string activatiehash, bool geactiveerd)
        {
            this._id = id;
            this._gebruikersnaam = gebruikersnaam;
            this._email = email;
            this._activatieHash = activatiehash;
            this._geactiveerd = geactiveerd;
        }

        public void Toevoegen(Database.Database database)
        {
            
        }

        public void Aanpassen(Database.Database database)
        {

        }

        public void Verwijderen(Database.Database database)
        {

        }
    }
}