﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Polsbandje
    {
        //Fields
        private int _id;
        private string _barcode;
        private bool _actief;
        private List<Reservering_Polsbandje> _reserveringPolsbandjes;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public bool Actief
        {
            get { return _actief; }
            set { _actief = value; }
        }

        public List<Reservering_Polsbandje> ReserveringPolsbandjes
        {
            get { return _reserveringPolsbandjes; }
            set { _reserveringPolsbandjes = value; }
        }
        #endregion

        //Constructor
        public Polsbandje(int id, string barcode, bool actief, List<Reservering_Polsbandje> reserveringPolsbandjes)
        {
            this._id = id;
            this._barcode = barcode;
            this._actief = actief;
            this._reserveringPolsbandjes = reserveringPolsbandjes;
        }
    }
}