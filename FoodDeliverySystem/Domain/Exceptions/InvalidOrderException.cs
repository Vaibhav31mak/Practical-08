namespace FoodDeliverySystem.Domain.Exceptions;

// Custom exception for the invlaid order.
public class InvalidOrderException(string message) : Exception(message);