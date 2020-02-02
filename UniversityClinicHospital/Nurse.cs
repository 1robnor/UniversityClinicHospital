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
            IsMedicalProfessional = true;
        }

        public Nurse(int id, string name, int numberOfPatients)
        {
            EmployeeId = id;
            EmployeeName = name;
            NumberOfPatients = numberOfPatients;
            HasBeenPaid = false;
            Salary = 50000;
            IsMedicalProfessional = true;
        }

        //methods
        public override void PaySalary()
        {
            base.PaySalary();
        }
        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" Number of Patients: {NumberOfPatients} Medical Professional: {IsMedicalProfessional}");

        }
        public override void CareForPatient(Patient myPatient)
        {
            //effect patient health status
            Console.Write($"Current health is : {myPatient.HealthStatus}");
            myPatient.HealthStatus += 5;
            Console.Write($" After Nurse visit : {myPatient.HealthStatus} \n");
        }

        public override void DrawBlood(Patient myPatient)
        {
            //effect patient Blood Level
            Console.Write($"Current Blood Level is : {myPatient.BloodLevel}");
            myPatient.BloodLevel -= 5;
            Console.Write($" After Nurse visit : {myPatient.BloodLevel} \n");
        }
    }
}
