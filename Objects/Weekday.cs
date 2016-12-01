using System.Collections.Generic;
using System;

namespace Weekday.Objects
{
	public class Day
	{
		private static DateTime _startDay = new DateTime(2016, 11, 27);
		private static Dictionary<int, string> Days = new Dictionary<int, string>()
		{
			[0]="Sunday",[1]="Monday",[2]="Tuesday",[3]="Wednesday",[4]="Thursday",[5]="Friday",[6]="Saturday"
		};
		public static string GetDayOfWeek(int year, int month, int day)
		{
			DateTime targetDay = new DateTime(year, month, day);
			int daySpan = Math.Abs(Convert.ToInt32(Math.Floor(targetDay.Subtract(_startDay).TotalDays)));
			return Days[daySpan % 7];
		}
	}
}
