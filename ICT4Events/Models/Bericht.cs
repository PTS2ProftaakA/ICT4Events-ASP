using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Bericht : Bijdrage
    {
        //Fields
        private string _titel;
        private string _inhoud;
        private Bijdrage _bijdrage;

        //Properties
        #region properties
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Inhoud
        {
            get { return _inhoud; }
            set { _inhoud = value; }
        }

        public Bijdrage Bijdrage
        {
            get { return _bijdrage; }
            set { _bijdrage = value; }
        }
        #endregion

        //Constructor
        public Bericht(int id, Account account, DateTime datum, BijdrageType soort, string titel, string inhoud, Bijdrage bijdrage)
            : base(id, account, datum, soort)
        {
            this._titel = titel;
            this._inhoud = inhoud;
            this._bijdrage = bijdrage;
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