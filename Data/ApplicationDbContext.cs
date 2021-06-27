using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFarma_TemplateN.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CFarma_TemplateN.Models.Cliente> Clientes { get; set; }
        public DbSet<CFarma_TemplateN.Models.Producto> Productos { get; set; }
    }
}
