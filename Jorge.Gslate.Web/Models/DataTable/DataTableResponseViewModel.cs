
using System.Collections.Generic;

namespace Jorge.Gslate.Web.Models.DataTable
{
    public class DataTableResponseViewModel<T> where T : class 
    {
        public int Draw { get; set; }

        public long RecordsTotal { get; set; }

        public long RecordsFiltered { get; set; }

        public IEnumerable<T> Data { get; set; }

        public string Error { get; set; }

        public DataTableResponseViewModel()
        {
            // data = new List<>();
        }
    }
}
