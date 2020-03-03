using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinFormsExamples.MVVMMasterDetailPage.Model;
using XamarinFormsExamples.MVVMMasterDetailPage.View;

namespace XamarinFormsExamples.MVVMMasterDetailPage.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<MenuModel> _model;
        public ObservableCollection<MenuModel> Model
        {
            get
            {
                if (_model == null)
                {
                    _model = new ObservableCollection<MenuModel>();
                }
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        void OnPropertChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private void MenuData()
        {
            Model.Clear();
            Model.Add(new MenuModel { Id = 1, Icon = "Arka.png", Name = "Home", TargetType = typeof(Home) });
            Model.Add(new MenuModel { Id = 3, Icon = "Ekle.png", Name = "Fiş Ekle", TargetType = typeof(About) });
        }
        public MenuViewModel()
        {
            MenuData();
        }
    }
}
