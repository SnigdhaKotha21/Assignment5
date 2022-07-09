using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment5.Models;

namespace Assignment13.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext (DbContextOptions<EmployeesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment5.Models.Employee> Employee { get; set; }
    }
}
