using Employee.BL;
using System;
using Xunit;

namespace XUnitTestProjectEmployee
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Registration empReg = new Registration();
            bool status = empReg.SaveEmployee("Jio1", "Dev1", 40);
            Assert.Equal("TRUE", status.ToString().ToUpper());
        }
    }
}
