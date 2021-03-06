﻿using System.Collections.ObjectModel;
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
            deletecommand = new Command(DeleteDepartment);
            updatecommand = new Command(UpdateDepartment);
            updatebutton = new Command(UpdateDepartmentButton);
            departments = new ObservableCollection<Department>();
            DepartmentData();
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
        public ICommand addcommand,deletecommand,updatecommand,updatebutton;
        public ICommand AddCommand
        {
            get { return addcommand; }
            set { addcommand = value; OnPropertyChanged(); }
        }
        public ICommand DeleteCommand
        {
            get { return deletecommand; }
            set { deletecommand= value; OnPropertyChanged(); }
        }
        public ICommand UpdateCommand
        {
            get { return updatecommand; }
            set { updatecommand = value; OnPropertyChanged(); }
        }
        public ICommand UpdateButton
        {
            get { return updatebutton; }
            set { updatebutton= value; OnPropertyChanged(); }
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
            Departments.ToList();
        }
        public void DeleteDepartment(object dep)
        {
            var department = (Department)dep;
            if (department != null)
            {
                Departments.Remove(department);
            }
        }
        private int departmentId;

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public void UpdateDepartment(object dep)
        {
            DepartmentName = "";
            var department = (Department)dep;
            if (department != null)
            {
                for (int i = 0; i < Departments.Count; i++)
                {
                    if (Departments[i].DepartmentId == department.DepartmentId)
                    {
                        departmentId = Departments[i].DepartmentId;
                        DepartmentName = Departments[i].DepartmentName;
                    }
                }
            }
        }
        public void UpdateDepartmentButton()
        {
            var department = Departments.FirstOrDefault(p=>p.DepartmentId == DepartmentId);
            if (DepartmentName != null)
            {
                for (var i = 0; i < Departments.Count; i++)
                {
                    if (Departments[i].DepartmentId == department.DepartmentId)
                    {
                        Departments[i].DepartmentName = DepartmentName;
                    }
                }
                Departments.ToList();
            }
        }
    }
}
