using System;
using Jorge.Gslate.Infrastructure.Messaging;
using Jorge.Gslate.Repository.UnitOfWork;
using Jorge.Gslate.Model.Repositories;
using Jorge.Gslate.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Jorge.Gslate.Services.Mapping;
using Jorge.Gslate.Model.DomainModels;
using AutoMapper;
using System.Linq;
using Jorge.Gslate.Infrastructure.Domain;
using System.Collections.Generic;
using Jorge.Gslate.Services.VieModels.Project;
using Jorge.Gslate.Services.VieModels.User;

namespace Jorge.Gslate.Services.Implementatios
{
    public class ProjectService : IProjectService
    {
        private readonly ILogger<ProjectService> _logger;
        private readonly IUnitOfWork _uow;

        public ProjectService( IUnitOfWork uow, ILogger<ProjectService> logger)
        {
            _uow = uow;
            _logger = logger;
        }


        public ContractResponse<List<ProjectView>> GetByUser(ContractRequest<UserView> request)
        {
            ContractResponse<List<ProjectView>> response;
            try
            {

                var projects = _uow.ProjectRepository.Get(p=> p.UserProject.Any(u=> u.UserId == request.Data.Id), page: request.Page, pageSize: request.PageSize, includeProperties: new string[] { nameof(UserProject) });

                var proje = projects.ToList();
                var projectsResponse = projects.SelectMany(s => s.UserProject, (Project, User) => new { Project, User }).Select(s=>  new ProjectView
                {
                    Id = s.Project.Id,
                    StartDate = s.Project.StartDate,
                    EndDate = s.Project.StartDate,
                    Credits = s.Project.Credits,
                    IsActive = s.User.IsActive,
                    AssignedDate = s.User.AssignedDate
                }
                ).ToList();

                response = ContractUtil.CreateResponse(request, projectsResponse);
                response.Count = _uow.ProjectRepository.Count();
                response.CountFilter = _uow.ProjectRepository.Count(p => p.UserProject.Any(u => u.UserId == request.Data.Id));
            }
            catch (Exception ex)
            {
                _logger.LogError(20, ex, ex.Message);
                response = ContractUtil.CreateInvalidResponse<List<ProjectView>>(ex);
            }

            return response;
        }



    }
}
