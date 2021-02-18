using Microsoft.EntityFrameworkCore;
using MyPortfolio.API.Models;

namespace MyPortfolio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<About> Abouts {get; set;}
        
        
    }
}