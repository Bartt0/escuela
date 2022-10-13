using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escuela.Models;
using Microsoft.EntityFrameworkCore;

namespace escuela
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}