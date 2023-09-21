using System.ComponentModel;

namespace EmployeesManager.Models
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }

        private float salary;

        public float Salary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("Salary"); }
        }

        public Employee(string name, string address, float salary)
        {
            this.Name = name;
            this.Address = address;
            this.Salary = salary;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}