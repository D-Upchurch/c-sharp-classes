using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeeList = new List<Employee>();

        public void AddEmployee(Employee NewEmployee)
        {
            EmployeeList.Add(NewEmployee);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        public void ListEmployees()
        {
            foreach (Employee item in EmployeeList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} works for {Name} as a {item.Title} since {item.StartDate.ToShortDateString()}");
            }

        }

    }
}
