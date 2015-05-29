﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class ProductCat : Database.IDatabase
    {
        //Fields
        private int _id;
        private ProductCat _productCat;
        private string _naam;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public ProductCat SubProductCat
        {
            get { return _productCat; }
            set { _productCat = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        #endregion

        //Constructors
        public ProductCat(int id, ProductCat productCat, string naam)
        {
            this._id = id;
            this._productCat = productCat;
            this._naam = naam;
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