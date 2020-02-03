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
            employeeList.Add(new EmergencyDispatcher { EmployeeId = 6, EmployeeName = "Fajita", Ambulance = 2 });

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
            string selChoice2 = Console.ReadLine();
            int userChoice2 = Convert.ToInt32(selChoice2);
            Employee selectedEmployee = employeeList[userChoice2 - 1];
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
            string selChoice = Console.ReadLine();
            int userChoice = Convert.ToInt32(selChoice);
            Employee chosenEmployee = employeeList[userChoice - 1];
            chosenEmployee.PerformAdministrationTasks();

        }

        public void TickMethod()
        {
            Nurse selNurse = new Nurse();
            selNurse = (Nurse)employeeList.Find(x => x.EmployeeId == 2);
            selNurse.NumberOfPatients++;
            Console.WriteLine($"Nurse now has { selNurse.NumberOfPatients} Patients");

            //Toggle Receptionist on the phone
            Receptionist selRecpt = new Receptionist();
            selRecpt = (Receptionist)employeeList.Find(x => x.EmployeeId == 3);
            if (selRecpt.IsOnThePhone)
            {
                Console.WriteLine($"Receptionist is on the phone {selRecpt.IsOnThePhone}");
                selRecpt.IsOnThePhone = false;
            }
            else
            {
                Console.WriteLine($"Receptionist is on the phone {selRecpt.IsOnThePhone}");
                selRecpt.IsOnThePhone = true;
            }

            //Toggle Janitor is sweeping
            Janitor selJanitor = new Janitor();
            selJanitor = (Janitor)employeeList.Find(x => x.EmployeeId == 4);
            if (selJanitor.IsSweeping)
            {
                Console.WriteLine($"Janitor is sweeping {selJanitor.IsSweeping}");
                selJanitor.IsSweeping = false;
            }
            else
            {
                Console.WriteLine($"Janitor is on the phone {selJanitor.IsSweeping}");
                selJanitor.IsSweeping = true;
            }


        }


    }
}
