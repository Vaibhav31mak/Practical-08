namespace FoodDeliverySystem.Domain.Models;

// Inheritance with primary constructor
public class Admin(string fullName, Address location, string employeeId) : User(fullName, location)
{
    public string EmployeeId { get; } = employeeId;

    // Method Overriding
    /// <summary>
    /// Using arrow function returns the Role description for particular employee which would be
    /// admin in this case as its overriden.
    /// Return Type: void.
    /// </summary>
    public override string GetRoleDescription() => $"System Administrator EmployeeId: {EmployeeId}";
}