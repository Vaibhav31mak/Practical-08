namespace FoodDeliverySystem.Domain.Interfaces;

// Abstration using interface. Done using abstract class in user
public interface IPaymentProcessor
{
    /// <summary>
    /// Process payment of particular amount using particular payment service which is decided
    /// at runtime by polymorphism using the Dependency Inversion Principle and Open/Closed Principle.
    /// Return Type: bool
    /// </summary>
    /// <param name="amount">Specifies the amount to be processed.</param>
    bool ProcessPayment(decimal amount);
}