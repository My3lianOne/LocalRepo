using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace CSharpP2_Homework_5
{
    class Model
    {
        ObservableCollection<Employee> employees;
        ObservableCollection<Department> departments;


        public Model()
        {
            employees = new ObservableCollection<Employee>();
            departments = DepartmentBook.Departments;
            departments.Add(new Department("Не указан"));
        }

        #region Данные

        public ObservableCollection<Employee> Employees { get { return this.employees; } }
        public ObservableCollection<Department> Departments { get { return this.departments; } }
        #endregion
    }
}
