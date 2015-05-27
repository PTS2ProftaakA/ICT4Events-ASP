using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Persoon
    {
        //Fields
        private int id;
        private string voornaam;
        private string tussenvoegsel;
        private string achternaam;
        private string straat;
        private int huisnr;
        private string woonplaats;
        private string banknr;
        
        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Tussenvoegsel
        {
            get { return tussenvoegsel; }
            set { tussenvoegsel = value; }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public string Straat
        {
            get { return straat; }
            set { straat = value; }
        }

        public int Huisnr
        {
            get { return huisnr; }
            set { huisnr = value; }
        }

        public string Woonplaats
        {
            get { return woonplaats; }
            set { woonplaats = value; }
        }

        public string Banknr
        {
            get { return banknr; }
            set { banknr = value; }
        }

        
        //Constructor
        public Persoon(int id, string voornaam, string tussenvoegsel, string achternaam, string straat, string woonplaats, int huisnr, string banknr)
        {
            this.id = id;
            this.voornaam = voornaam;
            this.tussenvoegsel = tussenvoegsel;
            this.achternaam = achternaam;
            this.straat = straat;
            this.woonplaats = woonplaats;
            this.huisnr = huisnr;
            this.banknr = banknr;
        }
    }
}