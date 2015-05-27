using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Locatie
    {
        //Fields
        private int id;
        private string naam;
        private string straat;
        private int nr;
        private string postcode;
        private string plaats;
        
        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Straat
        {
            get { return straat; }
            set { straat = value; }
        }

        public int Nr
        {
            get { return nr; }
            set { nr = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string Plaats
        {
            get { return plaats; }
            set { plaats = value; }
        }

        //Constructor
        public Locatie(int id, string naam, string straat, int nr, string postcode, string plaats)
        {
            this.id = id;
            this.naam = naam;
            this.straat = straat;
            this.nr = nr;
            this.postcode = postcode;
            this.plaats = plaats;
        }
    }
}