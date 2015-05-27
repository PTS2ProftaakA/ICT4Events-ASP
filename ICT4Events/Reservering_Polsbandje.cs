using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Reservering_Polsbandje
    {
        //Fields
        private int id;
        private Reservering reservering;
        private Polsbandje polsbandje;
        private Account account;
        private bool aanwezig;

        //Properties
        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Reservering Reservering
        {
            get { return reservering; }
            set { reservering = value; }
        }

        public Polsbandje Polsbandje
        {
            get { return polsbandje; }
            set { polsbandje = value; }
        }

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public bool Aanwezig
        {
            get { return aanwezig; }
            set { aanwezig = value; }
        }
        #endregion

        //Constructor
        public Reservering_Polsbandje(int id, Reservering reservering, Polsbandje polsbandje, Account account, bool aanwezig)
        {
            this.id = id;
            this.reservering = reservering;
            this.polsbandje = polsbandje;
            this.account = account;
            this.aanwezig = aanwezig;
        }
    }
}