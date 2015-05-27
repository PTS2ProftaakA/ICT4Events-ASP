using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Reservering
    {
        //Fields
        private int id;
        private DateTime datumStart;
        private DateTime datumEinde;
        private bool betaald;
        
        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public bool Betaald
        {
            get { return betaald; }
            set { betaald = value; }
        }

        //Constructor
        public Reservering(int id, DateTime datumStart, DateTime datumEinde, bool betaald)
        {
            this.id = id;
            this.datumStart = datumStart;
            this.datumEinde = datumEinde;
            this.betaald = betaald;
        }
    }
}