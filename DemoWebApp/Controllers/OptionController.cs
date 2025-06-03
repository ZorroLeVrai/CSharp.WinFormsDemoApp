using Microsoft.AspNetCore.Mvc;
using MyLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OptionController : ControllerBase
{
    // GET: api/<OptionController>
    [HttpGet]
    public async Task<List<string>> GetAsync()
    {
        var optionLoader = new OptionLoader("Voiture", 10, 6000);
        var data = await optionLoader.GetOptionsAsync().ConfigureAwait(false);
        return data.ToList();
    }

    // GET api/<OptionController>/5
    [HttpGet("{id}")]
    public async Task<List<string>> GetAsync(int id)
    {
        var optionLoader = new OptionLoader("Voiture", 10, id * 1000);
        var data = await optionLoader.GetOptionsAsync().ConfigureAwait(false);
        return data.ToList();
    }
}
