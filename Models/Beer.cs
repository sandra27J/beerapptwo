namespace EhizCraftBreweryApp.Models;

/// <summary>
/// This is our beer product model - it stores all the details about
/// each craft beer we sell in the app.
/// </summary>
public class Beer
{
    // Every beer needs an ID number to identify it uniquely
    public int Id { get; set; } = 0;

    // The name of the beer (like "Ehiz IPA" or "Stout Master")
    public string Name { get; set; } = string.Empty;

    // What type of beer this is (IPA, Lager, Stout, etc.)
    public string Style { get; set; } = string.Empty;

    // Alcohol percentage (like 5.5% or 6.8%)
    public double ABV { get; set; } = 0.0;

    // How much the beer costs
    public decimal Price { get; set; } = 0m;

    // Is this beer currently available for purchase?
    public bool IsAvailable { get; set; } = false;

    // Special notes from the brewer about this beer
    public string BreweryNotes { get; set; } = string.Empty;
}