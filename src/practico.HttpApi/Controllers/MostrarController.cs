using Microsoft.AspNetCore.Mvc;
using practico.Application;
namespace practico.HttpApi.Controllers;
[ApiController]
[Route("[controller]")]
public class MostrarController : ControllerBase
{
    private readonly MostrarAppServiceController mostrarAppServiceController;

    public MostrarController(MostrarppServiceController mostrarAppServiceController )
    {
        this.mostrarAppServiceController = mostrarAppServiceController;
    }

    [HttpGet("cgarcia_api_net")]
    public ICollection<Character> GetAll()
    {
        return mostrarAppServiceController.MetodoGet();
    }
}
