using System.Collections.Generic;
using XamarinFormsExamples.ListView.Model;

namespace XamarinFormsExamples.ListView.ViewModel
{
    public class DepartmentViewModel
    {
        public DepartmentViewModel()
        {
            DepartmentData();
        }
        public void DepartmentData()
        {
            model = new List<Department>();
            model.Add(new Department() { DepartmentId = 1, DepartmentName="Department Of Computer", ImageSource="picture.png" ,IsCheck=false});
            model.Add(new Department() { DepartmentId = 2, DepartmentName= "Staff Department", ImageSource="picture.png" ,IsCheck=true });
            model.Add(new Department() { DepartmentId = 3, DepartmentName= "Accounting Department", ImageSource="picture.png" ,IsCheck=false });
            model.Add(new Department() { DepartmentId = 4, DepartmentName= "Computing Department", ImageSource="picture.png" ,IsCheck=true });
            model.Add(new Department() { DepartmentId = 5, DepartmentName= "Revir", ImageSource="picture.png" ,IsCheck=false });
        }
        private List<Department> model;
        public List<Department> Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
