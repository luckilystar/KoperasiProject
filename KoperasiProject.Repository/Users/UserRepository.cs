using KoperasiProject.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoperasiProject.EntityFramework;

namespace KoperasiProject.Repository.Users
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(KoperasiDbContext entities) : base(entities)
        {
        }

        public virtual IQueryable<User> GetAllWithRoles()
        {

            IQueryable<User> query = _entities.Users.Include("Role");
            return query;
        }
    }
}
