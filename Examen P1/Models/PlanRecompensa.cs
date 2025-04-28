using System.ComponentModel.DataAnnotations;

namespace Examen_P1.Models
{
    public class PlanRecompensa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Required]
        public int PuntosAcumulados{ get; set; }
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
