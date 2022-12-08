using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsFromWizard.ViewModels;

namespace XamarinFormsFromWizard.Views
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