namespace FoodDeliverySystem.Domain.Exceptions;

public class InvalidOrderException(string message) : Exception(message);