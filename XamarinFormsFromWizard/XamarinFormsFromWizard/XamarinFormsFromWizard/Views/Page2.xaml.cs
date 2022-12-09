using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFromWizard.Models;
using XamarinFormsFromWizard.ViewModels;

namespace XamarinFormsFromWizard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {

        // public static ObservableCollection<Person> People { get; set; }

        public Page2()
        {
            //People = new ObservableCollection<Person>{
            //    new Person
            //    {
            //        FirstName = "Kevin",
            //        Surname = "Melvin",
            //        Age = 59
            //    },
            //    new Person
            //    {
            //        FirstName = "Carole",
            //        Surname = "Negus",
            //        Age = 57
            //    },
            //    new Person
            //    {
            //        FirstName = "Christopher",
            //        Surname = "Melvin",
            //        Age = 64
            //    }
            //};

            InitializeComponent();
            BindingContext = new PeopleViewModel();
            //         < !--
            //BindingContext = "{vm:PeopleViewModel}"
            //-- >
        }
    }
}