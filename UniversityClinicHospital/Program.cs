using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee firstEmployee = new Employee();
            Console.WriteLine(firstEmployee.EmployeeName);

            Employee secondEmployee = new Employee(1, "Rob");
            Console.WriteLine($"{secondEmployee.EmployeeId} , {secondEmployee.EmployeeName}");

            Console.ReadKey();

        }
    }
}
