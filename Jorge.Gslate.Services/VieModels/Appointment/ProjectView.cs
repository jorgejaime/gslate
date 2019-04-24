using System;

namespace Jorge.Gslate.Services.VieModels.Appointment
{
    public class ProjectView
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientId { get; set; }
        public int AppointmentTypeId { get; set; }
    }
}