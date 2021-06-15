using System;
using Xunit;

namespace TestSalaryPackage
{
    public class UnitTest1
    {
        [Fact]
        public void partTimeCorporate()
        {
            //Arrange
            var cp = new webSalaryPackage.Coporate();
            cp.company = "Coporate";
            cp.emp_name = "Saeed";
            cp.emp_salary = "60000";
            cp.work_type = "part-time";
            cp.hours = "25";
            double expected = 394.74;
            // Act 
            double actual = cp.calsalarypackage(cp.company, cp.work_type, cp.emp_salary, cp.hours);
            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void partTimePBI()
        {
            //Arrange
            var pbi = new webSalaryPackage.PBI();
            pbi.company = "Coporate";
            pbi.emp_name = "Saeed";
            pbi.emp_salary = "60000";
            pbi.work_type = "part-time";
            pbi.education_type = "postgraduate";
            double expected = 18224;
            // Act 
            double actual = pbi.calsalarypackage(pbi.company, pbi.work_type, pbi.emp_salary, pbi.education_type);
            //Assert 
            Assert.Equal(expected, actual);
        }

    }
}
