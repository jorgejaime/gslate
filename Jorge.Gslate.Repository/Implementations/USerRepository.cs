using System;
using System.Linq;
using Jorge.Gslate.Model.DomainModels;
using Jorge.Gslate.Model.Repositories;

namespace Jorge.Gslate.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ProjectContext context) : base(context)
        {

        }

       

    }
}
