using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFromWizardBlank.Services;
using XamarinFormsFromWizardBlank.Views;

namespace XamarinFormsFromWizardBlank
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
