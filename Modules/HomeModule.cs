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
				return View["index.cshtml"];
			};
		}
	}
}
