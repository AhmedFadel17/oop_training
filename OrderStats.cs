namespace oop_training
{
    internal class OrderStats
    {
        private Cart cart;
        public OrderStats(Cart cart)
        {
            this.cart = cart;
        }
        public int GetTotalPrice(){
            int total=0;
            foreach (Product p in cart.GetCart()){
                total += p.GetPrice();
            }
            return total;
        }

        public int GetTotalItems(){
            return cart.GetCart().Count;
        }
    }

}