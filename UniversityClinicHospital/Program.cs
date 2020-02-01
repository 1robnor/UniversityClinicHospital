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
                        foreach (Employee employee in employeeList)
                        {
                            employee.ShowEmployeeList();
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        foreach (Employee employee in employeeList)
                        {
                            employee.PaySalary();
                        }
                        break;

                    case "3":
                        Console.Clear();
                        myPatient.ViewPatientInfo();
                        break;
                    case "4":
                        Console.Clear();
                        foreach (Employee employee in employeeList)
                        {
                            employee.ShowEmployeeList();
                            Console.WriteLine();
                        }

                        Console.WriteLine("Select a medical professional to care for patient by ID.");
                        int userSelection = Convert.ToInt32(Console.ReadLine());
                        Employee selectedEmployee = employeeList[userSelection - 1];
                        selectedEmployee.CareForPatient(myPatient);

                        break;
                    case "5":
                        Console.Clear();
                        foreach (Employee employee in employeeList)
                        {
                            employee.ShowEmployeeList();
                            Console.WriteLine();
                        }

                        Console.WriteLine("Select a medical professional to care for patient by ID.");
                        int userChoice = Convert.ToInt32(Console.ReadLine());
                        Employee chosenEmployee = employeeList[userChoice - 1];
                        chosenEmployee.DrawBlood(myPatient);
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
