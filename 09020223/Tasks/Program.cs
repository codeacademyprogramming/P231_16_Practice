using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            string option;
            do
            {
                Console.WriteLine("1. Isci elave et");
                Console.WriteLine("2. Butun iscilere bax");
                Console.WriteLine("3. Maas araligina gore isciler uzre axtaris et");
                Console.WriteLine("4. Vezifesine gore isciler uzre axtari et");
                Console.WriteLine("5. Baslama tarixi intervalina gore isciler uzre axtaris et");
                Console.WriteLine("0. Cix");

                Console.Write("\nSecim edin: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("FullName: ");
                        string fullname = Console.ReadLine();

                        double salary;
                        
                        do
                        {
                            Console.Write("Salary: ");

                        } while (!double.TryParse(Console.ReadLine(),out salary) || salary<300);
                       
                        

                        Console.Write("Position: ");
                        string position = Console.ReadLine();

                        Console.Write("StartDate: ");
                        DateTime startDate = Convert.ToDateTime(Console.ReadLine());

                        Employee emp = new Employee(fullname, position, salary, startDate);

                        company.AddEmployee(emp);
                        break;
                    case "2":
                        company.ShowEmployees();
                        break;
                    case "3":
                        Console.Write("MinSalary:");
                        double minSalary = Convert.ToDouble(Console.ReadLine());
                        Console.Write("MaxSalary:");
                        double maxSalary = Convert.ToDouble(Console.ReadLine());


                        var employees = company.GetEmployees(x => x.Salary >= minSalary && x.Salary <= maxSalary);
                        employees = company.Employees.FindAll(x => x.Salary >= minSalary && x.Salary <= maxSalary);

                        foreach (var item in employees)
                        {
                            Console.WriteLine(item);
                        }

                        break;
                    case "4":
                        Console.Write("Position:");
                        string wantedPosition = Console.ReadLine();

                        employees = company.GetEmployees(x => x.Position == wantedPosition);

                        foreach (var item in employees)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "5":
                        Console.Write("MinSalary:");
                        minSalary = Convert.ToDouble(Console.ReadLine());
                        Console.Write("MaxSalary:");
                        maxSalary = Convert.ToDouble(Console.ReadLine());

                        var wantedEmp = company.Employees.Find(x => x.Salary >= minSalary && x.Salary <= maxSalary);

                        if (company.Employees.Exists(x => x.Salary >= minSalary && x.Salary <= maxSalary))
                        {
                            Console.WriteLine("Var");
                        }
                        else
                        {
                            Console.WriteLine("Yoxdur");
                        }

                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi!");
                        break;
                    default:
                        Console.WriteLine("Secim yanlisdir!");
                        break;
                }

            } while (option!="0");
            
        }
    }
}
