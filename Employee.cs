using System;

namespace Classes
{
    public class Employee
    {

        public Employee(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = DateTime.Today;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}