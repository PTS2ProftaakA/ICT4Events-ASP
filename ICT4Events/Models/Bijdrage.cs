using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public abstract class Bijdrage
    {
        public enum  BijdrageType
        {
            Categorie,
            Bestand,
            Bericht
        }

        //Fields
        private int id;
        //private Account account;
        private DateTime datum;
        private BijdrageType soort;

        //Properties
        #region properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public BijdrageType Soort
        {
            get { return soort; }
            set { soort = value; }
        }
        #endregion

        //Constructor
        public Bijdrage(int id, DateTime datum, BijdrageType soort)
        {
            this.id = id;
            this.datum = datum;
            this.soort = soort;
        }
    }
}