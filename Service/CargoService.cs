namespace empleado.Service;



public class CargoService : ICargoService {
//Inyeccion de dependencias.
empleadocontext context;

public CargoService(empleadocontext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Cargo inputCargo ){
   await context.AddAsync(inputCargo);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Cargo> obtener() => context.Cargo;

    //UPDATE
    public async Task Actualizar(Guid id, Cargo inputCargo){
    var Cargo = context.Cargo.Find(id);
    if(Cargo != null){
        Cargo.nombre = inputCargo.nombre;
        Cargo.listar = inputCargo.listar;
        await context.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var Cargo = context.Cargo.Find(id);
    if(Cargo != null){
        context.Remove(Cargo);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid CargoId) {
    var Cargo = await context.Cargo.FindAsync(CargoId);
    return Cargo != null;
}}


public interface ICargoService{
Task insertar(Cargo inputCargo);
IEnumerable<Cargo> obtener();
Task Actualizar(Guid id, Cargo Cargo);
Task eliminar(Guid Id);

}