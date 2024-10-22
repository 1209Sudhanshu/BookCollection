namespace BookCollection.Model
{
    public class Add_Book_Dto
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required DateTime PublishedDate { get; set; }
        public required string Genre { get; set; }
    }
}
