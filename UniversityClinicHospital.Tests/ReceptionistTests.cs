using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class ReceptionistTests
    {

        [Fact]
        public void Receptionist_Can_I_Create_A_New_Class()
        {
            Receptionist firstReceptionist = new Receptionist();
        }

        [Fact]
        public void ReceptionistId_Can_We_Assign_A_Number()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist();

            //Act
            firstReceptionist.EmployeeId = 1;

            //Assert
            Assert.Equal(1, firstReceptionist.EmployeeId);
        }

        [Fact]
        public void ReceptionistName_Can_We_Assign_A_Name()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist();

            //Act
            firstReceptionist.EmployeeName = "McLovin";

            //Assert
            Assert.Equal("McLovin", firstReceptionist.EmployeeName);
        }

        [Fact]
        public void HasBeenPaid_is_set_to_false()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist();

            //Act
            firstReceptionist.HasBeenPaid = false;

            //Assert
            Assert.False(firstReceptionist.HasBeenPaid);
        }

        [Fact]
        public void Salary_For_Receptionist_Is_Set_To_45000()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist();

            //Act

            //Assert
            Assert.Equal(45000, firstReceptionist.Salary);
        }

        [Fact]
        public void Constructor_Can_Assign_Id()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist(1, "Rachael");

            //Act


            //Assert
            Assert.Equal(1, firstReceptionist.EmployeeId);
        }

        [Fact]
        public void Constructor_Can_Assign_Name()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist(1, "Rachael");

            //Act

            //Assert
            Assert.Equal("Rachael", firstReceptionist.EmployeeName);
        }

        [Fact]
        public void PaySalary_Changes_To_True()
        {
            //Arrange
            Receptionist firstReceptionist = new Receptionist(1, "Rachael");

            //Act
            firstReceptionist.PaySalary();

            //Assert
            Assert.True(firstReceptionist.HasBeenPaid);
        }

        [Fact]
        public void Is_On_The_Phone_Set_To_False()
        {
            //Arrange
            Receptionist myReceptionist = new Receptionist(1, "Rachael");

            //Act


            //Assert
            Assert.False(myReceptionist.IsOnThePhone);
        }
    }
}

