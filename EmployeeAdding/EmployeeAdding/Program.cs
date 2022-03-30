using System;
using ClassLibrary;

namespace EmployeeAdding
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.EmployeeLimit = 2;

            Employee employee1 = new Employee();
            employee1.Name = "qezenfer";
            employee1.Surname = "Israfilov";
            department.AddEmployee(employee1);


            foreach (var item in department.employees)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
        }
    }
}
