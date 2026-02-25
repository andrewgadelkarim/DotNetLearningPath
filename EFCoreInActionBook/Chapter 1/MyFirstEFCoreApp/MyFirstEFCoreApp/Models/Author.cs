namespace MyFirstEFCoreApp.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string WebUrl { get; set; } = DefaultConstants.DefaultUrlPropertyConst;
    }
}
