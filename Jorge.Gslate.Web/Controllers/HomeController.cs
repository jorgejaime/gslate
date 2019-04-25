using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jorge.Gslate.Web.Models;
using Jorge.Gslate.Web.Models.DataTable;
using Jorge.Gslate.Services.VieModels.User;
using Jorge.Gslate.Services.Interfaces;
using Jorge.Gslate.Infrastructure.Messaging;
using Jorge.Gslate.Services.VieModels.Project;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jorge.Gslate.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IUserService userService;

        public HomeController(IProjectService  projectService, IUserService userService)
        {
            this.projectService = projectService;
            this.userService = userService;
        }

        public IActionResult Index()
        {

            var users = userService.GetAll(new ContractRequest<BaseRequest> { });
            var usersItems = DropDownUtil.GetDropDownPappingGeneric(
                   users.Data,
                   nameof(UserView.Id),
                   nameof(UserView.FullName),
                    -1
            );

            usersItems.Insert(0, new SelectListItem { Text = "---", Value = "-1" });

            var model = new ProjectUserViewModel
            {
                Users = usersItems,
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult List([FromBody] DataTableModelRequest<UserView> tr)
        {
            try
            {
                var filter = tr.Filter;
        
                var responseVouchers = projectService.GetByUser(new ContractRequest<UserView>
                {
                    Data = tr.Filter,
                    Page = tr.start,
                    PageSize = tr.length

                });
                var modelList = responseVouchers.Data;
                var response = new DataTableResponseViewModel<ProjectView>
                {
                    Data = modelList,
                    RecordsFiltered = responseVouchers.CountFilter,
                    RecordsTotal = responseVouchers.Count
                };
                return Json(response);

            }
            catch (Exception ex)
            {
     
                var response = new DataTableResponseViewModel<ProjectView>
                {
                    Data = new List<ProjectView>(),
                    RecordsFiltered = 0,
                    RecordsTotal = 0,
                    Error = "Error al obtener los datos"
                };
                return Json(response);
            }
        }

    }
}
