using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          Student student1=new Student();
          Student student2=new Student();
          Student student3=new Student();
          student1.setRating(75);
          student2.setRating(35);
          student3.setRating(100);
          string student1Message=student1.studentRating(student1.getRating());
          string student2Message = student2.studentRating(student2.getRating());
          string student3Message = student3.studentRating(student3.getRating());
          Assert.AreEqual("You can study better",student1Message);
          Assert.AreEqual("you should pay more attention to learning",student2Message);
          Assert.AreEqual("Congratulations to the excellent student",student3Message);
        }
    }
}
