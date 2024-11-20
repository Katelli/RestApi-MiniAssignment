using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/search-engines")]

public class SearchEnginesController : ControllerBase
{
    /*
    Created the default data on the GET endpoint
    The descriptions has been generated with ChatGPT
    */
    private static List<SearchEngines> searchEngines = new List<SearchEngines>
    {
        new SearchEngines(
            "Google",
            "Google",
            1997,
            "The most widely used search engine globally, Google is known for its fast, accurate, and highly personalized search results. It uses sophisticated algorithms, including machine learning and AI, to refine search results based on user behavior, location, and preferences. Google also offers a wide range of services like Gmail, Google Maps, and YouTube."
        ),
        new SearchEngines(
            "Microsoft Bing", 
            "Microsoft", 
            2009, 
            "Bing is Microsoft's search engine, known for its attractive visual design and integration with Microsoft’s other products, such as Office and Windows. It offers features like image search, video previews, and rewards for using the service. Bing also provides an AI-powered experience and often integrates with Cortana, Microsoft’s digital assistant."
            ),
        new SearchEngines(
            "DuckDuckGo", 
            "Duck Duck Go Inc",
            2008,
            "A privacy-focused search engine that does not track or store personal information about its users. DuckDuckGo emphasizes user anonymity and displays results from various sources, including its own web crawler and other search engines, without personalized tracking.")
    };

    [HttpGet]
    public IEnumerable<SearchEngines> Get()
    {
        return searchEngines;
    }

    [HttpPost]
    public IActionResult Post ([FromBody] SearchEngines _searchEngines)
    {
        if(searchEngines == null)
        {
            return BadRequest("Client error occured");
        }
        searchEngines.Add(_searchEngines);
        return CreatedAtAction(nameof(Post), new {title = _searchEngines.Title, owner = _searchEngines.Owner, description = _searchEngines.Description}, _searchEngines);
    }
}
    