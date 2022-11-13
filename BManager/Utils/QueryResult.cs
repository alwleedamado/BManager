namespace BManager.Utils
{
    public class QueryResult<T> where T : class
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public string ErrorMessage { get; set; }
    }
}
