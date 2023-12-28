using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data;

public class DBaseContext : DbContext
{
    public DBaseContext(DbContextOptions<DBaseContext> options) : base(options)
    {
        
    }

    public DbSet<ContactModel> Contacts { get; set; }
}