using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Event : Database.IDatabase<Event>
    {
        //Fields
        private int _id;
        private Locatie _locatie;
        private string _naam;
        private DateTime _datumStart;
        private DateTime _datumEinde;
        private int _maxBezoekers;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Locatie Locatie
        {
            get { return _locatie; }
            set { _locatie = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public DateTime DatumStart
        {
            get { return _datumStart; }
            set { _datumStart = value; }
        }

        public DateTime DatumEinde
        {
            get { return _datumEinde; }
            set { _datumEinde = value; }
        }

        public int MaxBezoekers
        {
            get { return _maxBezoekers; }
            set { _maxBezoekers = value; }
        }
        #endregion

        //Constructor
        public Event(int id, Locatie locatie, string naam, DateTime datumStart, DateTime datumEinde, int maxBezoekers)
        {
            this._id = id;
            this._locatie = locatie;
            this._naam = naam;
            this._datumStart = datumStart;
            this._datumEinde = datumEinde;
            this._maxBezoekers = maxBezoekers;
        }

        public void Toevoegen(Event thisEvent, Database.Database database)
        {

        }

        public void Aanpassen(Event thisEvent, Database.Database database)
        {

        }

        public void Verwijderen(Event thisEvent, Database.Database database)
        {

        }
    }
}