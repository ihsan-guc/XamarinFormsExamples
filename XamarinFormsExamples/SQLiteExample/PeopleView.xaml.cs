using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsExamples.SQLiteExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : ContentPage
    {
        IPeopleRepository peopleContext;
        public PeopleView(IPeopleRepository peopleRepository)
        {
            InitializeComponent();
            peopleContext = peopleRepository;
            PeopleData();
        }

        private void AddPeople(object sender, EventArgs e)
        {
            var people = new People()
            {
                FirstName = firstNameEntry.Text,
                LastName = lastNameEntry.Text,
                Id = Guid.NewGuid(),
            };

            bool isadd = peopleContext.AddPeople(people);
            if (isadd)
            {
                DisplayAlert("Error", isadd.ToString(), "OK", "Cancel");
            }
            PeopleData();
        }
        void PeopleData()
        {
            ltsView.ItemsSource = peopleContext.GetPersonelList();
        }

        private async void PeopleDelete(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            People people = (People)menuItem.BindingContext;
            if (people != null)
            {
                bool isOk = await DisplayAlert("Are You Sure You Want To Delete?", people.FirstName + " " + people.LastName, "Ok", "Cancel");
                if (isOk)
                {
                    peopleContext.DeletePeople(people.Id);
                    PeopleData();
                }
            }
        }
    }
}