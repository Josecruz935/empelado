using empleado.Service;
using Microsoft.AspNetCore.Mvc;
namespace empleado.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class EmpleadoController: ControllerBase
{

        IEmpleadoService EmpleadoService;
    public EmpleadoController(IEmpleadoService serviceEmpleado) => EmpleadoService = serviceEmpleado;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] Empleado newEmpleado) {
    await EmpleadoService.insertar(newEmpleado);
    var result = newEmpleado.EmpleadoId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetAutores() {

return Ok(EmpleadoService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateAutores([FromBody] Empleado EmpleadoActualizar, Guid id) {
    EmpleadoService.Actualizar(id,EmpleadoActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(EmpleadoService.eliminar(id));



}




}