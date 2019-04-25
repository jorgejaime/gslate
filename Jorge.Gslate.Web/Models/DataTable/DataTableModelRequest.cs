using System.Collections.Generic;

namespace Jorge.Gslate.Web.Models.DataTable
{
    public class DataTableModelRequest<T> where T : class
    { 
        
        public int draw { get; set; }

        public IList<DataTableModelColumns> columns { get; set; }

        public int start { get; set; }

        public int length { get; set; }

        public DataTableModelSearch search { get; set; }

        public IList<DataTableModelOrder> order { get; set; }
       
        public DataTableModelRequest()
        {
            columns = new List<DataTableModelColumns>();
            order = new List<DataTableModelOrder>();
            
        }

        public T Filter {get; set;}
    }
}