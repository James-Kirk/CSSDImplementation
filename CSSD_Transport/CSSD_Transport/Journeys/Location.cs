using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journeys
{
	public class Location
	{
		private string locationName = "";

		public Location(string locationName)
		{
			this.locationName = locationName;
		}

		public string getLocation() => locationName;
	}
}
