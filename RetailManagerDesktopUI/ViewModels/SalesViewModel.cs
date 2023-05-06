﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.ViewModels
{
    public class SalesViewModel: Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get { return _products; }
            set 
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set 
            { 
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string SubTotal 
        {
            get
            {
                return "$ 0.00";
            }
        }

        public string Tax
        {
            get
            {
                return "$ 0.00";
            }
        }

        public string Total
        {
            get
            {
                return "$ 0.00";
            }
        }


        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public bool CanAddTocart
        {
            get
            { 

                

                return false;
            }

        }


        public void AddToCart()
        {

        }

        public bool CanRemoveFromcart
        {
            get
            {



                return false;
            }

        }


        public void RemoveFromcart()
        {

        }

        public bool CanCheckOut
        {
            get
            {



                return false;
            }

        }


        public void CheckOut()
        {

        }
    }
}