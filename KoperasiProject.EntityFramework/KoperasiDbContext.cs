using KoperasiProject.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiProject.EntityFramework
{
    public class KoperasiDbContext:DbContext
    {
        public KoperasiDbContext():base("DefaultConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
