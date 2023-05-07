using Caliburn.Micro;
using RetailManagerDesktopUI.Library.Api;
using RetailManagerDesktopUI.Library.Model;
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
        IProductEndpiont _productEndpoint;

        public SalesViewModel(IProductEndpiont productEndpiont)
        {
            _productEndpoint = productEndpiont;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var productList = await _productEndpoint.GetAllAsync();
            Products = new BindingList<ProductModel>(productList);
        }

        private BindingList<ProductModel> _products;

        public BindingList<ProductModel> Products
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
