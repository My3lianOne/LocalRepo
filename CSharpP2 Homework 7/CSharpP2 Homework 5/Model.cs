using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Data;

namespace CSharpP2_Homework_5
{
    class Model
    {
        DataTable employees;
        DataTable departments;


        public Model()
        {
            employees = new DataTable();
            departments = new DataTable();
        }

        #region Данные

        public DataTable Employees { get { return this.employees; } }
        public DataTable Departments { get { return this.departments; } }
        #endregion

    }
}
