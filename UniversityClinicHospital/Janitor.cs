using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        //properties
        public bool IsSweeping { get; set; }

        //Constructors
        public Janitor()
        {
            IsSweeping = false;
            Salary = 40000;
            HasBeenPaid = false; 
        }

        //methods


    }
}
