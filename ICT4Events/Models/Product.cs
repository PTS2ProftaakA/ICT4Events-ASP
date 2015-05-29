using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class Product
    {
        //Fields
        private int _id;
        private ProductCat _productCategorie;
        private string _merk;
        private string _serie;
        private int _typenummer;
        private int _prijs;
        private List<ProductExemplaar> _productExemplaren;

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

        public List<ProductExemplaar> ProductExemplaren
        {
            get { return _productExemplaren; }
            set { _productExemplaren = value; }
        }
        #endregion

        //Constructors
        public Product(int id, ProductCat productCategorie, string merk, string serie, int typenummer, int prijs, List<ProductExemplaar> productExemplaren)
        {
            this._id = id;
            this._productCategorie = productCategorie;
            this._merk = merk;
            this._serie = serie;
            this._typenummer = typenummer;
            this._prijs = prijs;
            this._productExemplaren = productExemplaren;
        }

        public void Add(Product product, Database.Database database)
        {

        }

        public void Edit(Product product, Database.Database database)
        {

        }

        public void Remove(Product product, Database.Database database)
        {

        }
    }
}