using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCart //zoo
    {
        //List for the items and prices
        List<ShoppingCartItem> _ShoppingCartItems = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
          
          
        }

       //adds items to list
        public void AddShoppingItem(ShoppingCartItem item)
        {
            _ShoppingCartItems.Add(item);
        }

        //calculate sub total
        public double GetSubTotal()
        {
            double total = 0;

            foreach(ShoppingCartItem shoppingCart in _ShoppingCartItems)
            {
                total = total + shoppingCart.Price;
            }
            return total;
        }

       //calculate vat
        public double GetVat()
        {
           double vat = 0;
            
           vat += 1.15 * GetSubTotal() ;

           return vat;
        }  

        //returns all the items and prices
        public List<ShoppingCartItem>GetShoppingCartItems()
        {
            return _ShoppingCartItems;
        }
    }
}
