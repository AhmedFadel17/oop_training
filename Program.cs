namespace oop_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1=new Product("mobile",1000);
            Product p2=new Product("laptop",2000);
            Product p3=new Product("tv",3000);
            Cart cart = new Cart();
            cart.AddToCart(p1);
            cart.AddToCart(p2);
            cart.AddToCart(p3);
            cart.RemoveFromCart(p2);
            Paypal paymentMethod=new Paypal();
            OrderProcessing order=new OrderProcessing(paymentMethod);
            order.ProcessPayment();
            OrderStats stats=new OrderStats(cart);
            InvoiceManagement inv=new InvoiceManagement(stats,paymentMethod);
            inv.PrintInvoice();
            Console.ReadLine();
        }
    }
}

