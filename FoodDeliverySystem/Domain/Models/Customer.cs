namespace FoodDeliverySystem.Domain.Models;

// Inheritance
public class Customer(string fullName, Address location, bool isPremium) : User(fullName, location)
{
    public bool IsPremium { get; } = isPremium;

    // Method Overriding
    /// <summary>
    /// Using arrow function returns the type of customer either Premium or the standard Customer.
    /// Return Type: string.
    /// </summary>
    /// <returns></returns>
    public override string GetRoleDescription() => IsPremium ? "Premium Customer" : "Standard Customer";

}