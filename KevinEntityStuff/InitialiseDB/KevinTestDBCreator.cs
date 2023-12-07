using KevinEntities.Data;

namespace KevinEntities.InitialiseDB;

public class KevinTestDBCreator
{
    public KevinTestDBContext DBContext { private get; set; }

    public KevinTestDBCreator(KevinTestDBContext dbContext)
    {
        DBContext = dbContext;
    }

    public void Create()
    {
        // Creates the database if not exists
        DBContext.Database.EnsureCreated();

        // Adds a publisher
        var publisher = new Publisher
        {
            Name = "Mariner Books"
        };

        DBContext.Publisher.Add(publisher);

        // Adds some books
        DBContext.Book.Add(new Book
        {
            ISBN = "978-0544003415",
            Title = "The Lord of the Rings",
            Author = "J.R.R. Tolkien",
            Language = "English",
            Pages = 1216,
            Publisher = publisher
        });
        DBContext.Book.Add(new Book
        {
            ISBN = "978-0547247762",
            Title = "The Sealed Letter",
            Author = "Emma Donoghue",
            Language = "English",
            Pages = 416,
            Publisher = publisher
        });

        // Saves changes
        DBContext.SaveChanges();
    }
}

