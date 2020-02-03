using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class PatientTest
    {
        [Fact]
        public void Patient_Can_I_Create_A_New_Class()
        {
            Patient firstPatient = new Patient();
        }

        [Fact]
        public void PatientId_Can_We_Assign_A_Number()
        {
            //Arrange
            Patient firstPatient = new Patient();

            //Act
            firstPatient.PatientId = 1;

            //Assert
            Assert.Equal(1, firstPatient.PatientId);
        }

        [Fact]
        public void Patient_Name_Can_We_Assign_A_Name()
        {
            //Arrange
            Patient firstPatient = new Patient();

            //Act
            firstPatient.PatientName = "Disco";

            //Assert
            Assert.Equal("Disco", firstPatient.PatientName);
        }

        [Fact]
        public void Patient_BloodLevel_Is_Set_To_100()
        {
            //Arrange
            Patient firstPatient = new Patient();

            //Act
          

            //Assert
            Assert.Equal(100, firstPatient.BloodLevel);
        }

        [Fact]
        public void Patient_HealthStatus_Is_Set_To_100()
        {
            //Arrange
            Patient firstPatient = new Patient();

            //Act


            //Assert
            Assert.Equal(100, firstPatient.HealthStatus);
        }

        [Fact]
        public void ViewPatientInfo_Displays_A_Name()
        {

            //Arrange
            Patient firstPatient = new Patient(1, "Disco");

            //Act
            firstPatient.ViewPatientInfo();

            //Assert
            Assert.Equal("Disco", firstPatient.PatientName);

        }

        [Fact]
        public void ViewPatientInfo_Displays_An_Id()
        {

            //Arrange
            Patient firstPatient = new Patient(1, "Disco");

            //Act
            firstPatient.ViewPatientInfo();

            //Assert
            Assert.Equal(1, firstPatient.PatientId);

        }

        [Fact]
        public void ViewPatientInfo_Displays_A_BloodLevel()
        {

            //Arrange
            Patient firstPatient = new Patient(1, "Disco");

            //Act
            firstPatient.ViewPatientInfo();

            //Assert
            Assert.Equal(100, firstPatient.BloodLevel);

        }

        [Fact]
        public void ViewPatientInfo_Displays_A_HealthStatus()
        {

            //Arrange
            Patient firstPatient = new Patient(1, "Disco");

            //Act
            firstPatient.ViewPatientInfo();

            //Assert
            Assert.Equal(100, firstPatient.HealthStatus);

        }

    }
}
