using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpP2_Homework_5
{
    class Department
    {
        string name;
        public string Name { get => name; }
        public int ID { get; private set; }


        static int currentID = 0;

        List<int> employees;
        public int EmployeesCount { get => employees.Count; }

        public Department(string name)
        {
            this.name = name;
            ID = currentID++;
        }

        public void Add(int empID) => employees.Add(empID);
    }
}
