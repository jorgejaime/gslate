using System;
using System.Collections.Generic;

namespace Jorge.Gslate.Model.DomainModels
{
    public partial class Project
    {
        public Project()
        {
            UserProject = new HashSet<UserProject>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<UserProject> UserProject { get; set; }
    }
}
