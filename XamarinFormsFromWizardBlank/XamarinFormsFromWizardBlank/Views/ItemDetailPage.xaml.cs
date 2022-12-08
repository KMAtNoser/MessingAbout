using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsFromWizardBlank.ViewModels;

namespace XamarinFormsFromWizardBlank.Views
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