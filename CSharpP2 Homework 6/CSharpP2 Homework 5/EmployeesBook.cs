using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpP2_Homework_5
{
    class EmployeesBook
    {

        List<Employee> empBook;
        public List<Employee> EmpBook { get; private set; }

        public int EmpCount { get => empBook.Count; }

        public void Add(Employee emp) { empBook.Add(emp); }


    }
}
