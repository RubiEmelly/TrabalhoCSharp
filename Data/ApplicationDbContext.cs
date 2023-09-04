using Microsoft.EntityFrameworkCore;
using Salao_De_Cabeleireiro.Models;

namespace Salao_De_Cabeleireiro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<SalaoModel> Salao { get; set; }
    }
}

