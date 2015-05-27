using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Polsbandje
    {
        private int id;
        private string barcode;
        private bool actief;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public bool Actief
        {
            get { return actief; }
            set { actief = value; }
        }

        public Polsbandje(int id, string barcode, bool actief)
        {
            this.id = id;
            this.barcode = barcode;
            this.actief = actief;
        }
    }
}