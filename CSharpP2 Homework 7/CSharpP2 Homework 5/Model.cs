using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Windows.Controls;

namespace CSharpP2_Homework_5
{
    class Model
    {
        static homeworkdbEntities db;

        public static DbSet<EMPLOYEES> Employees { get => db.EMPLOYEES; }
        public static DbSet<DEPARTMENT> Departments { get=> db.DEPARTMENT; }



        public Model()
        {
            db = new homeworkdbEntities();
            db.EMPLOYEES.Load();
            db.DEPARTMENT.Load();
        }

        #region Данные


        #endregion


        public void AddEmp(string name, string surname, string patronymic, int depID)
        {
            Employees.Add(new EMPLOYEES() { NAME = name, SURNAME = surname, PATRONYMIC = patronymic, DEPID = depID }); 
            db.SaveChanges();
        }

        public void AddDep(string name)
        {
            Departments.Add(new DEPARTMENT() { FULLNAME = name });
            db.SaveChanges();
        }

        public void DeleteEmp(int ID)
        {
            var de = Employees.First(x => x.ID == ID);
            Employees.Remove(de);
            db.SaveChanges();
        }

        public void DeleteDep(int ID)
        {
            var dd = Departments.First(x => x.ID == ID);
            Departments.Remove(dd);
            db.SaveChanges();
        }
    }
}
