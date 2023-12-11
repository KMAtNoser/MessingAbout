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
        _ = DBContext.Database.EnsureCreated();

        // Adds a publisher
        Publisher publisher = new()
        {
            Name = "Mariner Books"
        };

        _ = DBContext.Publisher.Add(publisher);

        // Adds some books
        _ = DBContext.Book.Add(new Book
        {
            ISBN = "978-0544003415",
            Title = "The Lord of the Rings",
            Author = "J.R.R. Tolkien",
            Language = "English",
            Pages = 1216,
            Publisher = publisher
        });
        _ = DBContext.Book.Add(new Book
        {
            ISBN = "978-0547247762",
            Title = "The Sealed Letter",
            Author = "Emma Donoghue",
            Language = "English",
            Pages = 416,
            Publisher = publisher
        });

        // Saves changes
        _ = DBContext.SaveChanges();
    }
}

