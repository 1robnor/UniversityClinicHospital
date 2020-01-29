using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee(1, "Rob");
            Console.WriteLine($"{firstEmployee.EmployeeId} {firstEmployee.EmployeeName}");

            Console.ReadKey();

        }
    }
}
