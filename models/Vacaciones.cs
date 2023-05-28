using System.ComponentModel.DataAnnotations;

public class Vacaciones {
[Key]
public Guid vacacionesid{get; set;}= Guid.NewGuid();

[Required]
public int fecha{get; set;}
[Required]

public int empleadoid{get;set;}
}