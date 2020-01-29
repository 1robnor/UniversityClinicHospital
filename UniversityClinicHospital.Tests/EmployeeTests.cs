using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void Employee_Can_I_Create_A_New_Class()
        {
            Employee firstEmployee = new Employee();
        }

        [Fact]
        public void EmployeeId_Can_We_Assign_A_Number()
        {
            //Arrange
            Employee firstEmployee = new Employee();

            //Act
            firstEmployee.EmployeeId = 1;

            //Assert
            Assert.Equal(1, firstEmployee.EmployeeId);
        }

        [Fact]
        public void EmployeeName_Can_We_Assign_A_Name()
        {
            //Arrange
            Employee firstEmployee = new Employee();

            //Act
            firstEmployee.EmployeeName = "Terrell";

            //Assert
            Assert.Equal("Terrell", firstEmployee.EmployeeName);
        }

        [Fact]
        public void HasBeenPaid_is_set_to_false()
        {
            //Arrange
            Employee firstEmployee = new Employee();

            //Act
            firstEmployee.HasBeenPaid = false;

            //Assert
            Assert.False(firstEmployee.HasBeenPaid);
        }

        [Fact]
        public void Salary_Can_Assign_A_Number()
        {
            //Arrange
            Employee firstEmployee = new Employee();

            //Act
            firstEmployee.Salary = 30000;

            //Assert
            Assert.Equal(30000, firstEmployee.Salary);
        }

        [Fact]
        public void Constructor_Can_Assign_Id()
        {
            //Arrange
            Employee firstEmployee = new Employee(1, "Rob");

            //Act
           

            //Assert
            Assert.Equal(1, firstEmployee.EmployeeId);
        }

        [Fact]
        public void Constructor_Can_Assign_Name()
        {
            //Arrange
            Employee firstEmployee = new Employee(1, "Rob");

            //Act


            //Assert
            Assert.Equal("Rob", firstEmployee.EmployeeName);
        }

        [Fact]
        public void PaySalary_Changes_To_True()
        {
            //Arrange
            Employee firstEmployee = new Employee(1, "Rob");

            //Act
            firstEmployee.PaySalary();

            //Assert
            Assert.True(firstEmployee.HasBeenPaid);
        }
    }
}
