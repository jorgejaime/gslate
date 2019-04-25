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
    public class UserService : IUserService
    {
        private readonly ILogger<ProjectService> _logger;
        private readonly IUnitOfWork _uow;

        public UserService( IUnitOfWork uow, ILogger<ProjectService> logger)
        {
            _uow = uow;
            _logger = logger;
        }


        public ContractResponse<List<UserView>> GetAll(ContractRequest<BaseRequest> request)
        {
            ContractResponse<List<UserView>> response;
            try
            {

                var users = _uow.UserRepository.GetAll();
                response = ContractUtil.CreateResponse(request, users.ToUserViewList().ToList());
            }
            catch (Exception ex)
            {
                _logger.LogError(20, ex, ex.Message);
                response = ContractUtil.CreateInvalidResponse<List<UserView>>(ex);
            }

            return response;
        }



    }
}
