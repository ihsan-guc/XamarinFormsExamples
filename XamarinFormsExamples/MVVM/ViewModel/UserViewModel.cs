using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinFormsExamples.MVVM.Model;

namespace XamarinFormsExamples.MVVM.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
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
        List<User> users = new List<User>();
    }
}
