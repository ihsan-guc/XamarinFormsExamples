
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsExamples.MVVMMasterDetailPage.Model;
using XamarinFormsExamples.MVVMMasterDetailPage.ViewModel;

namespace XamarinFormsExamples.MVVMMasterDetailPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : MasterDetailPage
    {
        public MenuView()
        {
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));
            this.BindingContext = new MenuViewModel();
        }
        private void OnMenuItemselected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuModel)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}