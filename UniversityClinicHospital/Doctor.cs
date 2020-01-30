using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor:Employee
    {
        //Properties
        public string SpecialtyArea { get; set; }

        //Constructor
        public Doctor()
        {

        }

        public class Doctor(int employeeId, string employeeName, string specialtyArea)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            SpecialtyArea = specialtyArea;
            HasBeenPaid = false;
            Salary = 90000;
        }


        //Methods

    }
}
