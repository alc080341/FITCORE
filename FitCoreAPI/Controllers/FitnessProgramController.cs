using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
namespace FitCoreAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FitnessProgramController : ControllerBase
{
    private readonly ILogger<FitnessProgramController> _logger;

    public FitnessProgramController(ILogger<FitnessProgramController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProgram")]
    public FitCoreDOMAIN.Program Get()
    {
        FitCoreDOMAIN.Program program = new FitCoreDOMAIN.Program(1, 1);
        program.GetProgramWorksouts();
        return program;    
    }
}
