namespace FoodDeliverySystem.Domain.Models;

// Inheritance with primary constructor
public class Admin(string fullName, Address location, string employeeId) : User(fullName, location)
{
    public string EmployeeId { get; } = employeeId;

    // Method Overriding

    public override string GetRoleDescription() => $"System Administrator EmployeeId: {EmployeeId}";
}