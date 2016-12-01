using Nancy;
using System.Collections.Generic;
using Weekday.Objects;

namespace Weekday
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				List<string> Model = new List<string> {};
				Model.Add("false");
				return View["index.cshtml", Model];
			};
			Post["/"] = _ =>
			{
				List<string> Model = new List<string> {};
				Model.Add("true");
				Model.Add(Day.GetDayOfWeek(Request.Form["Year"],Request.Form["Month"],Request.Form["Day"]));
				return View["index.cshtml", Model];
			};
		}
	}
}
