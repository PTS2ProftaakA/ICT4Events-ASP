using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class ProductExemplaar
    {
        private int id;
        private Product product;
        private int volgnummer;
        private int barcode;

        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Volgnummer
        {
            get { return volgnummer; }
            set { volgnummer = value; }
        }

        public int Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

	public ProductExemplaar(int id, Product product, int volgnummer, int barcode)
        {
            this.id = id;
            this.product = product;
            this.volgnummer = volgnummer;
            this.barcode = barcode;
        }

        
    }
}