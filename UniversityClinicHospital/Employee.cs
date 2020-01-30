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
            HasBeenPaid = true;
        }
    
    }
}
