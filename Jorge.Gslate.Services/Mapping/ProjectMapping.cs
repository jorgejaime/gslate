using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Jorge.Gslate.Model.DomainModels;
using Jorge.Gslate.Services.VieModels.Appointment;


namespace Jorge.Gslate.Services.Mapping
{
    public static class ProjectMapping
    {
        public static IEnumerable<ProjectView> ToAppointmentViewList(this IEnumerable<Project> list)
        {
            return Mapper.Map<List<ProjectView>>(list);
        }

        public static ProjectView ToProjectView(this Project model)
        {
            return Mapper.Map<ProjectView>(model);
        }


        public static IEnumerable<Project> ToProjectList(this IEnumerable<ProjectView> list)
        {
            return Mapper.Map<List<Project>>(list);
        }

        public static Project ToProject(this ProjectView model)
        {
            return Mapper.Map<Project>(model);
        }
    }
}
