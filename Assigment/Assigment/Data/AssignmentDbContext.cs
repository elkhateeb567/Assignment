using Assigment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assigment.Data
{
    public class AssignmentDbContext:DbContext
    {
        public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options) : base(options)
        {

        }
        public DbSet<AdminAssignment> AdminAssignment { get; set; }

    }
}
