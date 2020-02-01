using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Hospital
    {
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

    }
}
