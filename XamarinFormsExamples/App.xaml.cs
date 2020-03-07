using Xamarin.Forms;
using XamarinFormsExamples.EmailValid;
using XamarinFormsExamples.ListViewCRUD.View;
using XamarinFormsExamples.MVVMMasterDetailPage.View;
using XamarinFormsExamples.MVVMTabbedPage.View;
using XamarinFormsExamples.SQLiteExample;

namespace XamarinFormsExamples
{
    public partial class App : Application
    {
        public App(IPeopleRepository peopleRepository)
        {
            InitializeComponent();

            //MainPage = new UserView() { BindingContext = new UserViewModel()};
            //MainPage = new ListViewTextCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewImageCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewEntryCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewSwitchCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new ListViewViewCell() { BindingContext = new DepartmentViewModel() };
            //MainPage = new DepartmentView();
            //MainPage = new EmailValidView();
            //MainPage = new TabbedPageView();
            MainPage = new SQLiteExample.PeopleView(peopleRepository);
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
