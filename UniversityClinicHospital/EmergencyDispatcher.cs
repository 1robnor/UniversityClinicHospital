using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class EmergencyDispatcher : Employee
    {
        public bool IsDispatched { get; set; }
        public bool IsOnThePhone { get; set; }
        public int Ambulance { get; set; }


        public EmergencyDispatcher()
        {
            HasBeenPaid = false;
            Salary = 45000;
            IsMedicalProfessional = false;
            IsOnThePhone = false;
        }

        public EmergencyDispatcher(int id, string name, int amb)
        {
            EmployeeId = id;
            EmployeeName = name;
            HasBeenPaid = false;
            Salary = 45000;
            IsMedicalProfessional = false;
            IsOnThePhone = false;
            Ambulance = amb;
        }


        public override void ShowEmployeeList()
        {
            base.ShowEmployeeList();
            Console.Write($" Is Dispatched: {IsDispatched} Medical Professional: {IsMedicalProfessional} Ambulance: {Ambulance}");

        }

        public override void CareForPatient(Patient myPatient)
        {
            //effect patient health status
            Console.Write($"Current health is : {myPatient.HealthStatus}");
            myPatient.HealthStatus += 6;
            Console.Write($" After Emergency Dispatcher visit : {myPatient.HealthStatus} \n");
        }

        public override void DrawBlood(Patient myPatient)
        {
            //effect patient Blood Level
            Console.Write($"Current Blood Level is : {myPatient.BloodLevel}");
            myPatient.BloodLevel -= 10;
            Console.Write($" After Emergency Dispatcher visit : {myPatient.BloodLevel} \n");
        }

        public override void PerformAdministrationTasks()
        {
            Console.WriteLine("Sorry you need to be part of Hospital Administration to Perform Tasks.");
        }

        

    }
}
