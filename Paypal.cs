namespace oop_training

{
    class Paypal : PaymentMethod
    {
        public void Pay(){
            Console.WriteLine("Processing PayPal payment...");
        }
        public string GetName(){
            return "PayPal";
        }
    }
}