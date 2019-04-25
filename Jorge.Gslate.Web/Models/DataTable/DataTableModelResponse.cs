using System.Collections;
using System.Collections.Generic;

namespace Jorge.Gslate.Web.Models.DataTable
{
    public class DataTableResponse<T>
    {
        public int draw { get; set; }

        public long recordsTotal { get; set; }

        public long recordsFiltered { get; set; }

        public IEnumerable data { get; set; }

        public string error { get; set; }

        public DataTableResponse()
        {
            data = new List<T>();
        }
    }
}