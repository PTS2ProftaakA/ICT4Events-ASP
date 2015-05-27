using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Categorie : Bijdrage
    {
        //Fields
        private string naam;

        //Properties
        #region properties
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        #endregion

        //Constructor
        public Categorie(int id, DateTime datum, BijdrageType soort, string naam)
            : base(id, datum, soort)
        {
            this.naam = naam;
        }
    }
}