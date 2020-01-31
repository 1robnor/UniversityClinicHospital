using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        //properties
        public bool IsSweeping { get; set; }
        
        //Constructors
        public Janitor()
        {
            IsSweeping = false;
            Salary = 40000;
            HasBeenPaid = false; 
        }

        public Janitor(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            IsSweeping = false;
            Salary = 40000;
            HasBeenPaid = false;
        }
        //methods
        public override void PaySalary()
        {
            base.PaySalary();
        }

    }
}
