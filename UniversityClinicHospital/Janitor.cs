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
            IsMedicalProfessional = false;
        }

        public Janitor(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            IsSweeping = false;
            Salary = 40000;
            HasBeenPaid = false;
            IsMedicalProfessional = false;
        }
        //methods
        public override void PaySalary()
        {
            base.PaySalary();
        }

        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" Is Sweeping: {IsSweeping} Medical Professional: {IsMedicalProfessional}");

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
