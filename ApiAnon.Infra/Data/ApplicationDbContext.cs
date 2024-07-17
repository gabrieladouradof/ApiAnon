
// Este arquivo contém a configuração do contexto de banco de dados AppDbContext.

using ApiAnon.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiAnon.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Define o DbSet para as entidades
        public DbSet<User> Users { get; set; }
        public DbSet<UserAnonymized> UsersAnonymized { get; set; }
    }
}
