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
		private double lat;
		private double lon;

		public Location(string locationName)
		{
			this.locationName = locationName;
		}

		public Location(string locationName, double lattitude, double longitude)
		{
			this.locationName = locationName;
			lat = lattitude;
			lon = longitude;
		}

		public string getLocation() => locationName;
		public double getLongitude() => lon;
		public double getLatitude() => lat;
	}
}
