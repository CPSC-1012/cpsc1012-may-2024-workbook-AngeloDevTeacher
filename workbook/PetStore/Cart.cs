﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class Cart
    {
        private int _cartID;
        private DateTime _cartDate;
        private List<StoreItem> _items;


        public Cart()
        {
            _items = new List<StoreItem>();
        }


        public DateTime CartDate
        {
            get
            {
                return _cartDate;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Date cannot be in the future");
                }
                _cartDate = value;
            }

        }
        // Public property for our items.
        public List<StoreItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Cart list can be empty, but MUST exist (cannot be null)");
                }
                _items = value;
            }
        }
    }
}
