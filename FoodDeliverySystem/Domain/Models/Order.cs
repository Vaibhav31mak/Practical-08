namespace FoodDeliverySystem.Domain.Models;

// Used primary constructors for better readibility.
public class Order(Customer customer, IEnumerable<FoodItem> items)
{
    private readonly List<FoodItem> _items = items?.ToList() ?? [];
    public Customer Customer { get; } = customer;

    // Used the sum function for list collection rather than running loop to get the total amount.
    public decimal GetTotal() => _items.Sum(item => item.Price);

    /// <summary>
    /// This function attempts to complete the order by using the payment processor and 
    /// throws custom error on failure
    /// </summary>
    /// <param name="paymentProcessor">Specifies the particular payment processor service
    /// to be used. Ideally in real applications it would be injected by DI. But as this is
    /// the console app manual object is used.<param>
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