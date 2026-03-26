namespace FoodDeliverySystem.Domain.Models;

// Composition
public record Address(string Street, string City, string PinCode);

// Using a record here for immutability and value based equality and also primary constructor.
// If one changes the address then new address is assigned. One can't mutate same address.
// For example, if street and city are same, Pincode can't change.