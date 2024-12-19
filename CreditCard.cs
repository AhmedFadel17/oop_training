namespace oop_training

{
    class CreditCard : PaymentMethod
    {
        public void Pay(){
            Console.WriteLine("Processing CreditCard payment...");
        }
        public string GetName(){
            return "Credit Card PayPal";
        }
    }
}