using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Plek
    {
        //Fields
        private int nummer;
        private int capaciteit;
        private List<KeyValuePair<string, string>> specificaties;

        //Properties
        #region Properties
        public int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        public int Capaciteit
        {
            get { return capaciteit; }
            set { capaciteit = value; }
        }

        public List<KeyValuePair<string, string>> Specificaties
        {
            get { return specificaties; }
            set { specificaties = value; }
        }
        #endregion

        //Constructors
        public Plek(int nummer, int capaciteit, List<KeyValuePair<string, string>> specificaties)
        {
            this.nummer = nummer;
            this.capaciteit = capaciteit;
            this.specificaties = specificaties;
        }
    }
}