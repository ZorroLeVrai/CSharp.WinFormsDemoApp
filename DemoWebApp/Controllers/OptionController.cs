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
    public async Task<ActionResult<List<string>>> GetAsync(CancellationToken cancellationToken)
    {
        var optionLoader = new OptionLoader("Voiture", 10, 6000);

        try
        {
            // Use the cancellation token to allow the operation to be cancelled
            var data = await optionLoader.GetOptionsAsync(cancellationToken).ConfigureAwait(false);
            return data.ToList();
        }
        catch (OperationCanceledException)
        {
            return StatusCode(499); // Client Closed Request (non-standard)
        }
    }

    // GET api/<OptionController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<List<string>>> GetAsync(int id, CancellationToken cancellationToken)
    {
        var optionLoader = new OptionLoader("Voiture", 10, id * 1000);

        try
        {
            // Use the cancellation token to allow the operation to be cancelled
            var data = await optionLoader.GetOptionsAsync(cancellationToken).ConfigureAwait(false);
            return data.ToList();
        }
        catch (OperationCanceledException)
        {
            return StatusCode(499); // Client Closed Request (non-standard)
        }
    }
}
