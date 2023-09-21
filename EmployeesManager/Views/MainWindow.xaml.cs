using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeesManager
{
    public partial class MainWindow : Window
    {
        // Create ObservableCollection to save Employees Data
        public ObservableCollection<Models.Employee> Employees= new ObservableCollection<Models.Employee>();

        public MainWindow()
        {
            InitializeComponent();

            // Fill the DataGrid with the List of Employees  
            employeesDataGrid.ItemsSource = Employees;
        }

        /// <summary>
        /// 
        /// This method add new employee to the collection we had created previously 
        /// This method GET its arguments from the filled TextBoxs in MainWindow
        /// A Control Test for the inputs arguments from users was implemented in order to have a better User Exprience
        /// 
        /// </summary>
        private void addNewEmployee(object sender, RoutedEventArgs e)
        {
            // Control Inputs
            if (string.IsNullOrWhiteSpace(inputName.Text))
            {
                MessageBox.Show("You have to enter a valid name!");
            }
            else if (string.IsNullOrWhiteSpace(inputAddress.Text))
            {
                MessageBox.Show("You have to enter a valid address!");
            }
            else if (string.IsNullOrWhiteSpace(inputSalary.Text) || !float.TryParse(inputSalary.Text, out float result))
            {
                MessageBox.Show("You have to enter a valid salary!");
            }
            else
            {
                // Create a New Employee Object
                Models.Employee employee = new Models.Employee(inputName.Text, inputAddress.Text, float.Parse(inputSalary.Text));

                // Add an Employee to the DataCollection
                Employees.Add(employee);

                // Clear TextBox Fields
                inputName.Clear();
                inputAddress.Clear();
                inputSalary.Clear();
            }

        }
    }
}
