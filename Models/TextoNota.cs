using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class TextoNota {

[Key]
    public int Id { get; set; }
    public string? TextNote { get; set;}


}