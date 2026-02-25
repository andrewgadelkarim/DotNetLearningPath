namespace MyFirstEFCoreApp.Models
{
    public class Book
    {
        public int BookId { get; set; } //Using this naming convention lets EF Core know automatically that this is the primary key
        
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PublishedOn { get; set; } //TODO: Look into using DateOnly to avoid timezone issues

        public int AuthorId { get; set; } //Foreign Key to author table
        public Author Author { get; set; } = new(); //Navigation property
    }
}
