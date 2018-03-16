using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
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
        private DataBaseController dbController;

        public Presenter(MainWindow View)
        {
            this.view = View;
            model = new Model();
            dbController = new DataBaseController();
            view.DataContext = model;
        }


        public void AddEmpDialogClosing(DialogClosingEventArgs eventArgs)
        {

            if (!Equals(eventArgs.Parameter, true))
            {
                ClearAddEmpDialog();
                return;
            }
            dbController.AddData(Employee.AddCommand, view.tbEmpSurname.Text, view.tbEmpName.Text, view.tbEmpPatronimyc.Text, (int)view.cbDeps.SelectedValue);
            
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
            model.Departments.Add(new Department(view.tbDepName.Text));
            view.tbDepName.Clear();
        }


        public void DeleteEmp()
        {
            dbController.DeleteData(Employee.DeleteCommand, view.gEmployees);
        }

        public void DeleteDep()
        {
            dbController.DeleteData(Employee.DeleteCommand, view.gDepartment);
        }
    }
}