using Jauto.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jauto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Representar as Tabelas da BD
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Oficinas> Oficinas { get; set; }
        public DbSet<Marcacoes> Marcacoes { get; set; }
        public DbSet<MetodoPagamento> MetodoPagamento { get; set; }
        public DbSet<Servicos> Servicos { get; set; }

    }


}
