using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Examen_P1.Models;

namespace Examen_P1.Data
{
    public class Examen_P1Context : DbContext
    {
        public Examen_P1Context (DbContextOptions<Examen_P1Context> options)
            : base(options)
        {
        }

        public DbSet<Examen_P1.Models.Clientes> Clientes { get; set; } = default!;
        public DbSet<Examen_P1.Models.Reserva> Reserva { get; set; } = default!;
        public DbSet<Examen_P1.Models.PlanRecompensa> PlanRecompensa { get; set; } = default!;
    }
}
