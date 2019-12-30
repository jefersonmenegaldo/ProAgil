using Microsoft.EntityFrameworkCore;
using Sistema.WebApi.Model;

namespace Sistema.WebApi.Data
{
    public class DataContext : DbContext    
    {
        public DataContext (DbContextOptions<DataContext>options ) : base (options){}
        
        public DbSet<Evento> Eventos { get; set; }
        
    }
}