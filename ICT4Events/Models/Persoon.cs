using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Persoon
    {
        //Fields
        private int _id;
        private string _voornaam;
        private string _tussenvoegsel;
        private string _achternaam;
        private string _straat;
        private int _huisnr;
        private string _woonplaats;
        private string _banknr;
        private List<Reservering> _reserveringen;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Tussenvoegsel
        {
            get { return _tussenvoegsel; }
            set { _tussenvoegsel = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        public string Straat
        {
            get { return _straat; }
            set { _straat = value; }
        }

        public int Huisnr
        {
            get { return _huisnr; }
            set { _huisnr = value; }
        }

        public string Woonplaats
        {
            get { return _woonplaats; }
            set { _woonplaats = value; }
        }

        public string Banknr
        {
            get { return _banknr; }
            set { _banknr = value; }
        }

        public List<Reservering> Reserveringen
        {
            get { return _reserveringen; }
            set { _reserveringen = value; }
        }
        #endregion

        //Constructor
        public Persoon(int id, string voornaam, string tussenvoegsel, string achternaam, string straat, string woonplaats, int huisnr, string banknr, List<Reservering> reserveringen)
        {
            this._id = id;
            this._voornaam = voornaam;
            this._tussenvoegsel = tussenvoegsel;
            this._achternaam = achternaam;
            this._straat = straat;
            this._woonplaats = woonplaats;
            this._huisnr = huisnr;
            this._banknr = banknr;
            this._reserveringen = reserveringen;
        }

        public void Add(Persoon persoon, Database.Database database)
        {

        }

        public void Edit(Persoon persoon, Database.Database database)
        {

        }

        public void Remove(Persoon persoon, Database.Database database)
        {

        }
    }
}