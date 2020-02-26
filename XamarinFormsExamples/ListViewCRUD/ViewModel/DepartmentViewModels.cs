using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; OnPropertyChanged(); }
		}
		private string departmentname;

		public string DepartmentName
		{
			get { return departmentname; }
			set { departmentname = value; OnPropertyChanged(); }
		}
		void DepartmentData()
		{
			departments = new List<Department>();
			departments.Add(new Department() { DepartmentId = 1, DepartmentName = "Department Of Computer"});
			departments.Add(new Department() { DepartmentId = 2, DepartmentName = "Staff Department"});
			departments.Add(new Department() { DepartmentId = 3, DepartmentName = "Accounting Department"});
			departments.Add(new Department() { DepartmentId = 4, DepartmentName = "Computing Department"});
			departments.Add(new Department() { DepartmentId = 5, DepartmentName = "Revir" });
		}
		private List<Department> departments;
		public List<Department> Departments
		{
			get { return departments; }
			set { departments = value; OnPropertyChanged(); }
		}

	}
}
