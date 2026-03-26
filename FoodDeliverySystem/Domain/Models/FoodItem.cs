namespace FoodDeliverySystem.Domain.Models;

// Standard Class with primary constructor
public class FoodItem(string name, decimal price, bool isVegetarian)
{
    public string Name { get; } = name;
    public decimal Price { get; } = price;
    public bool IsVegetarian { get; } = isVegetarian;
}