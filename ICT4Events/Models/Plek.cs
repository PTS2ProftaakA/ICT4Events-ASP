using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Plek : Database.IDatabase
    {
        //Fields
        private Locatie _locatie;
        private int _nummer;
        private int _capaciteit;
        private List<Specificatie> _specificaties;

        //Properties
        #region Properties
        public Locatie Locatie
        {
            get { return _locatie; }
            set { _locatie = value; }
        }

        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }

        public int Capaciteit
        {
            get { return _capaciteit; }
            set { _capaciteit = value; }
        }

        public List<Specificatie> Specificaties
        {
            get { return _specificaties; }
            set { _specificaties = value; }
        }
        #endregion

        //Constructors
        public Plek(Locatie locatie, int nummer, int capaciteit, List<Specificatie> specificaties)
        {
            this._locatie = locatie;
            this._nummer = nummer;
            this._capaciteit = capaciteit;
            this._specificaties = specificaties;
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