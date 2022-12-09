using System.Collections.ObjectModel;
using XamarinFormsFromWizard.Models;

namespace XamarinFormsFromWizard.ViewModels
{
    internal class PeopleViewModel : 
        BaseViewModel
    {
        public ObservableCollection<Person> People { get; }

        public PeopleViewModel()
        {
            People = new ObservableCollection<Person>{
                new Person
                {
                    FirstName = "Kevin",
                    Surname = "Melvin",
                    Age = 59
                },
                new Person
                {
                    FirstName = "Carole",
                    Surname = "Negus",
                    Age = 57
                },
                new Person
                {
                    FirstName = "Christopher",
                    Surname = "Melvin",
                    Age = 64
                }
            };
        }
    }
}
