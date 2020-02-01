using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class JanitorTests
    {
        [Fact]
        public void Janitor_Can_I_Create_A_New_Class()
        {
            Janitor firstJanitor = new Janitor();
        }

        [Fact]
        public void JanitorId_Can_We_Assign_A_Number()
        {
            //Arrange
            Janitor firstJanitor = new Janitor();

            //Act
            firstJanitor.EmployeeId = 1;

            //Assert
            Assert.Equal(1, firstJanitor.EmployeeId);
        }

        [Fact]
        public void JanitorName_Can_We_Assign_A_Name()
        {
            //Arrange
            Janitor firstJanitor = new Janitor();

            //Act
            firstJanitor.EmployeeName = "McLovin";

            //Assert
            Assert.Equal("McLovin", firstJanitor.EmployeeName);
        }

        [Fact]
        public void HasBeenPaid_is_set_to_false()
        {
            //Arrange
            Janitor firstJanitor = new Janitor();

            //Act
            firstJanitor.HasBeenPaid = false;

            //Assert
            Assert.False(firstJanitor.HasBeenPaid);
        }

        [Fact]
        public void Salary_For_Janitor_Is_Set_To_40000()
        {
            //Arrange
            Janitor firstJanitor = new Janitor();

            //Act

            //Assert
            Assert.Equal(40000, firstJanitor.Salary);
        }

        [Fact]
        public void Constructor_Can_Assign_Id()
        {
            //Arrange
            Janitor firstJanitor = new Janitor(1, "McLovin");

            //Act


            //Assert
            Assert.Equal(1, firstJanitor.EmployeeId);
        }

        [Fact]
        public void Constructor_Can_Assign_Name()
        {
            //Arrange
            Janitor firstJanitor = new Janitor(1, "McLovin");

            //Act

            //Assert
            Assert.Equal("McLovin", firstJanitor.EmployeeName);
        }

        [Fact]
        public void PaySalary_Changes_To_True()
        {
            //Arrange
            Janitor firstJanitor = new Janitor(1, "McLovin");

            //Act
            firstJanitor.PaySalary();

            //Assert
            Assert.True(firstJanitor.HasBeenPaid);
        }

        [Fact]
        public void Is_Sweeping_Is_Set_To_False()
        {
            //Arrange
            Janitor myJanitor = new Janitor(1, "McLovin");

            //Act


            //Assert
            Assert.False(myJanitor.IsSweeping);

        }
    }
}
