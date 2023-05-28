using empleado.Service;
using Microsoft.AspNetCore.Mvc;
namespace empleado.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class VacacionesController: ControllerBase
{

        IVacacionesService VacacionesService;
    public VacacionesController(IVacacionesService serviceVacaciones) => VacacionesService = serviceVacaciones;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] Vacaciones newVacaciones) {
    await VacacionesService.insertar(newVacaciones);
    var result = newVacaciones.vacacionesid;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetAutores() {

return Ok(VacacionesService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateAutores([FromBody] Vacaciones VacacionesActualizar, Guid id) {
    VacacionesService.Actualizar(id,VacacionesActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(VacacionesService.eliminar(id));

}

}
