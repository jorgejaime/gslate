using System;
using System.Collections.Generic;

namespace Jorge.Gslate.Model.DomainModels
{
    public partial class UserProject
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public bool IsActive { get; set; }
        public DateTime AssignedDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}
