using System.ComponentModel;

namespace EmployeesManager.Models
{
    class Employee : INotifyPropertyChanged
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

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("Salary"); }
        }

        public Employee(string name, string address, int salary)
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