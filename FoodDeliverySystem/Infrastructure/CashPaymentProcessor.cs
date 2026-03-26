namespace FoodDeliverySystem.Infrastructure;
// Abstraction and polymorphism following SOLID
public class CashPaymentProcessor : IPaymentProcessor
{
    // Abstraction following OCP and DIP.
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Successfully processed payment of {amount} through cash");
        return true;
    }
}