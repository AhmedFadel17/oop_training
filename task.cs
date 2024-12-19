// This example is a simple e-commerce order processing system 
// that you need to refactor to make it adhere to SOLID principles.

internal class OrderProcessing
{
    private List<string> cart = new List<string>();
    private string paymentMethod;
    private double totalAmount;

    public void AddToCart(string product)
    {
        cart.Add(product);
        Console.WriteLine($"{product} added to cart.");
    }

    public void RemoveFromCart(string product)
    {
        if (cart.Contains(product))
        {
            cart.Remove(product);
            Console.WriteLine($"{product} removed from cart.");
        }
        else
        {
            Console.WriteLine($"{product} is not in the cart.");
        }
    }

    public void Checkout(string paymentMethod)
    {
        this.paymentMethod = paymentMethod;
        Console.WriteLine($"Checked out with payment method: {paymentMethod}");
    }

    public void ProcessPayment()
    {
        if (paymentMethod == "CreditCard")
        {
            Console.WriteLine("Processing credit card payment...");
        }
        else if (paymentMethod == "PayPal")
        {
            Console.WriteLine("Processing PayPal payment...");
        }
        else
        {
            Console.WriteLine("Invalid payment method.");
        }
    }

    public void PrintInvoice()
    {
        Console.WriteLine("Generating Invoice...");
        Console.WriteLine($"Total Items: {cart.Count}");
        Console.WriteLine($"Total Amount: {totalAmount}");
        Console.WriteLine($"Payment Method: {paymentMethod}");
    }
}
