using StraightOutOfTheWizard.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StraightOutOfTheWizard.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}