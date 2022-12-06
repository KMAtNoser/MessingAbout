namespace introLibrary
{

    public class Person :
        IPerson
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(
            string firstName,
            string surname,
            DateTime birthDate)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.BirthDate = birthDate;
        }
    }
}