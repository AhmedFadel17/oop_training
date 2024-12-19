namespace oop_training
{
    internal class InvoiceManagement
    {
        private PaymentMethod paymentMethod;
        private OrderStats stats;
        public InvoiceManagement(OrderStats stats, PaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
            this.stats = stats;
        }
        public void ProcessPayment()
        {
            paymentMethod.Pay();
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Generating Invoice...");
            Console.WriteLine($"Total Items: {stats.GetTotalItems()}");
            Console.WriteLine($"Total Amount: {stats.GetTotalPrice()}");
            Console.WriteLine($"Payment Method: {paymentMethod.GetName()}");
        }
    }

}