using System.ComponentModel.DataAnnotations;

namespace libreria.Models;

public class Libro
{
    [Key]
    public Guid LibroId { get; set; }

    [Required]
    [MaxLength(250)]
    public String? nombre { get; set; }

    [MaxLength(250)]
    public int? Edicion { get; set; }

    [MaxLength(250)]
    public int? Paginas { get; set; }
    
    [Required]
    public Guid AutorId { get; set; }

    public genero Genero { get; set; } 
    public enum genero{
        Masculino,
        Femenino,
        noEspecifica,
    }
    public virtual ICollection<Autor> ?Autors { get; set; }
    public virtual ICollection<Genero> ?Generos { get; set; }
}