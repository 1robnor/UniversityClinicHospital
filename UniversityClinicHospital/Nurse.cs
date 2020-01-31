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
            HasBeenPaid = false;
            Salary = 50000;
        }

        public Nurse(int id, string name, int numberOfPatients)
        {
            EmployeeId = id;
            EmployeeName = name;
            NumberOfPatients = numberOfPatients;
            HasBeenPaid = false;
            Salary = 50000;
        }

        //methods
        public override void PaySalary()
        {
            base.PaySalary();
        }
        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" Number of Patients: {NumberOfPatients}");

        }
        public override void CareForPatient(Patient myPatient)
        {
            //effect patient health status
            Console.Write($"Current health is : {myPatient.HealthStatus}");
            myPatient.HealthStatus += 5;
            Console.Write($" After Nurse visit : {myPatient.HealthStatus} \n");
        }
    }
}
