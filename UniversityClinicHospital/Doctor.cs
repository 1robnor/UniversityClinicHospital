using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        //Properties
        public string SpecialtyArea { get; set; }

        //Constructor
        public Doctor()
        {
            HasBeenPaid = false;
            Salary = 90000;
        }

        public Doctor(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            SpecialtyArea = "Assign Me a Specialty";
            HasBeenPaid = false;
            Salary = 90000;
        }

        public Doctor(int id, string name, string specialtyArea)
        {
            EmployeeId = id;
            EmployeeName = name;
            SpecialtyArea = specialtyArea;
            HasBeenPaid = false;
            Salary = 90000;
        }


        //Methods

        public override void PaySalary()
        {
            base.PaySalary();
        }

        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" Specialty Area: {SpecialtyArea}");

        }
    }
}
