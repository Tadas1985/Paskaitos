using Structs2;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckIfTrueWhenPassingEvenNumber()
        {
            var numberService = new NumbersServisce();
            var isEven = numberService.IsEven(2);
            Assert.True(isEven);
        }
        [Fact]
        public void CheckIfTrueWhenPassingOddNumber()
        {
            var numberService = new NumbersServisce();
            var isOdd = numberService.IsEven(1);
            Assert.True(!isOdd);
        }
        [Fact]
        public void CheckIfSemesterAverageReturnsAverage() 
        {
            var student = new Student();
            var list = new List <int> { 1, 2, 3 };
            var newList = student.SemesterAverage(list);

            Assert.Equal(2, newList);
        }
        [Fact]
        public void CheckIfYearAverageReturnsAverage()
        {
            Student student = new Student();
            List<int> list1 = new List<int> { 1 };
            List<int> list2 = new List<int> { 2 };
            List<int> list3 = new List<int> { 3 };
            
            var result = student.YearAverage(list1, list2, list3);

            Assert.Equal(2, result);
            
        }
    }
}
