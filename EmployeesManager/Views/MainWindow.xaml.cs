using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeesManager
{
    public partial class MainWindow : Window
    {
        // Create ObservableCollection to save Employees Data
        private ObservableCollection<Models.Employee> employees = new ObservableCollection<Models.Employee>();

        public MainWindow()
        {
            InitializeComponent();

            // Fill the DataGrid with the List of Employees  
            employeesDataGrid.ItemsSource = employees;
        }
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
            else if (string.IsNullOrWhiteSpace(inputSalary.Text) || !int.TryParse(inputSalary.Text, out int result))
            {
                MessageBox.Show("You have to enter a valid salary!");
            }
            else
            {
                // Create a New Employee Object
                Models.Employee employee = new Models.Employee(inputName.Text, inputAddress.Text, int.Parse(inputSalary.Text));

                // Add an Employee to the DataCollection
                employees.Add(employee);

                // Clear TextBox Fields
                inputName.Clear();
                inputAddress.Clear();
                inputSalary.Clear();
            }

        }
    }
}
