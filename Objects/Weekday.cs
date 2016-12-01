using System.Collections.Generic;
using System;

namespace Weekday.Objects
{
	public class Day
	{
		private static DateTime _startDay = new DateTime(2015, 11, 22);
		private static Dictionary<int, string> _forwardDays = new Dictionary<int, string>()
		{
			[0]="Sunday",[1]="Monday",[2]="Tuesday",[3]="Wednesday",[4]="Thursday",[5]="Friday",[6]="Saturday"
		};
		private static Dictionary<int, string> _backwardDays = new Dictionary<int, string>()
		{
			[0]="Sunday",[1]="Saturday",[2]="Friday",[3]="Thursday",[4]="Wednesday",[5]="Tuesday",[6]="Monday"
		};
		public static string GetDayOfWeek(int year, int month, int day)
		{
			DateTime targetDay = new DateTime(year, month, day);
			int daySpan = 0;
			int dateComparison = DateTime.Compare(_startDay, targetDay);
			if (dateComparison < 0)
			{
				daySpan = Math.Abs(Convert.ToInt32(Math.Floor((targetDay - _startDay).TotalDays)));
				return _forwardDays[daySpan % 7];
			}
			else if (dateComparison > 0)
			{
				daySpan = Math.Abs(Convert.ToInt32(Math.Floor((_startDay - targetDay).TotalDays)));
				return _backwardDays[daySpan % 7];
			}
			else
			{
				return "Sunday";
			}
		}
	}
}
