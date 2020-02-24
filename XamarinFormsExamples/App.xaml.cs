using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsExamples.MVVM.View;
using XamarinFormsExamples.MVVM.ViewModel;

namespace XamarinFormsExamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UserView() {BindingContext = new UserViewModel()};
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
