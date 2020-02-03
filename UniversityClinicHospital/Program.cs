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

            //  Seed The list
            myHospital.SeedEmployeeList();

            //Create Patient
            Patient myPatient = new Patient(1, "Sam");

            //Create counter for tick method
            int counter = 0;

            bool hospitalIsRunning = true;

            while(hospitalIsRunning)
            {
                Console.WriteLine("Welcome To University Clinic Hospital!");
                Console.WriteLine("1. List all Employees");
                Console.WriteLine("2. Pay All Employees");
                Console.WriteLine("3. View Patient Information");
                Console.WriteLine("4. Care For Patient");
                Console.WriteLine("5. Draw Patient Blood");
                Console.WriteLine("6. Administration Tasks");
                Console.WriteLine("7. Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        myHospital.ShowEmployeeList();
                        counter++;
                        break;
                    case "2":
                        Console.Clear();
                        myHospital.PayAllEmployees();
                        counter++;
                        break;
                    case "3":
                        Console.Clear();
                        myPatient.ViewPatientInfo();
                        counter++;
                        break;
                    case "4":
                        Console.Clear();
                        myHospital.ShowEmployeeList();
                        myHospital.HealthStatusForPatient(myPatient);
                        counter++;
                        break;
                    case "5":
                        Console.Clear();
                        myHospital.ShowEmployeeList();
                        myHospital.DrawBloodFromPatient(myPatient);
                        counter++;
                        break;
                    case "6":
                        myHospital.ExecuteHospitalNeeds();
                        break;
                    case "7":
                        hospitalIsRunning = false;
                        break;
                    default:
                        break;
                }

                //Invoke Tick Method Stretch Task
                if (counter % 5 == 0)
                {
                    Console.Clear();
                    //Do some tasks in here
                    Console.WriteLine("5 Hospital Interactions occurred!");

                    //Change HealthLevel
                    Console.WriteLine($"Your patient's health status has changed to {myPatient.HealthStatus = 60}");

                    //Add Patient to Nurse
                    //Toggle Receptionist on the phone
                    //Toggle Janitor is sweeping
                    myHospital.TickMethod();


                }

            }

            Console.ReadKey();
        }

    }
}
