﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Product : Database.IDatabase
    {
        //Fields
        private int _id;
        private ProductCat _productCategorie;
        private string _merk;
        private string _serie;
        private int _typenummer;
        private int _prijs;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public ProductCat ProductCategorie
        {
            get { return _productCategorie; }
            set { _productCategorie = value; }
        }

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        public int Typenummer
        {
            get { return _typenummer; }
            set { _typenummer = value; }
        }

        public int Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        #endregion

        //Constructors
        public Product(int id, ProductCat productCategorie, string merk, string serie, int typenummer, int prijs)
        {
            this._id = id;
            this._productCategorie = productCategorie;
            this._merk = merk;
            this._serie = serie;
            this._typenummer = typenummer;
            this._prijs = prijs;
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