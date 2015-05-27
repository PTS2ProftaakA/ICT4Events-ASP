using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Event
    {
        //Fields
        private int id;
        private string naam;
        private DateTime datumStart;
        private DateTime datumEinde;
        private int maxBezoekers;

        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public DateTime DatumStart
        {
            get { return datumStart; }
            set { datumStart = value; }
        }

        public DateTime DatumEinde
        {
            get { return datumEinde; }
            set { datumEinde = value; }
        }

        public int MaxBezoekers
        {
            get { return maxBezoekers; }
            set { maxBezoekers = value; }
        }

        //Constructor
        public Event(int maxBezoekers, DateTime datumEinde, DateTime datumStart, string naam, int id)
        {
            this.maxBezoekers = maxBezoekers;
            this.datumEinde = datumEinde;
            this.datumStart = datumStart;
            this.naam = naam;
            this.id = id;
        }
    }
}