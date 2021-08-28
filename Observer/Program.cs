using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.Atach(new WelcomeLetter());
            Employee.Atach(new RentSubsidyValification());

            var employee = new Employee("hoge", "fuga");
            employee.NotifyNewEmployee();
        }
    }

class Employee
{
    static private List<INewEmployeeObserver> _observers = new List<INewEmployeeObserver>();
    static public void Atach(INewEmployeeObserver observer)
        => _observers.Add(observer);

    static public void Detach(INewEmployeeObserver observer)
        => _observers.Remove(observer);

    private readonly string _name;
    public string Name => _name;

    private readonly string _address;

    public string Address => _address;

    public Employee(string name, string address)
    {
        _name = name;
        _address = address;
    }

    public void NotifyNewEmployee()
    {
        foreach(var observer in _observers)
        {
            observer.Update(this);
        }
    }
}

    interface INewEmployeeObserver
    {
        public void Update(Employee employee);
    }

class WelcomeLetter: INewEmployeeObserver
{
    public void Update(Employee employee)
    {
        Console.WriteLine($"Welcome to our company {employee.Name}");
    }
}

    class RentSubsidyValification: INewEmployeeObserver
    {
        public void Update(Employee employee)
        {
            var address = employee.Address;

            // some Logic
            //
            Console.WriteLine($"{employee.Name} rent will be subsidized by us.");
        }
    }
}
