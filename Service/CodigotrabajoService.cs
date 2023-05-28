namespace empleado.Service;



public class CodigotrabajoService : ICodigotrabajoService {
//Inyeccion de dependencias.
empleadocontext context;

public CodigotrabajoService(empleadocontext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Codigotrabajo inputCodigotrabajo ){
   await context.AddAsync(inputCodigotrabajo);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Codigotrabajo> obtener() => context.Codigotrabajo;

    //UPDATE
    public async Task Actualizar(Guid id, Codigotrabajo inputCodigotrabajo){
    var Codigotrabajo = context.Codigotrabajo.Find(id);
    if(Codigotrabajo != null){
        Codigotrabajo.antiguedad = inputCodigotrabajo.antiguedad;
        Codigotrabajo.vigente = inputCodigotrabajo.vigente;
        Codigotrabajo.diasotorgados= inputCodigotrabajo.diasotorgados;
        Codigotrabajo.listar = inputCodigotrabajo.listar;
        await context.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var Codigotrabajo = context.Codigotrabajo.Find(id);
    if(Codigotrabajo != null){
        context.Remove(Codigotrabajo);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid CodigotrabajoId) {
    var Codigotrabajo= await context.Codigotrabajo.FindAsync(CodigotrabajoId);
    return Codigotrabajo != null;
}}


public interface ICodigotrabajoService{
Task insertar(Codigotrabajo inputCodigotrabajo);
IEnumerable<Codigotrabajo> obtener();
Task Actualizar(Guid id, Codigotrabajo Codigotrabajo);
Task eliminar(Guid Id);

}








