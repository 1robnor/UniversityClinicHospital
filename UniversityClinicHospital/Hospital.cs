using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Hospital
    {
        //Create List
        List<Employee> employeeList = new List<Employee>();

        //Properties
        public int HospitalId { get; set; }
        public String HosptialName { get; set; }

        //Constructors
        public Hospital()
        {

        }

        public Hospital(int id, string name)
        {
            HospitalId = id;
            HosptialName = name;
        }

        //Methods
        public void SeedEmployeeList()
        {
            // Add parts to the list.
            employeeList.Add(new Doctor { EmployeeId = 1, EmployeeName = "Dr. Feel Good", SpecialtyArea = "Heart Surgeon" });
            employeeList.Add(new Nurse { EmployeeId = 2, EmployeeName = "Nurse FeelGood", NumberOfPatients = 1 });
            employeeList.Add(new Receptionist { EmployeeId = 3, EmployeeName = "Rachael" });
            employeeList.Add(new Janitor { EmployeeId = 4, EmployeeName = "Steve" });
            employeeList.Add(new Administration { EmployeeId = 5, EmployeeName = "Sam" });
        }

        public void ShowEmployeeList()
        {
            foreach (Employee listofEmployees in employeeList)
            {         
                listofEmployees.ShowEmployeeList();
                Console.WriteLine();
            }
        }


        public void PayAllEmployees()
        {
            foreach (Employee employee in employeeList)
            {
                employee.PaySalary();
            }

        }

        public void HealthStatusForPatient(Patient myPatient)
        {
            Console.WriteLine("Select a medical professional to care for patient by ID.");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            Employee selectedEmployee = employeeList[userSelection - 1];
            selectedEmployee.CareForPatient(myPatient);
        }

        public void DrawBloodFromPatient(Patient myPatient)
        {

            Console.WriteLine("Select a medical professional to care for patient by ID.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Employee chosenEmployee = employeeList[userChoice - 1];
            chosenEmployee.DrawBlood(myPatient);
        }

        public void ExecuteHospitalNeeds()
        {
            foreach (Employee listofEmployees in employeeList)
            {
                listofEmployees.ShowEmployeeList();
                Console.WriteLine();
            }

            Console.WriteLine("Select an administrator to to take care of hospital.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Employee chosenEmployee = employeeList[userChoice - 1];
            chosenEmployee.PerformAdministrationTasks();

        }
        

    }
}
