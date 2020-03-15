using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(89.3);

            //act
            var result = book.GetStatistics();

            //assert 
            Assert.Equal(89.63333333333333,result.Average,1);
            Assert.Equal(90.5,result.High,1);
            Assert.Equal(77.3,result.Low,1);


        }
    }
}
