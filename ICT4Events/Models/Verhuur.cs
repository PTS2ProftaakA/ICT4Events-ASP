using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Verhuur
    {
        //Fields
        private int id;
        private DateTime datumIn;
        private DateTime datumUit;
        private int prijs;
        private bool betaald;
        private ProductExemplaar productExemplaar;

        //Properties
        #region Properties
        public DateTime DatumIn
        {
            get { return datumIn; }
            set { datumIn = value; }
        }

        public DateTime DatumUit
        {
            get { return datumUit; }
            set { datumUit = value; }
        }

        public int Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        public bool Betaald
        {
            get { return betaald; }
            set { betaald = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        //Constructors
        public Verhuur(int id, DateTime datumIn, DateTime datumUit, int prijs, bool betaald, ProductExemplaar productExemplaar)
        {
            this.id = id;
            this.datumIn = datumIn;
            this.datumUit = datumUit;
            this.prijs = prijs;
            this.betaald = betaald;
            this.productExemplaar = productExemplaar;
        }
    }
}