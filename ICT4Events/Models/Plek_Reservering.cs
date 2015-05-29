using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Plek_Reservering : Database.IDatabase<Plek_Reservering>
    {
        //Fields
        private int _id;
        private Plek _plek;
        private Reservering _reservering;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Plek Plek
        {
            get { return _plek; }
            set { _plek = value; }
        }

        public Reservering Reservering
        {
            get { return _reservering; }
            set { _reservering = value; }
        }
        #endregion

        //Constructors
        public Plek_Reservering(int id, Plek plek, Reservering reservering)
        {
            this._id = id;
            this._plek = plek;
            this._reservering = reservering;
        }

        public void Toevoegen(Plek_Reservering plekReservering, Database.Database database)
        {

        }

        public void Aanpassen(Plek_Reservering plekReservering, Database.Database database)
        {

        }

        public void Verwijderen(Plek_Reservering plekReservering, Database.Database database)
        {

        }
    }
}