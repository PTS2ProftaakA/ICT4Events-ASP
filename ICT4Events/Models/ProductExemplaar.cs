using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events.Models
{
    public class ProductExemplaar
    {
        //Fields
        private int _id;
        private Product _product;
        private int _volgnummer;
        private int _barcode;
        private List<Verhuur> _verhuren;

        //Properties
        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public int Volgnummer
        {
            get { return _volgnummer; }
            set { _volgnummer = value; }
        }

        public int Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public List<Verhuur> Verhuren
        {
            get { return _verhuren; }
            set { _verhuren = value; }
        }
        #endregion

        //Constructors
        public ProductExemplaar(int id, Product product, int volgnummer, int barcode, List<Verhuur> verhuren)
        {
            this._id = id;
            this._product = product;
            this._volgnummer = volgnummer;
            this._barcode = barcode;
            this._verhuren = verhuren;
        }
    }
}