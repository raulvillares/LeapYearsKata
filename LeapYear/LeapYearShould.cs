using System;
using Xunit;


namespace LeapYear
{
    public class LeapYearShould
    {
        [Fact]
        public void ConsiderYearsDivisibleBy400()
        {
            Year year = new Year(2000);

            var result = year.IsLeapYear();

            Assert.True(result);
        }
        
        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void NotConsiderYearsDivisibleBy100ButNotBy400(int yearDivisibleBy100ButNotBy400)
        {
            Year year = new Year(yearDivisibleBy100ButNotBy400);

            var result = year.IsLeapYear();

            Assert.False(result);
        }
        
        [Theory]
        [InlineData(2008)]
        [InlineData(2012)]
        [InlineData(2016)]
        public void ConsiderYearsDivisibleBy4ButNotBy100(int yearDivisibleBy4ButNotBy100)
        {
            Year year = new Year(yearDivisibleBy4ButNotBy100);

            var result = year.IsLeapYear();

            Assert.True(result);
        }
        
        [Theory]
        [InlineData(2017)]
        [InlineData(2018)]
        [InlineData(2019)]
        public void NotConsiderYearsDivisibleBy4(int yearDivisibleBy4)
        {
            Year year = new Year(yearDivisibleBy4);

            var result = year.IsLeapYear();

            Assert.False(result);
        }
    }

    public class Year
    {
        int year;

        public Year(int year)
        {
            this.year = year;
        }

        public bool IsLeapYear()
        {
            
            if (IsYearDivisibleBy(year, 4) && !IsYearDivisibleBy(year, 100))
            {
                return true;
            }
            
            if (IsYearDivisibleBy(year, 400))
            {
                return true;
            }

            return false;
        }

        private static bool IsYearDivisibleBy(int year, int divisor)
        {
            return (year % divisor) == 0;
        }
    }
}