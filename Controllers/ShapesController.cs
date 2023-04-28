using Microsoft.AspNetCore.Mvc;
using ColorsApi.Models;

namespace ColorsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ShapesController : ControllerBase
{
    private static readonly Shape[] shapes = new[] {
        new Shape { Name = "square", Complexity = 1 },
        new Shape { Name = "circle", Complexity = 1 },
        new Shape { Name = "triangle", Complexity = 2 },
        new Shape { Name = "parallelogram", Complexity = 2 },
        new Shape { Name = "trapezoid", Complexity = 2 },
    };

    private readonly ILogger<ShapesController> _logger;

    public ShapesController(ILogger<ShapesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetShapes")]
    public IEnumerable<Shape> Get()
    {
        return shapes;
    }
}
