using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Angular2AspCoreMasterDetail.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
        : base(options) { }
        public StudentContext() { }
        public DbSet<StudentMasters> StudentMasters { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }

    }
}