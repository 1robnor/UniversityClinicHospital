using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Nurse_Can_I_Create_A_New_Class()
        {
            Nurse firstNurse = new Nurse();
        }

        [Fact]
        public void NurseId_Can_We_Assign_A_Number()
        {
            //Arrange
            Nurse firstNurse = new Nurse();

            //Act
            firstNurse.EmployeeId = 1;

            //Assert
            Assert.Equal(1, firstNurse.EmployeeId);
        }

        [Fact]
        public void NurseName_Can_We_Assign_A_Name()
        {
            //Arrange
            Nurse firstNurse = new Nurse();

            //Act
            firstNurse.EmployeeName = "Carol";

            //Assert
            Assert.Equal("Carol", firstNurse.EmployeeName);
        }

        [Fact]
        public void HasBeenPaid_is_set_to_false()
        {
            //Arrange
            Nurse firstNurse = new Nurse();

            //Act
            firstNurse.HasBeenPaid = false;

            //Assert
            Assert.False(firstNurse.HasBeenPaid);
        }

        [Fact]
        public void Salary_For_Nurse_Is_Set_To_50000()
        {
            //Arrange
            Nurse firstNurse = new Nurse();

            //Act

            //Assert
            Assert.Equal(50000, firstNurse.Salary);
        }

        [Fact]
        public void Constructor_Can_Assign_Id()
        {
            //Arrange
            Nurse firstNurse = new Nurse(1, "FeelGood", 1);

            //Act


            //Assert
            Assert.Equal(1, firstNurse.EmployeeId);
        }

        [Fact]
        public void Constructor_Can_Assign_Patients()
        {
            //Arrange
            Nurse firstNurse = new Nurse(1, "FeelGood", 1);

            //Act


            //Assert
            Assert.Equal(1, firstNurse.NumberOfPatients);
        }

        [Fact]
        public void Constructor_Can_Assign_Name()
        {
            //Arrange
            Nurse firstNurse = new Nurse(1, "FeelGood", 1);

            //Act

            //Assert
            Assert.Equal("FeelGood", firstNurse.EmployeeName);
        }

        [Fact]
        public void PaySalary_Changes_To_True()
        {
            //Arrange
            Nurse firstNurse = new Nurse(1, "FeelGood", 1);

            //Act
            firstNurse.PaySalary();

            //Assert
            Assert.True(firstNurse.HasBeenPaid);
        }

        [Fact]
        public void CareForPatient_Does_Health_Level_Increase_by_5()
        {
            //Arrange
            Nurse firstNurse = new Nurse(1, "Rob",1);
            Patient myPatient = new Patient(1, "Sam");

            //Act
            var currentHealth = myPatient.HealthStatus;
            firstNurse.CareForPatient(myPatient);

            //Assert
            Assert.Equal(currentHealth +5, myPatient.HealthStatus);
        }


    }
}
