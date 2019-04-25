using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jorge.Gslate.Web.Models
{
    public class ProjectUserViewModel
    {
        public List<SelectListItem> Users { get; set; }
        public int Id { get; set; }
    }
}
