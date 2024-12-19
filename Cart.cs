using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_training
{
    // Refactored Code
    internal class Cart : CAdding,CRemoving
    {
        private List<Product> cart;
        public Cart()
        {
            cart = new List<Product>();
        }
        public List<Product> GetCart()
        {
            return cart;
        }

        public void AddToCart(Product product)
        {
            cart.Add(product);
            Console.WriteLine($"{product.GetName()} added to cart.");
        }

        public void RemoveFromCart(Product product)
        {
            if (cart.Contains(product))
            {
                cart.Remove(product);
                Console.WriteLine($"{product.GetName()} removed from cart.");
            }
            else
            {
                Console.WriteLine($"{product.GetName()} is not in the cart.");
            }
        }

    }
    // seperate Cart management (single responsability)
}
