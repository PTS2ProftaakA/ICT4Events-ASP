using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICT4Events.Database;

namespace ICT4Events.Models
{
    public class Specificatie : IDatabase
    {
        //Fields
        private int _id;
        private string _waarde;

        //Properties
        #region properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Plek Plek
        {
            get { return _plek; }
            set { _plek = value; }
        }

        public string Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }
        #endregion

        //Constructor
        public Specificatie(int id, string waarde)
        {
            this._id = id;
            this._waarde = waarde;
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