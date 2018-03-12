using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpP2_Homework_5
{
    static class DepartmentBook
    {
        static ObservableCollection<Department> departments = new ObservableCollection<Department>();
        public static ObservableCollection<Department> Departments { get { return departments; } }
    }
}
