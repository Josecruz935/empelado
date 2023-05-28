using System.ComponentModel.DataAnnotations;

public class Cargo {
[Key]
public Guid cargoId{get; set;}= Guid.NewGuid();

[Required]
public int nombre{get; set;}
[Required]

public Cargo listar{get;set;}
}