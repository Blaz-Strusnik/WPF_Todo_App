using System;
using System.Collections.Generic;
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
using System.Data.Entity;

namespace WPF_Todo_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Todo_app_WPFEntities context = new Todo_app_WPFEntities();
        CollectionViewSource tasksViewSource;
        CollectionViewSource tasksViewSource1;

        public MainWindow()
        {
            InitializeComponent();

            tasksViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tasksViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // tasksViewSource.Source = [generic data source]
            tasksViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tasksViewSource1")));
            // Load data by setting the CollectionViewSource.Source property:
            // tasksViewSource1.Source = [generic data source]
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Tasks.Load();
            tasksViewSource.Source = context.Tasks.Local;
            tasksViewSource1.Source = context.Tasks.Local;
        }
    }
}
