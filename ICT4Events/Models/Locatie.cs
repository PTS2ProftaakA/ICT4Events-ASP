using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Locatie
    {
        //Fields
        private int _id;
        private string _naam;
        private string _straat;
        private int _nr;
        private string _postcode;
        private string _plaats;
        private List<ICT4Events.Models.Event> _events;
        private List<Plek> _plekken;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Straat
        {
            get { return _straat; }
            set { _straat = value; }
        }

        public int Nr
        {
            get { return _nr; }
            set { _nr = value; }
        }

        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public string Plaats
        {
            get { return _plaats; }
            set { _plaats = value; }
        }

        public List<ICT4Events.Models.Event> Events
        {
            get { return _events; }
            set { _events = value; }
        }

        public List<Plek> Plekken
        {
            get { return _plekken; }
            set { _plekken = value; }
        }
        #endregion

        //Constructor
        public Locatie(int id, string naam, string straat, int nr, string postcode, string plaats, List<ICT4Events.Models.Event> events, List<Plek> plekken)
        {
            this._id = id;
            this._naam = naam;
            this._straat = straat;
            this._nr = nr;
            this._postcode = postcode;
            this._plaats = plaats;
            this._events = events;
            this._plekken = plekken;
        }

        public void Add(Locatie locatie, Database.Database database)
        {

        }

        public void Edit(Locatie locatie, Database.Database database)
        {

        }

        public void Remove(Locatie locatie, Database.Database database)
        {

        }
    }
}