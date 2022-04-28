using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary1
{
    // follow the steps as object orientation
    public class ShoppingCart
    {
        List<ShoppingCartItem> _ShoppingCartItems = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
            
        }

        public void AddShoppingCartItems(ShoppingCartItem item)
        {
            _ShoppingCartItems.Add(item);
        }

        public List<ShoppingCartItem> MyCartItems()
        {
           return _ShoppingCartItems;

        }

        public double GetSubtotal()
        {
            double subtotal = 0;

            foreach (ShoppingCartItem Item in _ShoppingCartItems)
            {
                Item.product();
                Item.Price();

            }
            return subtotal;
        }
        public double GetVat()
        {

        }
    }   

}
