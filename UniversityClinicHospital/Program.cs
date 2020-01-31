using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create List
            List<Employee> employeeList = new List<Employee>();

            // Add parts to the list.
            employeeList.Add(new Doctor {EmployeeId = 1, EmployeeName = "Dr. Feel Good", SpecialtyArea = "Heart Surgeon" });
            employeeList.Add(new Nurse { EmployeeId = 2, EmployeeName = "Nurse FeelGood", NumberOfPatients = 1 });
            employeeList.Add(new Receptionist { EmployeeId = 3, EmployeeName = "Rachael"});
            employeeList.Add(new Janitor { EmployeeId = 4, EmployeeName = "Steve"});

            
            //Create Patient
            Patient myPatient = new Patient(1, "Sam");
            Console.WriteLine($"{myPatient.PatientId} {myPatient.PatientName}");


            bool hospitalIsRunning = true;

            while(hospitalIsRunning)
            {

                Console.WriteLine("1. List all Employees");
                Console.WriteLine("2. Pay All Employees");
                Console.WriteLine("3. Exit");
                string userInput = Console.ReadLine();


                switch (userInput)
                {
                    case "1":
                        foreach (Employee employee in employeeList)
                        {
                            employee.ShowEmployeeList();
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        foreach (Employee employee in employeeList)
                        {
                            employee.PaySalary();
                        }
                        break;
                    case "3":
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
