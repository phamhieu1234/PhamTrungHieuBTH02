using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamTrungHieuBTH02.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<PhamTrungHieuBTH02.Models.Student> Student { get; set; } = default!;

        public DbSet<PhamTrungHieuBTH02.Models.Employee>? Employee { get; set; }

        public DbSet<PhamTrungHieuBTH02.Models.Customer>? Customer { get; set; }

        public DbSet<PhamTrungHieuBTH02.Models.Person>? Person { get; set; }
    }
