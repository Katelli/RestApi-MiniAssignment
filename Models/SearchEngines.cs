using Microsoft.AspNetCore.Components.Web;

public class SearchEngines
{
    private static int _id = 1;
    public string Title { get; set; }
    public int Id { get; set; }
    public string Owner { get; set; }
    public int LaunchYear { get; set; }
    public string Description { get; set; }

     public SearchEngines(string title, string owner, int launchYear, string description)
     {
         Title = title;
         Id = _id++;
         Owner = owner;
         LaunchYear = launchYear;
         Description = description;
     }
}