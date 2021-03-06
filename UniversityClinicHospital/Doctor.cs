﻿using System;
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
            IsMedicalProfessional = true;
        }

        public Doctor(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            SpecialtyArea = "Assign Me a Specialty";
            HasBeenPaid = false;
            Salary = 90000;
            IsMedicalProfessional = true;
        }

        public Doctor(int id, string name, string specialtyArea)
        {
            EmployeeId = id;
            EmployeeName = name;
            SpecialtyArea = specialtyArea;
            HasBeenPaid = false;
            Salary = 90000;
            IsMedicalProfessional = true;
        }


        //Methods

        public override void PaySalary()
        {
            base.PaySalary();
        }

        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" Specialty Area: {SpecialtyArea} Medical Professional: {IsMedicalProfessional}");

        }

        public override void CareForPatient(Patient myPatient)
        {
            //effect patient health status
            Console.Write($"Current health is : {myPatient.HealthStatus}");
            myPatient.HealthStatus += 10;
            Console.Write($" After Doctor visit : {myPatient.HealthStatus} \n"); 
        }

        public override void DrawBlood(Patient myPatient)
        {
            //effect patient Blood Level
            Console.Write($"Current Blood Level is : {myPatient.BloodLevel}");
            myPatient.BloodLevel -= 10;
            Console.Write($" After Doctor visit : {myPatient.BloodLevel} \n");
        }

        public override void PerformAdministrationTasks()
        {
            Console.WriteLine("Sorry you need to be part of Hospital Administration to Perform Tasks.");
        }

    }
}
