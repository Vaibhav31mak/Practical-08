namespace FoodDeliverySystem.Infrastructure;
// Abstraction and polymorphism following SOLID
public class UPIPaymentProcessor : IPaymentProcessor
{
    // Abstraction following OCP and DIP.
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI Payment");
        Console.WriteLine($"Successfully processed payment of {amount} through UPI");
        return true;
    }
}