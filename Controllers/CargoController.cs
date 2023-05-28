using empleado.Service;
using Microsoft.AspNetCore.Mvc;
namespace empleado.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class CargoController: ControllerBase
{

        ICargoService CargoService;
    public CargoController(ICargoService serviceCargo) => CargoService = serviceCargo;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] Cargo newCargo) {
    await CargoService.insertar(newCargo);
    var result = newCargo.cargoId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetAutores() {

return Ok(CargoService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateAutores([FromBody] Cargo CargoActualizar, Guid id) {
    CargoService.Actualizar(id,CargoActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(CargoService.eliminar(id));



}




}