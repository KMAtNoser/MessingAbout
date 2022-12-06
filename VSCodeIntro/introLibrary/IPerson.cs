namespace introLibrary
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string Surname { get; set; }

        DateTime BirthDate { get; set; }
    }
}