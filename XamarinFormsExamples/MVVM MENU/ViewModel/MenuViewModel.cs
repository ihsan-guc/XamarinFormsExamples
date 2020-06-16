using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsExamples.MVVM_MENU.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        private ICommand navigateCommand;
        public ICommand NavigateCommand
        {
            get { return navigateCommand; }
            set { navigateCommand = value; OnPropertyChanged(); }
        }
        public async void NavigateCommandClick()
        {
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await App.Current.MainPage.Navigation.PushAsync(page);
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
