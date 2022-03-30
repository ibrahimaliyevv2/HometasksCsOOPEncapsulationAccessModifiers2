using System;
namespace ClassLibrary
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] employees = new Employee[0];
        private double _salaryLimit;

        public double SalaryLimit { get
            {
                return this._salaryLimit;
            }
            set
            {
                if (value >= 250)
                {
                    this._salaryLimit = value;
                }
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (employees.Length < EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
        }
    }
}
