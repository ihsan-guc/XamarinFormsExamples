using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsExamples.ListViewCRUD.Model;

namespace XamarinFormsExamples.ListViewCRUD.ViewModel
{
    public class DepartmentViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public DepartmentViewModels()
        {
            addcommand = new Command(AddDepartment);
        }
        private string departmentname;

        public string DepartmentName
        {
            get { return departmentname; }
            set { departmentname = value; OnPropertyChanged(); }
        }
        void DepartmentData()
        {
            departments.Add(new Department() { DepartmentId = 1, DepartmentName = "Department Of Computer" });
            departments.Add(new Department() { DepartmentId = 2, DepartmentName = "Staff Department" });
            departments.Add(new Department() { DepartmentId = 3, DepartmentName = "Accounting Department" });
            departments.Add(new Department() { DepartmentId = 4, DepartmentName = "Computing Department" });
            departments.Add(new Department() { DepartmentId = 5, DepartmentName = "Revir" });
        }
        private ObservableCollection<Department> departments;
        public ObservableCollection<Department> Departments
        {
            get
            {
                if (departments == null)
                    departments = new ObservableCollection<Department>();
                return departments;
            }
            set { departments = value; OnPropertyChanged(); }
        }
        public ICommand addcommand;
        public ICommand AddCommand
        {
            get { return addcommand; }
            set { addcommand = value; OnPropertyChanged(); }
        }
        public void AddDepartment()
        {
            var department = new Department()
            {
                DepartmentId = departments.Count + 1,
                DepartmentName = DepartmentName
            };
            if (department != null) 
            {
                departments.Add(department);
            }
        }
    }
}
