using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class HospitalTests
    {
        [Fact]
        public void Class_Can_Creat_Hospital_Class()
        {
            Hospital myHosptial = new Hospital();
        }

        [Fact]
        public void HospitalId_Can_assign_id()
        {
            //Arrange
            Hospital myHosptial = new Hospital(1, "UHC");
            //act

            //Asset
            Assert.Equal(1, myHosptial.HospitalId);
        }

        [Fact]
        public void HospitalName_Can_Assign_Name()
        { 
           
            //Arrange
            Hospital myHosptial = new Hospital(1, "UHC");
            //act

            //Asset
            Assert.Equal("UHC", myHosptial.HosptialName);
            
        }



    }

}
