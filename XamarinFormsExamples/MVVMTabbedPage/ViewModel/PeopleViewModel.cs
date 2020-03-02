using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinFormsExamples.MVVMTabbedPage.Model;

namespace XamarinFormsExamples.MVVMTabbedPage.ViewModel
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; OnPropertyChanged(); }
        }
        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; OnPropertyChanged(); }
        }
        private string fathername;
        public string FatherName
        {
            get { return fathername; }
            set { fathername = value; OnPropertyChanged(); }
        }
        private string mothername;

        public string MotherName
        {
            get { return mothername; }
            set { mothername = value; OnPropertyChanged(); }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged(); }
        }
        private string bankIban;
        private string tckn;

        public string TCKN
        {
            get { return tckn; }
            set { tckn = value; OnPropertyChanged(); }
        }

        public string BankIban
        {
            get { return bankIban; }
            set { bankIban = value; OnPropertyChanged(); }
        }
        private string bankcode;
        public string BankCode
        {
            get { return bankcode; }
            set { bankcode = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private ObservableCollection<People> model;
        public ObservableCollection<People> Model
        {
            get { return model; }
            set { model = value; }
        }
        public PeopleViewModel()
        {
            model = new ObservableCollection<People>();
        }
        void ModelData()
        {
            Bank bank = new Bank()
            {
                BankCode = "11111",
                BankIban = "123123-123123-123",
                BankId = model.Count + 1
            };
            People people = new People()
            {
                Email = email,
                FatherName = fathername,
                FirstName = firstname,
                Id = Model.Count + 1,
                LastName = lastname,
                MotherName = mothername,
                Phone = phone,
                TCKN = tckn,
                BankId = bank.BankId
            };
            model.Add(people);
        }

    }
}
