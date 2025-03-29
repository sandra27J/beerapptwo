namespace EhizCraftBreweryApp.Models;

/// <summary>
/// Tracks customer orders for beer purchases and event tickets.
/// Includes delivery status and payment details.
/// </summary>
public class Order
{
    public int OrderId { get; set; }                          // Unique order number
    public string UserId { get; set; } = string.Empty;       // Links to User model
    public List<OrderItem> Items { get; set; } = new();      // Beers/events purchased
    public decimal TotalAmount { get; set; }                 // Order subtotal
    public string DeliveryAddress { get; set; } = string.Empty; 
    public DateTime OrderDate { get; set; } = DateTime.Now;  
    public string Status { get; set; } = "Pending";          // e.g., Shipped, Cancelled
}

/// <summary>
/// Nested class for individual order items (beers/events).
/// </summary>
public class OrderItem
{
    public int ProductId { get; set; }      // ID of beer or event
    public string ProductType { get; set; } = string.Empty; // "Beer" or "Event"
    public int Quantity { get; set; }       // Number of items
    public decimal UnitPrice { get; set; }  // Price per item
}