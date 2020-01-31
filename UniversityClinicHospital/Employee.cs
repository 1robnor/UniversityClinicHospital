using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    abstract public class Employee
    {

        //Properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool HasBeenPaid { get; set; }
        public int Salary { get; set; }

        //Methods
        public virtual void PaySalary()
        {

            if(HasBeenPaid)
                Console.WriteLine("All Employees have been paid!");
            else
                Console.WriteLine("You have already paid employees, but I am sure they would like 2 paychecks, Sorry!");

            HasBeenPaid = true;
        }
    
    }
}
