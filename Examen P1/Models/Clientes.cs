namespace Examen_P1.Models;
using System.ComponentModel.DataAnnotations;

public class Clientes
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string NombreCliente { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    [MaxLength(100)]
    public string Contraseña { get; set; }

    [Required]
    [Phone]
    public string Telefono { get; set; }

    [Required]
    [DataType(DataType.Date)]                                                                                                                                                                                                                                                                                                                                       
    public DateTime FechaNacimiento { get; set; }
    public bool Disponibilidad { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
    public List<Reserva>? Reservas
    {
        get; set;
    }
}

