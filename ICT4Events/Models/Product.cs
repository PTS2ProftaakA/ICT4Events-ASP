using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Product
    {
        //Fields
        private int id;
        private string merk;
        private string serie;
        private int typenummer;
        private int prijs;
        private List<ProductExemplaar> productExemplaren;
        private ProductCat productCategorie;

        //Properties
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        public int Typenummer
        {
            get { return typenummer; }
            set { typenummer = value; }
        }

        public int Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }
        #endregion

        //Constructors
        public Product(int id, string merk, string serie, int typenummer, int prijs)
        {
            this.id = id;
            this.merk = merk;
            this.serie = serie;
            this.typenummer = typenummer;
            this.prijs = prijs;
        }

        
    }
}