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
        #endregion

        //Constructor
        public Bericht(int id, Account account, DateTime datum, BijdrageType soort, string titel, string inhoud)
            : base(id, account, datum, soort)
        {
            this._titel = titel;
            this._inhoud = inhoud;
        }

        public void Add(Bericht bericht, Database.Database database)
        {

        }

        public void Edit(Bericht bericht, Database.Database database)
        {

        }

        public void Remove(Bericht bericht, Database.Database database)
        {

        }
    }
}