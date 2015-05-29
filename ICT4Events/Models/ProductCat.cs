using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class ProductCat : Database.IDatabase<ProductCat>
    {
        //Fields
        private int _id;
        private ProductCat _productCat;
        private string _naam;
        private List<Product> _producten;

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

        public List<Product> Producten
        {
            get { return _producten; }
            set { _producten = value; }
        }
        #endregion

        //Constructors
        public ProductCat(int id, ProductCat productCat, string naam, List<Product> producten)
        {
            this._id = id;
            this._productCat = productCat;
            this._naam = naam;
            this._producten = producten;
        }

        public void Toevoegen(ProductCat productCat, Database.Database database)
        {

        }

        public void Aanpassen(ProductCat productCat, Database.Database database)
        {

        }

        public void Verwijderen(ProductCat productCat, Database.Database database)
        {

        }
    }
}