namespace FoodDeliverySystem.Services.cs;

// Sealed Class as Discount service can't be further inherited.
public sealed class DiscountManager
{
    // Method Overloading
    /// <summary>
    /// Applies the flat discount based on the amount passed as flatDiscount.
    /// Return Type: decimal - higher precision than double.
    /// </summary>
    /// <param name="originalPrice">Specifies the original price.</param>
    /// <param name="flatDiscount">Specifies the flat discount amount.</param>
    public decimal ApplyDiscount(decimal originalPrice, decimal flatDiscount) =>
        Math.Max(0, originalPrice - flatDiscount);

    /// <summary>
    /// Applies the discount based on the Promo Code.
    /// Return Type: decimal - higher precision than double.
    /// </summary>
    /// <param name="originalPrice">Specifies the original price.</param>
    /// <param name="promoCode">Based on the promo code the discount is given. 
    /// Promocodes allowed - SAVE10 (10% dicsount) and WELCOME50 (deduct 50)</param>
    public decimal ApplyDiscount(decimal originalPrice, string promoCode)
    {
        return promoCode switch
        {
            "SAVE10" => originalPrice * 0.9m,
            "WELCOME50" => originalPrice - 50m,
            _ => originalPrice
        };
    }
}