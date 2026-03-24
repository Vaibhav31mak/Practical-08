namespace FoodDeliverySystem.Domain.Models;

// Inheritance
public class Customer(string fullName, Address location, bool isPremium) : User(fullName, location)
{
    public bool IsPremium { get; } = isPremium;

    // Method Overriding
    public override string GetRoleDescription()
    {
        return IsPremium ? "Premium Customer" : "Standard Customer";
    }
}