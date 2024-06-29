using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Animal
{
    public int? IdAnimal { get; set; }
    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    [Required]
    [MaxLength(200)]
    public required string Category { get; set; }
    [MaxLength(200)]
    public required string Area { get; set; }
}
