using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Plek : Database.IDatabase<Plek>
    {
        //Fields
        private Locatie _locatie;
        private int _nummer;
        private int _capaciteit;
        private List<Plek_Reservering> _plekReserveringen;
        private List<KeyValuePair<string, string>> _specificaties;

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

        public List<Plek_Reservering> PlekReserveringen
        {
            get { return _plekReserveringen; }
            set { _plekReserveringen = value; }
        }

        public List<KeyValuePair<string, string>> Specificaties
        {
            get { return _specificaties; }
            set { _specificaties = value; }
        }
        #endregion

        //Constructors
        public Plek(Locatie locatie, int nummer, int capaciteit, List<Plek_Reservering> plekReserveringen, List<KeyValuePair<string, string>> specificaties)
        {
            this._locatie = locatie;
            this._nummer = nummer;
            this._capaciteit = capaciteit;
            this._plekReserveringen = plekReserveringen;
            this._specificaties = specificaties;
        }

        public void Toevoegen(Plek plek, Database.Database database)
        {

        }

        public void Aanpassen(Plek plek, Database.Database database)
        {

        }

        public void Verwijderen(Plek plek, Database.Database database)
        {

        }
    }
}