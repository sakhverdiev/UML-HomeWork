using System;

namespace Iterator_DP;

class Employee
{
    public int id;
    public string firstName;
    public string lastName;
    public Employee(int id, string firstName, string lastName)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }
}

// Iterator Interface
interface IIterator<T>
{
    bool HasNext();
    T GetCurrentItem();
}

// Aggregate Interface
interface IEmployeeAggregate
{
    IIterator<Employee> CreateIterator();
}

// ConcreteAggregate Class
class EmployeeListAggregate : IEmployeeAggregate
{
    private List<Employee> _Employees;
    public EmployeeListAggregate()
    {
        _Employees = new List<Employee>();
    }
    public void Add(Employee Employee)
    {
        _Employees.Add(Employee);
    }
    public int Count()
    {
        return _Employees.Count;
    }
    public Employee Get(int index)
    {
        return _Employees[index];
    }
    public IIterator<Employee> CreateIterator()
    {
        return new EmployeeIterator(this);
    }
}

class EmployeeIterator : IIterator<Employee>
{
    private EmployeeListAggregate _EmployeeListAggregate;
    private int _currentIndex;
    public EmployeeIterator(EmployeeListAggregate EmployeeListAggregate)
    {
        _EmployeeListAggregate = EmployeeListAggregate;
        _currentIndex = 0;
    }
    public Employee GetCurrentItem()
    {
        return _EmployeeListAggregate.Get(_currentIndex++);

    }
    public bool HasNext()
    {
        if (_EmployeeListAggregate.Count() > _currentIndex)
        {
            return true;
        }
        return false;
    }
}