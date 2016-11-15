using KoperasiProject.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoperasiProject.EntityFramework;

namespace KoperasiProject.Repository.Users
{
    public class RoleRepository : GenericRepository<Role>
    {
        public RoleRepository(KoperasiDbContext entities) : base(entities)
        {
        }
    }
}
