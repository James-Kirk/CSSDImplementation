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
		private List<Tuple<String, List<Location>>> railLines = new List<Tuple<String, List<Location>>>();

		private static RailMap instance;

		private RailMap()
		{
			//Creating and adding a line to the map
			List<Location> CircleLine = new List<Location>();
			CircleLine.Add(new Location("Edgware Road"));
			CircleLine.Add(new Location("Baker Street"));
			CircleLine.Add(new Location("Great Portland Street"));
			CircleLine.Add(new Location("Euston Square"));
			CircleLine.Add(new Location("Kings Cross"));
			CircleLine.Add(new Location("Farringdon"));
			CircleLine.Add(new Location("Moorgate"));
			CircleLine.Add(new Location("Liverpool Street"));
			CircleLine.Add(new Location("Aldgate"));
			CircleLine.Add(new Location("Tower Hill"));
			CircleLine.Add(new Location("Monument"));
			CircleLine.Add(new Location("Embankment"));
			CircleLine.Add(new Location("Westminster"));
			CircleLine.Add(new Location("Victoria"));

			railLines.Add(new Tuple<String, List<Location>>("Circle", CircleLine));
		}

		public static RailMap Instance
		{
			get { return instance == null ? instance = new RailMap() : instance; }

			set { instance = value; }
		}

		public void addLocation(String line, Location location)
		{
			railLines.Find(i => i.Item1 == line).Item2.Add(location);
		}

		public void addLine(String name, List<Location> line)
		{
			railLines.Add(new Tuple<String, List<Location>>("name", line));
		}

		public List<String> getLineNames()
		{
			List<String> names = new List<String>();
			foreach(var l in railLines)
			{
				names.Add(l.Item1);
			}
			return names;
		}

		public int getDistance(String lineName, ref String Loc1, ref String Loc2)
		{
			List<Location> line = railLines.Find(i => i.Item1 == lineName).Item2;
			int loc1IDX = 0;
			int loc2IDX = 0;
			for (int i = 0; i < line.Count; i++)
			{
				if (line[i].getLocation() == Loc1)
					loc1IDX = i;
				else if (line[i].getLocation() == Loc2)
					loc2IDX = i;
			}

			return Math.Abs(loc2IDX - loc1IDX);
		}

	}
}
