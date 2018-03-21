using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CSharpP2_Homework_5
{
    class Presenter
    {
        private Model model;
        private MainWindow view;

        public Presenter(MainWindow View)
        {
            this.view = View;
            model = new Model();
            view.gDepartments.DataContext = Model.Departments.Local;
            view.gEmployees.DataContext = Model.Employees.Local;
            view.gEmployees.RowEditEnding += (s, e) => { model.AddEmp(e); };
        }


        public void AddEmpDialogClosing(DialogClosingEventArgs eventArgs)
        {

            if (!Equals(eventArgs.Parameter, true))
            {
                ClearAddEmpDialog();
                return;
            }
            model.AddEmp(view.tbEmpSurname.Text, view.tbEmpName.Text, view.tbEmpPatronimyc.Text, 0);
            
            ClearAddEmpDialog();
        }

        void ClearAddEmpDialog()
        {
            view.tbEmpSurname.Clear();
            view.tbEmpName.Clear();
            view.tbEmpPatronimyc.Clear();
        }

        public void AddDepDialogClosing(DialogClosingEventArgs e)
        {
            if (!Equals(e.Parameter, true))
            {
                view.tbDepName.Clear();
                return;
            }
            model.AddDep(view.tbDepName.Text);
            view.tbDepName.Clear();
        }
    }
}