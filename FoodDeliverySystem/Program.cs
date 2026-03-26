IPaymentProcessor paymentProcessor = new UPIPaymentProcessor();
DiscountManager discountManager = new DiscountManager();

try
{
    Console.WriteLine("Starting Food Delivery App");

    var hqAddress = new Address("Makarba", "Ahmedabad", "123456");
    User systemAdmin = new Admin("Madhav", hqAddress, "012345");
    Console.WriteLine($"Actor Logged In: {systemAdmin.GetRoleDescription()}");

    var homeAddress = new Address("Station River", "Savarkundla", "364515");
    var customer = new Customer("Vaibhav", homeAddress, isPremium: true);
    Console.WriteLine($"Actor Logged In: {customer.GetRoleDescription()}");

    var pizza = new FoodItem("Margherita Pizza", 120.00m, true);
    var pasta = new FoodItem("White Sauce Pasta", 80.50m, true);

    var order = new Order(customer, [pizza, pasta]);

    var subtotal = order.GetTotal();
    Console.WriteLine($"Subtotal: {subtotal}");

    var finalTotal = discountManager.ApplyDiscount(subtotal, "WELCOME50");
    Console.WriteLine($"Final Total after WELCOME50 promo: {finalTotal}");

    Console.WriteLine($"Initiating checkout for {customer.FullName} delivering to {customer.Location.City}.");
    order.Checkout(paymentProcessor);

    Console.WriteLine("Order placed successfully!");
}
catch (InvalidOrderException ex)
{
    Console.WriteLine($"Domain Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"System Error: {ex.Message}");
}

Console.ReadKey();