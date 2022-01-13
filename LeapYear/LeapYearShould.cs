using System;
using Xunit;

// Acceptance Criteria:
//
// All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
// All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
// All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
// All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).

namespace LeapYear
{
    public class LeapYearShould
    {
        [Fact]
        public void ConsiderYearsDivisibleBy400()
        {
            LeapYearChecker leapYearChecker = new();

            var result = leapYearChecker.isLeapYear(2000);

            Assert.True(result);
        }
        
        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void NotConsiderYearsDivisibleBy100ButNotBy400(int year)
        {
            LeapYearChecker leapYearChecker = new();

            var result = leapYearChecker.isLeapYear(year);

            Assert.False(result);
        }
        
        [Theory]
        [InlineData(2008)]
        [InlineData(2012)]
        [InlineData(2016)]
        public void ConsiderYearsDivisibleBy4ButNotBy100(int year)
        {
            LeapYearChecker leapYearChecker = new();

            var result = leapYearChecker.isLeapYear(year);

            Assert.True(result);
        }
    }

    public class LeapYearChecker
    {
        public bool isLeapYear(int year)
        {
            
            if (IsYearDivisibleBy(year, 4) && !IsYearDivisibleBy(year, 100))
            {
                return true;
            }
            
            if (!IsYearDivisibleBy(year, 400))
            {
                return false;
            }

            return true;
        }

        private static bool IsYearDivisibleBy(int year, int divisor)
        {
            return (year % divisor) == 0;
        }
    }
}