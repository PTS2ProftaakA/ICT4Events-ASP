using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Bericht : Bijdrage
    {
        //Fields
        private string titel;
        private string inhoud;

        //Properties
        #region properties
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public string Inhoud
        {
            get { return inhoud; }
            set { inhoud = value; }
        }
#endregion

        //Constructor
        public Bericht(int id, DateTime datum, BijdrageType soort, string titel, string inhoud)
            : base(id, datum, soort)
        {
            this.titel = titel;
            this.inhoud = inhoud;
        }
    }
}