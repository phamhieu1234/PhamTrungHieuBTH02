using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamTrungHieuExcel.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhamTrungHieuExcel.Models.Student> Student { get; set; } = default!;

        public DbSet<PhamTrungHieuExcel.Models.Person>? Person { get; set; }

        public DbSet<PhamTrungHieuExcel.Models.Customer>? Customer { get; set; }

        public DbSet<PhamTrungHieuExcel.Models.Employee>? Employee { get; set; }
    }
