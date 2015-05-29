using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Reservering : Database.IDatabase
    {
        //Fields
        private int _id;
        private Persoon _persoon;
        private DateTime _datumStart;
        private DateTime _datumEinde;
        private bool _betaald;
        private Plek _plek;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Persoon Persoon
        {
            get { return _persoon; }
            set { _persoon = value; }
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

        public bool Betaald
        {
            get { return _betaald; }
            set { _betaald = value; }
        }

        public Plek Plek
        {
            get { return _plek; }
            set { _plek = value; }
        }
        #endregion

        //Constructor
        public Reservering(int id, Persoon persoon, DateTime datumStart, DateTime datumEinde, bool betaald, Plek plek)
        {
            this._id = id;
            this._persoon = persoon;
            this._datumStart = datumStart;
            this._datumEinde = datumEinde;
            this._betaald = betaald;
            this._plek = plek;
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