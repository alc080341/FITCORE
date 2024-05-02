using Microsoft.AspNetCore.Mvc;
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
    public FitCoreDOMAIN.IFitnessProgram Get()
    {
        FitCoreDOMAIN.IFitnessProgram program = new FitCoreDOMAIN.FitnessProgram(1, 1, "Today's fitness program");
        program.GetProgramWorksouts();
        return program;    
    }
}
