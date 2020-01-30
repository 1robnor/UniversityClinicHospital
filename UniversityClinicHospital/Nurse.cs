using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {

        //properties
        public int NumberOfPatients { get; set; }

        //constructor
        public Nurse()
        {

        }

        public Nurse(int employeeId, string employeeName, int numberOfPatients)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            NumberOfPatients = NumberOfPatients;
            HasBeenPaid = false;
            Salary = 50000;
        }

        //methods
        public override void PaySalary()
        {
            base.PaySalary();git
        }

    }
}
