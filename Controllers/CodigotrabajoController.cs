using empleado.Service;
using Microsoft.AspNetCore.Mvc;
namespace empleado.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class CodigotrabajoController: ControllerBase
{

        ICodigotrabajoService CodigotrabajoService;
    public CodigotrabajoController(ICodigotrabajoService serviceCodigotrabajo) => CodigotrabajoService = serviceCodigotrabajo;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] Codigotrabajo newCodigotrabajo) {
    await CodigotrabajoService.insertar(newCodigotrabajo);
    var result = newCodigotrabajo.CodigotrabajoId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetAutores() {

return Ok(CodigotrabajoService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateAutores([FromBody] Codigotrabajo CodigotrabajoActualizar, Guid id) {
    CodigotrabajoService.Actualizar(id,CodigotrabajoActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(CodigotrabajoService.eliminar(id));



}




}