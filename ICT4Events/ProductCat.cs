using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class ProductCat
    {
        private int id;
        private ProductCat productCat;
        private string naam;
        private List<Product> producten;

        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ProductCat ProductCat1
        {
            get { return productCat; }
            set { productCat = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public List<Product> Producten
        {
            get { return producten; }
            set { producten = value; }
        }
	
	public ProductCat(int id, ProductCat productCat, string naam)
        {
            this.id = id;
            this.productCat = productCat;
            this.naam = naam;
        }
        

    }
}