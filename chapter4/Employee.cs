using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Employee
    {
        private int employee_number;

        public Employee(int employee_number)
        {
            this.employee_number = employee_number;
        }

        private string name;
        private DateTime dateOfHire;
        private string jobDescription;
        private int monthlySalary;
        private string department;

        public Employee(int employee_number, string name)
        {
            this.employee_number = employee_number;
            this.name = name;

        }

        public Employee(int employee_number, string name, DateTime dateOfHire, string jobDescription, int monthlySalary, string department) : this(employee_number, name)
        {
            this.dateOfHire = dateOfHire;
            this.jobDescription = jobDescription;
            this.monthlySalary = monthlySalary;
            this.department = department;
        }

        public Employee()
        {
        }

        public int Employee_number { get => employee_number; set => employee_number = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfHire { get => dateOfHire; set => dateOfHire = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public int MonthlySalary { get => monthlySalary; set => monthlySalary = value; }
        public string Department { get => department; set => department = value; }

        public override string ToString()
        {
            return Employee_number + " " + name + "  " + jobDescription + " "+ monthlySalary;
        }




        
        
    }

}
