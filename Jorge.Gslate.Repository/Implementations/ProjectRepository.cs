using System;
using System.Linq;
using Jorge.Gslate.Model.DomainModels;
using Jorge.Gslate.Model.Repositories;

namespace Jorge.Gslate.Repository.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(ProjectContext context) : base(context)
        {

        }

       

    }
}
