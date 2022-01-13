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
        
        [Fact]
        public void NotConsiderYearsDivisibleBy100ButNotBy400()
        {
            LeapYearChecker leapYearChecker = new();

            var result = leapYearChecker.isLeapYear(1700);

            Assert.False(result);
        }
    }

    public class LeapYearChecker
    {
        public bool isLeapYear(int year)
        {
            return true;
        }
    }
}