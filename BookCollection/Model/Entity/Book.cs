//This will signifies the column that we will have in the table, that we are going to create a SQL server.

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookCollection.Model.Entity
{
    public class Book
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required DateTime PublishedDate { get; set; }
        public required string Genre { get; set; }
    }
}
