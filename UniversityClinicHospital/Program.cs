using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor myDoctor = new Doctor(1, "Big Jon", "Lung Development");
            Console.WriteLine($"{myDoctor.EmployeeId} {myDoctor.EmployeeName} {myDoctor.SpecialtyArea}"); 

            
            Console.ReadKey();


        }
    }
}
