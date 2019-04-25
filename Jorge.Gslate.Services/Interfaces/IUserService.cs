using System;
using System.Collections.Generic;
using System.Text;
using Jorge.Gslate.Infrastructure.Messaging;
using Jorge.Gslate.Services.VieModels.Project;
using Jorge.Gslate.Services.VieModels.User;

namespace Jorge.Gslate.Services.Interfaces
{
    public interface IUserService
    {

        ContractResponse<List<UserView>> GetAll(ContractRequest<BaseRequest> request);

    }
}
