using AutoMapper;
using Jorge.Gslate.Model.DomainModels;
using Jorge.Gslate.Services.VieModels.Appointment;

namespace Jorge.Gslate.Services
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {
           
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Project, ProjectView>();
                cfg.CreateMap<ProjectView, Project>();

            });
            
        }

    }
    }
