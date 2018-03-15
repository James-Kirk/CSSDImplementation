using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journeys
{
    [Serializable]
    public class Location
	{
		private string locationName;
		private double lat;
		private double lon;

		public Location(string locationName)
		{
			this.locationName = locationName;
		}

		public Location(string locationName, double latitude, double longitude)
		{
			this.locationName = locationName;
			lat = latitude;
			lon = longitude;
		}

		public string getLocation() => locationName;
		public double getLongitude() => lon;
		public double getLatitude() => lat;
	}
}
