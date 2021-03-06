﻿using System;
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
            IsMedicalProfessional = false;
        }

        public Receptionist(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            IsOnThePhone = false;
            HasBeenPaid = false;
            Salary = 45000;
            IsMedicalProfessional = false;
        }

        //Methods
        public override void PaySalary()
        {
            base.PaySalary();
        }
        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" On the Phone: {IsOnThePhone} Medical Professional: {IsMedicalProfessional}");

        }
        public override void CareForPatient(Patient myPatient)
        {
            //effect 
            Console.Write("Sorry you cannot care for a patient, stay in your lane. \n");
        }

        public override void DrawBlood(Patient myPatient)
        {
            Console.Write("Sorry you cannot draw blood for a patient, stay in your lane. \n");

        }

        public override void PerformAdministrationTasks()
        {
            Console.WriteLine("Sorry you need to be part of Hospital Administration to Perform Tasks.");
        }

    }
}
