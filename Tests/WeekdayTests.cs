using Xunit;
using System;

namespace Weekday.Objects
{
  public class DayTests
  {
    [Fact]
    public void GetDayOfWeek_ForStartingDay_Sunday()
    {
      Assert.Equal("Sunday", Day.GetDayOfWeek(2016, 11, 27));
    }
    // [Fact]
    // public void GetDayOfWeek_ForCurrentYear_Sunday()
    // {
    //   Assert.Equal("Sunday", Day.GetDayOfWeek(2016, 12, 25));
    // }
    // [Fact]
    // public void GetDayOfWeek_ForFutureDay_Saturday()
    // {
    //   Assert.Equal("Saturday", Day.GetDayOfWeek(2020, 10, 31));
    // }
    // [Fact]
    // public void GetDayOfWeek_ForPastDay_Thursday()
    // {
    //   Assert.Equal("Thursday", Day.GetDayOfWeek(1776, 7, 4));
    // }
  }
}
