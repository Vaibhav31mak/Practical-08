namespace FoodDeliverySystem.Domain.Models;

// Abstraction
public abstract class User(string fullName, Address location)
{
    public string FullName { get; } = fullName;
    public Address Location { get; } = location;

    // Abstract method 
    /// <summary>
    /// Returns the roloe description.
    /// Return Type: string.
    /// </summary>
    public abstract string GetRoleDescription();
}