using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS", new DateTime(2021, 05, 26));
            // Create three employees
            Employee Dakota = new Employee("Dakota", "Upchurch", "Software Developer");
            Employee Jeremiah = new Employee("Jeremiah", "Schugt", "Software Developer");
            Employee Preston = new Employee("Preston", "Shotts", "Software Developer");
            // Assign the employees to the company
            NSS.AddEmployee(Dakota);
            NSS.AddEmployee(Jeremiah);
            NSS.AddEmployee(Preston);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployees();

        }
    }
}
