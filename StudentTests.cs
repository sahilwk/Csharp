using System;
using Xunit;

namespace GradeBook.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
           var student=new Student("sahil");
            student.AddGrade(89.3);
            student.AddGrade(82.1);
            student.AddGrade(86.1);

            var result=student.getAverage();

            Assert.Equal(83.0,result,1);
        }
    }
}
