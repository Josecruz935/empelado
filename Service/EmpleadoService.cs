namespace empleado.Service;



public class EmpleadoService : IEmpleadoService {
//Inyeccion de dependencias.
empleadocontext context;

public EmpleadoService(empleadocontext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Empleado inputEmpleado ){
   await context.AddAsync(inputEmpleado);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Cargo> obtener() => context.Empleado;

    //UPDATE
    public async Task Actualizar(Guid id, Empleado inputEmpleado){
    var Empleado = context.Empleado.Find(id);
    if(Empleado != null){
        Empleado.nombre = inputEmpleado.nombre;
        Empleado.listar = inputEmpleado.listar;
        Empleado.fechadeingreso = inputEmpleado.fechadeingreso;
        Empleado.cargoId = inputEmpleado.cargoId;
        Empleado.disponible= inputEmpleado.disponible;
        Empleado.fechadeingreso = inputEmpleado.fechadeingreso;}
        Empleado.calculardiasDisponibles = inputEmpleado.calculardiasDisponibles;

        await context.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var Empleado = context.Empleado.Find(id);
    if(Empleado != null){
        context.Remove(Empleado);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid EmpleadoId) {
    var Empleado = await context.Empleado.FindAsync(EmpleadoId);
    return Empleado != null;
}}


public interface IEmpleadoService{
Task insertar(Empleado inputEmpleado);
IEnumerable<Empleado> obtener();
Task Actualizar(Guid id, Empleado empleado);
Task eliminar(Guid Id);

}