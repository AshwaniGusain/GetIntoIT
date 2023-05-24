using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class MapsController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public MapsController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpGet("directions")]
    public async Task<ActionResult<string>> GetDirections(string origin, string destination)
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"https://maps.googleapis.com/maps/api/directions/json?origin={origin}&destination={destination}&key=AIzaSyBO9WcJtwPuOrnzgvy-2qmGy_7RbFhgcAw");
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }

}
