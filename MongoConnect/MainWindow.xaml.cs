using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MongoConnect.Models;

namespace MongoConnect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MongoHelper mongoHelper = new MongoHelper();
            mongoHelper.Connector_Click();
            MyDG.ItemsSource = mongoHelper.students;
            List<Student> temp = mongoHelper.students;

            temp.ForEach(PrintDialog);

            //temp.ForEach(student =>
            //{
            //    Debug.WriteLine(student.FirstName);
            //    Debug.WriteLine(student.LastName);
            //    Debug.WriteLine(student.Email);
            //});

        }

        private void PrintDialog(Student s)
        {
            Debug.WriteLine(s.FirstName);
            Debug.WriteLine(s.LastName);
            Debug.WriteLine(s.Email);

        }
    }
}
