using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpP2_Homework_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Department> departments = new ObservableCollection<Department>();


        public MainWindow()
        {
            InitializeComponent();

            Presenter p = new Presenter(this);

            dhAddEmp.DialogClosing += (s, e) => { p.AddEmpDialogClosing(e); };
            dhAddDep.DialogClosing += (s, e) => { p.AddDepDialogClosing(e); };
        }

    }
}
