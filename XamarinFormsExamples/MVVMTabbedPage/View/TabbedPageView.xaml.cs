
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsExamples.MVVMTabbedPage.ViewModel;

namespace XamarinFormsExamples.MVVMTabbedPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageView : TabbedPage
    {
        public TabbedPageView()
        {
            InitializeComponent();
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            Children.Add(new PeopleView() { BindingContext = peopleViewModel, Title = "People" });
            Children.Add(new BankView() { BindingContext = peopleViewModel, Title = "Bank" });
            Children.Add(new PeopleBankList() { BindingContext = peopleViewModel, Title = "Liste" });
        }
    }
}