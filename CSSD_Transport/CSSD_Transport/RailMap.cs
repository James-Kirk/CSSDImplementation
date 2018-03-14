//Individual Work
//Alex

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
		
			List<Location> VictoriaLine = new List<Location>();
			VictoriaLine.Add(new Location("Euston"));
			VictoriaLine.Add(new Location("Warren Street"));
			VictoriaLine.Add(new Location("Oxford Circus"));
			VictoriaLine.Add(new Location("Green Park"));
			VictoriaLine.Add(new Location("Victoria"));
			VictoriaLine.Add(new Location("Pimlico"));
			VictoriaLine.Add(new Location("Vauxhall"));
			VictoriaLine.Add(new Location("Stockwell"));
			VictoriaLine.Add(new Location("Brixton"));

			railLines.Add(new Tuple<String, List<Location>>("Circle", CircleLine));
			railLines.Add(new Tuple<String, List<Location>>("Victoria", VictoriaLine));
		}

		public static RailMap Instance
		{
			get { return instance == null ? instance = new RailMap() : instance; }

			set { instance = value; }
		}

		///<summary>Add a location to a given line</summary>
		///<param name = "line" >The name of the line</param>
		///<param name = "location" >The location object to be added</param>
		public void addLocation(String line, Location location)
		{
			railLines.Find(i => i.Item1 == line).Item2.Add(location);
		}

		///<summary>Add a line to the main list</summary>
		///<param name = "name" >String: the name of the RailLine</param>
		///<param name = "line" >List of locations, containing the stations for the line </param>
		public void addLine(String name, List<Location> line)
		{
			railLines.Add(new Tuple<String, List<Location>>(name, line));
		}

		///<summary>Retreive the list of station locations for a given line</summary>
		///<returns>Returns a List of Locations</returns>
		///<param name = "name" >String for the name of rail line</param>
		public List<Location> getLine(String name)
		{
			return railLines.Find(i => i.Item1 == name).Item2;
		}

		///<summary>Retreive the list of line names</summary>
		///<returns>Returns a List of Strings</returns>
		public List<String> getLineNames()
		{
			List<String> names = new List<String>();
			foreach(var l in railLines)
				names.Add(l.Item1);
			return names;
		}

		///<summary>Retreive the list of station names for a given line</summary>
		///<returns>Returns a List of Strings</returns>
		///<param name = "lineName" >String for the name of rail line</param>
		public List<String> getStationNames(String lineName)
		{
			List<String> names = new List<String>();
			foreach (var s in getLine(lineName))
				names.Add(s.getLocation());
			return names;
		}

		///<summary>Gets the location object by name from the rail lines</summary>
		///<returns>Returns a Location object. Null if error.</returns>
		///<param name = "name" >String for the name of the station location</param>
		public Location getLocation(String name)
        {
            foreach(var L in railLines)
            {
                foreach(var S in L.Item2)
                {
                    if (S.getLocation() == name)
                        return S;
                }
            }
            return null;
        }

		///<summary>Computes the distance between two stations on a given line</summary>
		///<returns>Returns the absolute value of the distance. Returns -1 if there is an error.</returns>
		///<param name = "lineName" >String for the name of the Rail Line</param>
		///<param name = "Loc1" >Name of the starting station</param>
		///<param name = "Loc2" >Name of the destination station</param>
		public int getDistance(String lineName, String Loc1, String Loc2)
		{
			if (Loc1 == Loc2)
				return 0;
			List<Location> line = railLines.Find(i => i.Item1 == lineName).Item2;
			bool l1Found = false, l2Found = false;
			int loc1IDX = 0;
			int loc2IDX = 0;
			for (int i = 0; i < line.Count; i++)
			{
				if (line[i].getLocation() == Loc1)
				{
					loc1IDX = i;
					l1Found = true;
				}
				else if (line[i].getLocation() == Loc2)
				{
					loc2IDX = i;
					l2Found = true;
				}
			}

			if (l1Found == false || l2Found == false)
				return -1;

			return Math.Abs(loc2IDX - loc1IDX);
		}

	}
}
