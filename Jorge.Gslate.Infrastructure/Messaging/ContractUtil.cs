using System;
using System.Collections.Generic;
using System.Linq;
using Jorge.Gslate.Infrastructure.Domain;

namespace Jorge.Gslate.Infrastructure.Messaging
{
    public class ContractUtil
    {


        #region Request 

        public static ContractRequest<TRequest> CreateRequest<TRequest>(TRequest dtoData )       
            where TRequest : class 
        {
            var toReturn = new ContractRequest<TRequest>
            {                               
                Data = dtoData,
            };

            return toReturn;
        }


        public static ContractRequest<BaseRequest> CreateBaseRequest()
        {
            var toReturn = new ContractRequest<BaseRequest>()
            {
                Data = new BaseRequest(),
            };

            return toReturn;
        }

        #endregion

        #region Response

       
        public static ContractResponse<TResponse> CreateResponse<TResponse, TRequest>(ContractRequest<TRequest> request, TResponse data)
            where TRequest : class
            where TResponse : class
        {

            return new ContractResponse<TResponse>
            {
                Data = data,                
                ErrorMessages = new string[] { } ,
                IsValid = true,
            };
        }

        #endregion

        #region InvalidReponse

               

        public static ContractResponse<TResponse> CreateInvalidResponse<TResponse>(TResponse data, string errorMessage)
            where TResponse : class
        {

            return new ContractResponse<TResponse>
            {
                Data = data,                
                ErrorMessages = new[] { errorMessage } ,
                IsValid = false,
            };
        }

       

        public static ContractResponse<TResponse> CreateInvalidResponse<TResponse>(Exception ex, TResponse data)
            where TResponse : class
        {

            return new ContractResponse<TResponse>
            {
                Data = data,                             
                ErrorMessages =  new[] { ex.Message },
                IsValid = false,
            };
        }

        


        public static ContractResponse<TResponse> CreateInvalidResponse<TResponse>(Exception ex)
            where TResponse : class 
        {

            return new ContractResponse<TResponse>
            {
                Data =  null,                
                ErrorMessages = new[] { ex.Message },
                IsValid = false,
            };
        }

        public static ContractResponse<TResponse> CreateInvalidResponse<TResponse>(IEnumerable<BusinessRule> brokenRules)
            where TResponse : class
        {

            return new ContractResponse<TResponse>
            {
                Data = null,              
                ErrorMessages = brokenRules.Select(b=> b.Rule).ToArray(),
                IsValid = false,
            };
        }

        #endregion
    }
}
