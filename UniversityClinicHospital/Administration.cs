using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Administration : Employee
    {


        public Administration()
        {
            Salary = 50000;
            HasBeenPaid = false;
            IsMedicalProfessional = false;
        }

        public Administration(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            Salary = 50000;
            HasBeenPaid = false;
            IsMedicalProfessional = false;
        }



        public override void CareForPatient(Patient myPatient)
        {
            Console.Write("Sorry you cannot care for a patient, stay in your lane. \n");
        }

        public override void DrawBlood(Patient myPatient)
        {
            Console.Write("Sorry you cannot draw blood for a patient, stay in your lane. \n");
        }

        public override void PerformAdministrationTasks()
        {
            bool isadministrating = true; 

            while (isadministrating)
            {
                Console.WriteLine("Welcome To University Clinic Hospital Administration menu!");
                Console.WriteLine("1. Pay All Hospital Bills");
                Console.WriteLine("2. Clean The Hospital");
                Console.WriteLine("3. Take Care of Guests");
                Console.WriteLine("4. Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("I am paying the bills!");
                        break;
                    case "2":
                        Console.WriteLine("I am cleaning the Hospital!");
                        break;
                    case "3":
                        Console.WriteLine("I am taking care of guests!");
                        break;
                    case "4":
                        isadministrating = false;
                        break;
                    default:
                        break;
                }
            }
            }


    }
}
