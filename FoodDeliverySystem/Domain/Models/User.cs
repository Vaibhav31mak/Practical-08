namespace FoodDeliverySystem.Domain.Models;

// Abstraction
public abstract class User(string fullName, Address location)
{
    public string FullName { get; } = fullName;
    public Address Location { get; } = location;

    // Abstract method 
    public abstract string GetRoleDescription();
}