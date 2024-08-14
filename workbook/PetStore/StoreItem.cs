using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class StoreItem
    {
        // Fields - Fields are what the class IS, and describe state.
        private string _productID;
        private string _productDescription;
        private double _price;

        // Properties - Getters and Setters.
        public string ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Product ID cannot be set to null, empty, or whitespace.");
                }
                _productID = value.Trim();
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price can not be set less than zero.");
                }
                _price = value;
            }
        }

        public string AdvertisementListing
        {
            get
            {
                return _productDescription.ToUpper();
            }
        }

        public StoreItem()
        {

        }

        public StoreItem(string productID, string productDescription, double price)
        {
            _productID = productID;
            _productDescription = productDescription;
            _price = price;
        }

        public override string ToString()
        {
            return $"Product ID: {_productID}, Product Description: {_productDescription}, Cost: {_price}";
        }
    }
}
