namespace oop_training
{
    internal class OrderProcessing
    {
        private PaymentMethod paymentMethod;
        public OrderProcessing(PaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
            Console.WriteLine($"Checked out with payment method: {paymentMethod.GetName()}");
        }
        public void ProcessPayment()
        {
            paymentMethod.Pay();
        }
    }

}