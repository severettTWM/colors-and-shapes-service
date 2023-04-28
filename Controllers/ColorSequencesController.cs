using Microsoft.AspNetCore.Mvc;
using ColorsApi.Models;

namespace ColorsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ColorSequencesController : ControllerBase
{
    private static readonly ColorSequence[] colorSequences = new[] {
        new ColorSequence { Id = 1, Sequence = new string[] {"red", "green", "purple"} },
        new ColorSequence { Id = 2, Sequence = new string[] {"blue", "black", "yellow"} },
        new ColorSequence { Id = 3, Sequence = new string[] {"silver", "brown", "orange"} },
        new ColorSequence { Id = 4, Sequence = new string[] {"pink", "gold", "teal"} },
    };

    private readonly ILogger<ColorSequencesController> _logger;

    public ColorSequencesController(ILogger<ColorSequencesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetColorSequences")]
    public IEnumerable<ColorSequence> Get()
    {
        return colorSequences;
    }
}
