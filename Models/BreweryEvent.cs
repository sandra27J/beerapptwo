namespace EhizCraftBreweryApp.Models;

/// <summary>
/// This model keeps track of all the cool events our brewery hosts,
/// like tastings, tours, and parties.
/// </summary>
public class BreweryEvent
{
    // Unique ID number for each event
    public int EventId { get; set; } = 0;

    // The name of the event (like "Summer Beer Festival")
    public string Title { get; set; } = string.Empty;

    // When the event is happening
    public DateTime EventDate { get; set; } = DateTime.Now;

    // Where the event takes place
    public string Location { get; set; } = string.Empty;

    // Maximum number of people who can attend
    public int MaxAttendees { get; set; } = 0;

    // Cost to attend the event
    public decimal TicketPrice { get; set; } = 0m;

    // Is the event already sold out?
    public bool IsSoldOut { get; set; } = false;
}