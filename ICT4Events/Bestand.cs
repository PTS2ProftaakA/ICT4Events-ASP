using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Bestand : Bijdrage
    {
        //Fields
        private string bestandslocatie;
        private int grootte;

        //Properties
        #region properties
        public string Bestandslocatie
        {
            get { return bestandslocatie; }
            set { bestandslocatie = value; }
        }

        public int Grootte
        {
            get { return grootte; }
            set { grootte = value; }
        }
        #endregion

        //Constructor
        public Bestand(int id, DateTime datum, BijdrageType soort, string bestandslocatie, int grootte)
            : base(id, datum, soort)
        {
            this.bestandslocatie = bestandslocatie;
            this.grootte = grootte;
        }
    }
}