namespace FoodDeliverySystem.Services.cs;

// Sealed Class
public sealed class DiscountManager
{
    // Method Overloading
    public decimal ApplyDiscount(decimal originalPrice, decimal flatDiscount) =>
        Math.Max(0, originalPrice - flatDiscount);

    public decimal ApplyDiscount(decimal originalPrice, string promoCode)
    {
        if (promoCode == "SAVE10") return originalPrice * 0.9m;
        if (promoCode == "WELCOME50") return Math.Max(0, originalPrice - 50m);
        return originalPrice;
    }
}