namespace oop_training

{
    class Betcoin : PaymentMethod
    {
        public void Pay(){
            Console.WriteLine("Processing Betcoin payment...");
        }
        public string GetName(){
            return "Betcoin";
        }
    }
}