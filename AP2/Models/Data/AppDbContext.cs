using Microsoft.EntityFrameworkCore;
namespace AP2.Models.Data
{
    public class AppDbContext : DbContext
    {
     public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
     {
         
     } 
     public DbSet<Conta> Contas { get; set; }
     
       
    }
}