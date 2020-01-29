using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {

        //Properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool HasBeenPaid { get; set; }
        public int Salary { get; set; }

        public List<Employee> EmployeeList = new List<Employee> { };


        //Constructors
        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
            HasBeenPaid = false;
        }


        //Methods
        public void PaySalary()
        {
            HasBeenPaid = true;
        }

        public List<Employee> ReturnList()
        {
            return EmployeeList;
        }
        
            
    }
}
