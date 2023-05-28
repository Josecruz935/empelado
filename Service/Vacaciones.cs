namespace empleado.Service;



public class VacacionesService : IVacacionesService {
//Inyeccion de dependencias.
empleadocontext context;

public VacacionesService(empleadocontext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Vacaciones inputVacaciones ){
   await context.AddAsync(inputVacaciones);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Vacaciones> obtener() => context.Vacaciones;

    //UPDATE
    public async Task Actualizar(Guid id, Vacaciones inputVacaciones){
    var Vacaciones = context.Vacaciones.Find(id);
    if(Vacaciones != null){
        Vacaciones.fecha = inputVacaciones.fecha;
        Vacaciones.empleadoid = inputVacaciones.empleadoid;
        await context.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var Vacaciones = context.Vacaciones.Find(id);
    if(Vacaciones != null){
        context.Remove(Vacaciones);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid VacacionesId) {
    var Vacaciones = await context.Vacaciones.FindAsync(VacacionesId);
    return Vacaciones != null;
}}


public interface IVacacionesService{
Task insertar(Vacaciones inputVacaciones);
IEnumerable<Vacaciones> obtener();
Task Actualizar(Guid id, Vacaciones  vacaciones);
Task eliminar(Guid Id);

}