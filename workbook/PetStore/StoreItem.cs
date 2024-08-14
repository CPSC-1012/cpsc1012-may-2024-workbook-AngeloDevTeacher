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
    }
}
