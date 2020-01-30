using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    abstract class Employee
    {

        //Properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool HasBeenPaid { get; set; }
        public int Salary { get; set; }

  


        /*Constructors
        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            HasBeenPaid = false;
        }
        */


        //Methods
        public virtual void PaySalary()
        {
            HasBeenPaid = true;
        }

        
            
    }
}
