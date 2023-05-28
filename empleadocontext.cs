using Microsoft.EntityFrameworkCore;


namespace empleado{
public class empleadocontext: DbContext {

public DbSet<Cargo> Cargo  {get;set;}
public DbSet<Codigotrabajo>  Codigotrabajo {get; set;}
public DbSet<Empleado> Empleado {get; set;}

public DbSet<Vacaciones> Vacaciones {get; set;}
public empleadocontext(DbContextOptions<empleadocontext> options) : base(options){}
}}