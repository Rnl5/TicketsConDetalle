using Microsoft.EntityFrameworkCore;
using TicketsConDetalle.Shared;

namespace TicketsConDetalle.Server.DAL;

public class Context : DbContext
{
    public DbSet<Tickets> Tickets {get; set;}

    public Context(DbContextOptions<Context> options) : base(options){ }
}