﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem //animals
    {
        //variables for the name of item and price
        public string _name;
        public double _price;
       
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }


        public ShoppingCartItem(string name, double price)
        {
            //create the item and price//Flexible code so that it can take any item in and a price
            _name = name;
            _price = price;
        }
    }
}
