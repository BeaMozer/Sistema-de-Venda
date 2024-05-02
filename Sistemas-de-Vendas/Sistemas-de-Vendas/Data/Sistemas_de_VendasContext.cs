using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistemas_de_Vendas.Models;

namespace Sistemas_de_Vendas.Data
{
    public class Sistemas_de_VendasContext : DbContext
    {
        public Sistemas_de_VendasContext (DbContextOptions<Sistemas_de_VendasContext> options)
            : base(options)
        {
        }

        public DbSet<Sistemas_de_Vendas.Models.Product> Product { get; set; } = default!;
        public DbSet<Sistemas_de_Vendas.Models.Register> Register { get; set; } = default!;
        public DbSet<Sistemas_de_Vendas.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Sistemas_de_Vendas.Models.Client> Client { get; set; } = default!;
        public DbSet<Sistemas_de_Vendas.Models.Sale> Sale { get; set; } = default!;
        public DbSet<Sistemas_de_Vendas.Models.AccessLevel> AccessLevel { get; set; } = default!;
        public DbSet<Sistemas_de_Vendas.Models.Category> Category { get; set; } = default!;
    }
}
