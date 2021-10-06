using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenPhuongThuyLinh128.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenPhuongThuyLinh128.Models.PersonNPTL128> PersonNPTL128 { get; set; }
    }
