using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void AddPeople(object sender, EventArgs e)
        {
            var people = new People()
            {
                FirstName = firstNameEntry.Text,
                LastName = lastNameEntry.Text,
                Id = peopleContext.GetPersonelList().Count,
            };

            var isadd = peopleContext.AddPeople(people);
            if (isadd == null)
            {
                DisplayAlert("Error", isadd.ToString(), "OK", "Cancel");
            }
        }
    }
}