using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeesManager;
using EmployeesManager.Models;

[TestClass]
public class EmployeesManagerTests
{
    [TestMethod]
    public void TestAddNewEmployee()
    {
        // Load the MainWindow
        var mainWindow = new MainWindow();
        
        // Create a Fake Employee
        Employee employee = new Employee("Mohamed TOUNSI", "Ghomrassen, TATOUINE", 2023);

        // Try to add the created employee to the DataGrid in MainWindow
        mainWindow.Employees.Add(employee);

        // Asserts

        // Make sure we have just a single employee inserted in the DataGrid
        Assert.AreEqual(1, mainWindow.Employees.Count, "Number of Employees Unmatched!");
        
        // Test if the employee name matches the one we had previously transmitted
        Assert.AreEqual(employee.Name, mainWindow.Employees[0].Name, "Employee Name Unmatched!");
        
        // Make the same with the employee address
        Assert.AreEqual(employee.Address, mainWindow.Employees[0].Address, "Employee Address Unmatched!");
        
        // Same here with the salary
        Assert.AreEqual(employee.Salary, mainWindow.Employees[0].Salary, "Employee Salary Unmatched!");
    }
}
