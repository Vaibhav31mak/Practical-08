namespace FoodDeliverySystem.Domain.Interfaces;
// Abstration using interface. Done using abstract class in user
public interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount);
}