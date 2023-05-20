using System.ComponentModel.DataAnnotations;

namespace libreria.Models;

public class Genero
{
    [Key]
    public Guid GeneroId { get; set; }

    [Required]
    [MaxLength(250)]
    public String? nombre { get; set; }

    public virtual ICollection<Libro> ?Libros { get; set; }
}