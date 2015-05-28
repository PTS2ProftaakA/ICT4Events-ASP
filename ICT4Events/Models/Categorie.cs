using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Categorie : Bijdrage
    {
        //Fields
        private Categorie _categorie;
        private string _naam;
        private List<Bestand> _bestanden;

        //Properties
        #region Properties
        public Categorie SubCategorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public List<Bestand> Bestanden
        {
            get { return _bestanden; }
            set { _bestanden = value; }
        }
        #endregion

        //Constructor
        public Categorie(int id, Account account, DateTime datum, BijdrageType soort, Categorie categorie, string naam, List<Bestand> bestanden)
            : base(id, account, datum, soort)
        {
            this._categorie = categorie;
            this._naam = naam;
            this._bestanden = bestanden;
        }
    }
}