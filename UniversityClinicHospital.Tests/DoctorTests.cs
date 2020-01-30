using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void Doctor_Can_I_Create_A_New_Class()
        {
            Doctor firstDoctor = new Doctor();
        }

        [Fact]
        public void DoctorId_Can_We_Assign_A_Number()
        {
            //Arrange
            Doctor firstDoctor = new Doctor();

            //Act
            firstDoctor.EmployeeId = 1;

            //Assert
            Assert.Equal(1, firstDoctor.EmployeeId);
        }

        [Fact]
        public void DoctorName_Can_We_Assign_A_Name()
        {
            //Arrange
            Doctor firstDoctor = new Doctor();

            //Act
            firstDoctor.EmployeeName = "Terrell";

            //Assert
            Assert.Equal("Terrell", firstDoctor.EmployeeName);
        }

        [Fact]
        public void HasBeenPaid_is_set_to_false()
        {
            //Arrange
            Doctor firstDoctor = new Doctor();

            //Act
            firstDoctor.HasBeenPaid = false;

            //Assert
            Assert.False(firstDoctor.HasBeenPaid);
        }

        [Fact]
        public void Salary_For_Doctor_Is_Set_To_90000()
        {
            //Arrange
            Doctor firstDoctor = new Doctor();

            //Act

            //Assert
            Assert.Equal(90000, firstDoctor.Salary);
        }

        [Fact]
        public void Constructor_Can_Assign_Id()
        {
            //Arrange
            Doctor firstDoctor = new Doctor(1, "Rob");

            //Act


            //Assert
            Assert.Equal(1, firstDoctor.EmployeeId);
        }

        [Fact]
        public void Constructor_Can_Assign_Name()
        {
            //Arrange
            Doctor firstDoctor = new Doctor(1, "Rob");

            //Act

            //Assert
            Assert.Equal("Rob", firstDoctor.EmployeeName);
        }

        [Fact]
        public void Constructor_Can_Assign_Specialty()
        {
            //Arrange
            Doctor firstDoctor = new Doctor(1, "Rob" , "Heart Surgeon");

            //Act

            //Assert
            Assert.Equal("Heart Surgeon", firstDoctor.SpecialtyArea);

        }

        [Fact]
        public void PaySalary_Changes_To_True()
        {
            //Arrange
            Doctor firstDoctor = new Doctor(1, "Rob");

            //Act
            firstDoctor.PaySalary();

            //Assert
            Assert.True(firstDoctor.HasBeenPaid);
        }

    }
}
