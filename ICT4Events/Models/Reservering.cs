using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Reservering
    {
        //Fields
        private int _id;
        private Persoon _persoon;
        private DateTime _datumStart;
        private DateTime _datumEinde;
        private bool _betaald;
        private List<Plek_Reservering> _plekReserveringen;
        private List<Reservering_Polsbandje> _reserveringPolsbandjes;

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

        public List<Plek_Reservering> PlekReserveringen
        {
            get { return _plekReserveringen; }
            set { _plekReserveringen = value; }
        }

        public List<Reservering_Polsbandje> ReserveringPolsbandjes
        {
            get { return _reserveringPolsbandjes; }
            set { _reserveringPolsbandjes = value; }
        }
        #endregion

        //Constructor
        public Reservering(int id, Persoon persoon, DateTime datumStart, DateTime datumEinde, bool betaald, List<Plek_Reservering> plekReserveringen, List<Reservering_Polsbandje> reserveringPolsbandjes)
        {
            this._id = id;
            this._persoon = persoon;
            this._datumStart = datumStart;
            this._datumEinde = datumEinde;
            this._betaald = betaald;
            this._plekReserveringen = plekReserveringen;
            this._reserveringPolsbandjes = reserveringPolsbandjes;
        }

        public void Add(Reservering reservering, Database.Database database)
        {

        }

        public void Edit(Reservering reservering, Database.Database database)
        {

        }

        public void Remove(Reservering reservering, Database.Database database)
        {

        }
    }
}