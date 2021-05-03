using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new();

        public ShoppingCart()
        {
        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public decimal TotalPrice 
        { 
            get
            {
                decimal totalPrice = 0;
                Items.ForEach(a => totalPrice += a.Price * a.Quantity);

                return totalPrice;
            }
        }
    }
}
