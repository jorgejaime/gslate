﻿using System;
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

        //public ContractResponse<AppointmentListGetResponse> GetAll(ContractRequest<BaseRequest> request)
        //{
        //    ContractResponse<AppointmentListGetResponse> response;
        //    try
        //    {
        //        var modelList = _appointmentRepository.GetAll();
        //        var modelListResponse = modelList.ToAppointmentViewList();

        //        response = ContractUtil.CreateResponse(request, new AppointmentListGetResponse { Appointments = modelListResponse.ToList() });
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(20, ex, ex.Message);

        //        response = ContractUtil.CreateInvalidResponse<AppointmentListGetResponse>(ex);
        //    }

        //    return response;
        //}

        //public ContractResponse<AppointmentListGetResponse> Get(ContractRequest<AppointmentGetRequest> request)
        //{
        //    ContractResponse<AppointmentListGetResponse> response;
        //    try
        //    {
        //        var model = _appointmentRepository.FindBy(e => e.Id == request.Data.Id);
        //        var modelListResponse = model.ToAppointmentViewList();

        //        response = ContractUtil.CreateResponse(request, new AppointmentListGetResponse { Appointments = modelListResponse.ToList() });
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(20, ex, ex.Message);
        //        response = ContractUtil.CreateInvalidResponse<AppointmentListGetResponse>(ex);
        //    }

        //    return response;
        //}

       

        //public ContractResponse<AppointmentGetResponse> Add(ContractRequest<AddUpdateAppointmentRequest> request)
        //{
        //    try
        //    {

        //        var model = request.Data.Appointment.ToAppointment();
        //        model.AppointmentInSameDate(_appointmentRepository.IsAppointmentInSameDay(model));

        //        var brokenRules = model.GetBrokenRules().ToList();
        //        if (!brokenRules.Any())
        //        {
                    

        //            _appointmentRepository.Add(model);
        //            _uow.Commit();


        //            var responseModel = new AppointmentGetResponse { Id = model.Id };
        //            return ContractUtil.CreateResponse(request, responseModel);
        //        }

        //        return ContractUtil.CreateInvalidResponse<AppointmentGetResponse>(brokenRules);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(20, ex, ex.Message);
        //        return ContractUtil.CreateInvalidResponse<AppointmentGetResponse>(ex);
        //    }
        //}

        //public ContractResponse<AppointmentGetResponse> Update(ContractRequest<AddUpdateAppointmentRequest> request)
        //    {
        //    try
        //    {
        //        var model = request.Data.Appointment.ToAppointment();
        //        model.AppointmentInSameDate(_appointmentRepository.IsAppointmentInSameDay(model));

        //        var brokenRules = model.GetBrokenRules().ToList();
        //        if (!brokenRules.Any())
        //        {
        //            _appointmentRepository.Edit(model);
        //            _uow.Commit();

        //            var responseModel = new AppointmentGetResponse { Id = model.Id };
        //            return ContractUtil.CreateResponse(request, responseModel);
        //        }


        //        return ContractUtil.CreateInvalidResponse<AppointmentGetResponse>(brokenRules);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(20, ex, ex.Message);
        //        return ContractUtil.CreateInvalidResponse<AppointmentGetResponse>(ex);
        //    }
        //}


       
       

    }
}
