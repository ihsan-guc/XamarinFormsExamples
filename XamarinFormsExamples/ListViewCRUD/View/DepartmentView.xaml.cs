
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsExamples.ListViewCRUD.ViewModel;

namespace XamarinFormsExamples.ListViewCRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DepartmentView : ContentPage
    {
        public DepartmentView()
        {
            InitializeComponent();
            BindingContext = new DepartmentViewModels();
        }
    }
}