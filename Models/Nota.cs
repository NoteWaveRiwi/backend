using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Nota {

[Key]
    public int Id { get; set; }
    public string? Categoria { get; set;}
    public string? Titulo { get; set; }
    public DateTime? Fecha { get; set; }


}