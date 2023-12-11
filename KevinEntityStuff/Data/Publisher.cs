namespace KevinEntities.Data;

public class Publisher
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public virtual required ICollection<Book> Books { get; set; }
}


