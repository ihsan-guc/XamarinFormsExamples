using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsExamples.ListViewCRUD.Model
{
    public class Department : INotifyPropertyChanged
    {
        public int departmentId;
        public int DepartmentId { get { return departmentId; } set { departmentId = value; OnPropertyChanged(); } }
        public string departmentName { get; set; }
        public string DepartmentName { get { return departmentName; } set { departmentName = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
