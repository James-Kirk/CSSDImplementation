//Individual Work
//Alex

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Journeys;

namespace CSSD_Transport.Util
{
	[Serializable]
	public class RailMap
	{
		private List<Location> locations = new List<Location>();
		private static RailMap instance;

		private RailMap()
		{
			//Examples
			//MUST intialise all locations here.
			locations.Add(new Location("Baker Street"));
			locations.Add(new Location("Green Park"));
		}

		public static RailMap Instance
		{
			get { return instance == null ? instance = new RailMap() : instance; }

			set { instance = value; }
		}

		public void addLocation(Location l)
		{
			locations.Add(l);
		}

		public int getDistance(ref string Loc1, ref string Loc2)
		{
			int loc1IDX = 0;
			int loc2IDX = 0;
			for (int i = 0; i < locations.Count; i++)
			{
				if (locations[i].getLocation() == Loc1)
					loc1IDX = i;
				else if (locations[i].getLocation() == Loc2)
					loc2IDX = i;
			}

			return Math.Abs(loc2IDX - loc1IDX);
		}

	}
}
