using empleado;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{


empleadocontext Dbcontext;


public HomeController(empleadocontext db){
Dbcontext = db;

}

[HttpGet]
[Route("ConnDB")]
public IActionResult ConnDB(){
Dbcontext.Database.EnsureCreated();
return Ok();

}
}