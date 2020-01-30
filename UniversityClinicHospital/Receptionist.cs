using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        //Properties
        public bool IsOnThePhone { get; set; }

        //Constructors
        public Receptionist()
        {
            IsOnThePhone = false;
            HasBeenPaid = false;
            Salary = 45000;
        }

        public Receptionist(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            IsOnThePhone = false;
            HasBeenPaid = false;
            Salary = 45000;
        }

        //Methods
    }
}
