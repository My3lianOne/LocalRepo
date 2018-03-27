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
                view.gDepartments.ItemsSource = Model.Departments.Local.ToBindingList();
                view.gEmployees.ItemsSource = Model.Employees.Local.ToBindingList();
                view.cbDeps.ItemsSource = Model.Departments.Local.ToBindingList();
            }


            public void AddEmpDialogClosing(DialogClosingEventArgs eventArgs)
            {

                if (!Equals(eventArgs.Parameter, true))
                {
                    ClearAddEmpDialog();
                    return;
                }
                model.AddEmp(view.tbEmpSurname.Text, view.tbEmpName.Text, view.tbEmpPatronimyc.Text, (int)view.cbDeps.SelectedValue);
            
                ClearAddEmpDialog();
            }

        internal void DeleteDep()
        {
            if (view.gDepartments.SelectedItems.Count > 0)
            {
                for (int i = 0; i < view.gDepartments.SelectedItems.Count; i++)
                {
                    DEPARTMENT dep = view.gDepartments.SelectedItems[i] as DEPARTMENT;
                    if (dep != null)
                    {
                        model.DeleteDep(dep.ID);
                    }
                }
            }
        }

        internal void DeleteEmp(RoutedEventArgs e)
        {
            if (view.gEmployees.SelectedItems.Count > 0)
            {
                for (int i = 0; i < view.gEmployees.SelectedItems.Count; i++)
                {
                    EMPLOYEES emp = view.gEmployees.SelectedItems[i] as EMPLOYEES;
                    if (emp != null)
                    {
                        model.DeleteEmp(emp.ID);
                    }
                }
            }
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