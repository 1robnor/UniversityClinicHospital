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

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.EmployeeId} {employee.EmployeeName}");
            }

            //Create Patient
            Patient myPatient = new Patient(1, "Sam");
            Console.WriteLine($"{myPatient.PatientId} {myPatient.PatientName}");

            Console.ReadKey();
        }

    }
}
