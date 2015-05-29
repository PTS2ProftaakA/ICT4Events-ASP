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
        #endregion

        //Constructor
        public Categorie(int id, Account account, DateTime datum, BijdrageType soort, Categorie categorie, string naam)
            : base(id, account, datum, soort)
        {
            this._categorie = categorie;
            this._naam = naam;
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