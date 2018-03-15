using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

            view.DataContext = model;
        }


        public void AddEmpDialogClosing(DialogClosingEventArgs eventArgs)
        {

            if (!Equals(eventArgs.Parameter, true))
            {
                ClearAddEmpDialog();
                return;
            }
            model.Employees.Add(new Employee( view.tbEmpSurname.Text, view.tbEmpName.Text, view.tbEmpPatronimyc.Text, view.cbDeps.SelectedValue != null ? (int)view.cbDeps.SelectedValue : 0));
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
    }
}