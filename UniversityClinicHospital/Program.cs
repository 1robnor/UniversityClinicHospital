using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor myDoctor = new Doctor(1, "Big Jon", "Lung Development");
            Console.WriteLine($"{myDoctor.EmployeeId} {myDoctor.EmployeeName} {myDoctor.SpecialtyArea}");

            Nurse myNurse = new Nurse(2, "Carol", 1);
            Console.WriteLine($"{myNurse.EmployeeId} {myNurse.EmployeeName} {myNurse.NumberOfPatients}");

            Receptionist myReceptionist = new Receptionist(3, "Rachael");
            Console.WriteLine($"{myReceptionist.EmployeeId} {myReceptionist.EmployeeName} ");

            Janitor myJanitor = new Janitor(4, "Steve");
            Console.WriteLine($"{myJanitor.EmployeeId} {myJanitor.EmployeeName}");

            Console.ReadKey();
        }

    }
}
