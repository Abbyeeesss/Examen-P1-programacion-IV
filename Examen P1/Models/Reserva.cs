using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen_P1.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public int ClienteId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaReserva { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
        [Required]
        public int ValorPagar { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes? Cliente { get; set; }
    }
}
