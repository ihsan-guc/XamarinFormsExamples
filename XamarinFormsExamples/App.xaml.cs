using Xamarin.Forms;
using XamarinFormsExamples.ListView.View;
using XamarinFormsExamples.ListView.ViewModel;

namespace XamarinFormsExamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new UserView() { BindingContext = new UserViewModel()};
            //MainPage = new ListViewTextCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewImageCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewEntryCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewSwitchCell() { BindingContext = new DepartmentViewModel() };
            MainPage = new ListViewViewCell() { BindingContext = new DepartmentViewModel() };
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
