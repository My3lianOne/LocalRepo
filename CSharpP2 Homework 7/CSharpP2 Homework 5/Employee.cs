using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpP2_Homework_5
{
    class Employee
    {
        string name;
        string surname;
        string patronymic;
        int depID;
        static int currentID = 0;
        int id;
        public int ID { get => id; }

        public string FullName { get => $"{name} {surname} {patronymic}"; }
        public string Department { get => DepartmentBook.Departments.First(x => x.ID == depID).Name; }

        public static string SelectCommand
        {
            get =>
            "SELECT ID, SURNAME, NAME, PATRONIMYC, DEP" +
            "FROM dbo.Employee" +
            "LEFT JOIN dbo.Department ON dbo.Department.ID = dbo.Employee.DEPID"
            ;
        }

        public static string DeleteCommand
        {
            get => "DELTE FROM dbo.Employee WHERE ID=@ID";
        }

        public static string AddCommand
        {
            get => "INSERT INTO dbo.Employee (SURNAME, NAME, PATRONIMYC, DEPID)" +
                "VALUES (@SURNAME, @NAME, @PATRONIMYC, @DEPID); SET @ID= @@IDENTITY;";
        }

        public void AssignToDep(int depID) => this.depID = depID;

        public Employee(string name, string surname, string patronymic, int depID) {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.depID = depID;
            id = currentID++;
        }

    }
}
