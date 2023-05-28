using System.ComponentModel.DataAnnotations;

public class Empleado {
[Key]
public Guid EmpleadoId{get; set;}= Guid.NewGuid();

[Required]
public int nombre{get; set;}
[Required]

public int fechadeingreso{get; set;}
[Required]

public int cargoId{get; set;}
[Required]

public Boolean disponible{get; set;}
[Required]

public  Empleado  listar{get; set;}
[Required]

public int calculardiasDisponibles{get;set;}
}