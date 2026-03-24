namespace FoodDeliverySystem.Domain.Models;

public class Order(Customer customer, IEnumerable<FoodItem> items)
{
    private readonly List<FoodItem> _items = items?.ToList() ?? [];
    public Customer Customer { get; } = customer;

    public decimal GetTotal() => _items.Sum(item => item.Price);

    public void Checkout(IPaymentProcessor paymentProcessor)
    {
        if (_items.Count == 0)
            throw new InvalidOrderException("Cannot checkout an empty order.");

        var total = GetTotal();
        bool success = paymentProcessor.ProcessPayment(total);

        if (!success)
            throw new InvalidOrderException("Payment failed due to gateway rejection.");
    }
}