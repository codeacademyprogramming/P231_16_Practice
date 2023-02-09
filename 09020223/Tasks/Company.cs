using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Company
    {
        private List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees => _employees;
        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public void ShowEmployees()
        {
            foreach (var item in _employees)
            {
                Console.WriteLine(item);
            }
        }

        public List<Employee> GetEmployees(Predicate<Employee> pred)
        {
            //List<Employee> wantedEmployees = new List<Employee>();

            //foreach (var item in _employees) 
            //{
            //    if(pred(item))
            //        wantedEmployees.Add(item);
            //}

            //return wantedEmployees;

            return _employees.FindAll(pred);
        }


    }
}
