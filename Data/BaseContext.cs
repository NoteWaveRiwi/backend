using Microsoft.EntityFrameworkCore;
using Backend.Models;
namespace Backend.Data;

public class BaseContext : DbContext{
    public BaseContext(DbContextOptions<BaseContext> options) : base(options) { 
        
    }
    public DbSet<Nota> Notas { get; set; }
    public DbSet<TextoNota> TextoNotas { get; set; }
}