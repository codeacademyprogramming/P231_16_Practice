using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Employee
    {
        public Employee(string fullname,string positon, double salary, DateTime startDate)
        {
            FullName = fullname;
            Position = positon;
            Salary = salary;
            StartDate = startDate;
        }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            return $"Fullname: {FullName} - Position: {Position} - Salary: {Salary} - StartDate: {StartDate.ToString("dd-MM-yyyy HH:mm")}";
        }

    }
}
