namespace KevinEntities.Data;

public class Book
{
    public required string ISBN { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string Language { get; set; }
    public int Pages { get; set; }
    public virtual required Publisher Publisher { get; set; }
}
