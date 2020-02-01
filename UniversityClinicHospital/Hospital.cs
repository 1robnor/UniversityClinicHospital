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
        }

        public void ShowEmployeeList()
        {
            foreach (Employee employee in employeeList)
            {
                employee.ShowEmployeeList();
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


    }
}
