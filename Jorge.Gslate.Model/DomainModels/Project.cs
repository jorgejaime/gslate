using System;
using System.Collections.Generic;

namespace Jorge.Gslate.Model.DomainModels
{
    public partial class Project
    {
        public Project()
        {
   
        }

        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentTypeId { get; set; }
        public int PatientId { get; set; }



    }
}
