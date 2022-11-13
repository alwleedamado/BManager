namespace BManager.Utils
{
    public class QueryParams<T> where T : class
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public T EntityFilters { get; set; }
        public string SortField { get; set; }
        public string SortOrder { get; set; }
    }
}
