using System.ComponentModel.DataAnnotations;

namespace SpeacialAPI.Models;

public class MandrilInsert
{
    [Required]
    [MaxLength(50)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Apellido { get; set; } = string.Empty;

}
