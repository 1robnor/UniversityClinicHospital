using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class HospitalTests
    {

        [Fact]
        public void Hospital_I_Can_Create_A_New_Class();
        {
            Hospital myHospital = new Hospital();

    }


    [Fact]
    public void HospitalId_Can_Assign_Id()
    {
        //Assign
        Hospital myHospital = new Hospital(1, "UCH");

        //Act

        //Assert
        Assert.Equal(1, myHospital.HospitalId);
    }

    [Fact]
    public void HospitalId_Can_Assign_Name()
    {
        //Assign
        Hospital myHospital = new Hospital(1, "UCH");

        //Act

        //Assert
        Assert.Equal("UCH", myHospital.HosptialName);
    }

}
}
