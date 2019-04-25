namespace Jorge.Gslate.Web.Models.DataTable
{
    public class DataTableModelColumns
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public DataTableModelSearch search { get; set; }
        
    }
}