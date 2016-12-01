using System.Collections.Generic;
using System;

namespace Weekday.Objects
{
	public class Day
	{
		private static DateTime _startDay = new DateTime(2015, 11, 22);
		private static string[] Days = new string[]
		{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
		private static string[] reverseDays = new string[]
		{"Sunday", "Saturday", "Friday", "Thursday", "Wednesday", "Tuesday", "Monday"};
		public static string GetDayOfWeek(int year, int month, int day)
		{
			try
			{
				DateTime targetDay = new DateTime(year, month, day);
				int daySpan = 0;
				int dateComparison = DateTime.Compare(_startDay, targetDay);
				if (dateComparison < 0)
				{
					daySpan = Math.Abs(Convert.ToInt32(Math.Floor((targetDay - _startDay).TotalDays)));
					return Days[daySpan % 7];
				}
				else if (dateComparison > 0)
				{
					daySpan = Math.Abs(Convert.ToInt32(Math.Floor((_startDay - targetDay).TotalDays)));
					return reverseDays[daySpan % 7];
				}
				else
				{
					return "Sunday";
				}
			}
			catch
			{
				return "not a valid day";
			}
		}
	}
}
