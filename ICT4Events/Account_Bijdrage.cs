using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT4Events
{
    public class Account_Bijdrage
    {
        //Fields
        private int id;
        private Account account;
        private Bijdrage bijdrage;
        private bool like;
        private bool ongewenst;

        //Properties
        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public Bijdrage Bijdrage
        {
            get { return bijdrage; }
            set { bijdrage = value; }
        }

        public bool Like
        {
            get { return like; }
            set { like = value; }
        }

        public bool Ongewenst
        {
            get { return ongewenst; }
            set { ongewenst = value; }
        }
        #endregion

        //Constructor
        public Account_Bijdrage(int id, Account account, Bijdrage bijdrage, bool like, bool ongewenst)
        {
            this.id = id;
            this.account = account;
            this.bijdrage = bijdrage;
            this.like = like;
            this.ongewenst = ongewenst;
        }
    }
}