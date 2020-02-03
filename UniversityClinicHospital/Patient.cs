using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {

        //Properties
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int BloodLevel { get; set; }
        public int HealthStatus { get; set; }

        //Constructors

        public Patient()
        {
            BloodLevel = 100;
            HealthStatus = 100;
        }

        public Patient(int id, string name)
        {
            PatientId = id;
            PatientName = name;
            BloodLevel = 100;
            HealthStatus = 100;
        }

        //Methods

        public void ViewPatientInfo()
        {
            Console.WriteLine($"Patient Id:{PatientId} Name:{PatientName} BloodLevel: {BloodLevel} HealthStatus: {HealthStatus}");
        }

    }
}
