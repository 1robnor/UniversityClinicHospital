using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a New Hospital
            Hospital myHospital = new Hospital(1, "UHC");

            //Create Patient
            Patient myPatient = new Patient(1, "Sam");
            //Console.WriteLine($"{myPatient.PatientId} {myPatient.PatientName}");


            bool hospitalIsRunning = true;

            while(hospitalIsRunning)
            {
                Console.WriteLine("Welcome To University Clinic Hospital!");
                Console.WriteLine("1. List all Employees");
                Console.WriteLine("2. Pay All Employees");
                Console.WriteLine("3. View Patient Information");
                Console.WriteLine("4. Care For Patient");
                Console.WriteLine("5. Draw Patient Blood");
                Console.WriteLine("6. Exit");
                string userInput = Console.ReadLine();


                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        myHospital.ShowEmployeeList();
                        break;
                    case "2":
                        Console.Clear();
                        myHospital.PayAllEmployees();
                        break;
                    case "3":
                        Console.Clear();
                        myPatient.ViewPatientInfo();
                        break;
                    case "4":
                        Console.Clear();
                        myHospital.ShowEmployeeList();
                        myHospital.HealthStatusForPatient(myPatient);
                        break;
                    case "5":
                        Console.Clear();
                        myHospital.ShowEmployeeList();
                        myHospital.DrawBloodFromPatient(myPatient);
                        break;
                    case "6":
                        hospitalIsRunning = false;
                        break;
                    default:
                        break;
                }


            }

            Console.ReadKey();
        }

    }
}
