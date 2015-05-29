using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Bestand : Bijdrage
    {
        //Fields
        private Categorie _categorie;
        private string _bestandsLocatie;
        private int _grootte;

        //Properties
        #region Properties
        public Categorie Categorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }

        public string BestandsLocatie
        {
            get { return _bestandsLocatie; }
            set { _bestandsLocatie = value; }
        }

        public int Grootte
        {
            get { return _grootte; }
            set { _grootte = value; }
        }
        #endregion

        //Constructor
        public Bestand(int id, Account account, DateTime datum, BijdrageType soort, Categorie categorie, string bestandslocatie, int grootte)
            : base(id, account, datum, soort)
        {
            this._categorie = categorie;
            this._bestandsLocatie = bestandslocatie;
            this._grootte = grootte;
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