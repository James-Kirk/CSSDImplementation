using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Util.Tests
{
	[TestClass()]
	public class RailMapTests
	{
		[TestMethod()]
		public void getDistanceTest()
		{
			int expected = 4;
			int actual = RailMap.Instance.getDistance("Circle", "Aldgate", "Westminster");
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void getDistanceTestFalseStation()
		{
			int expected = -1;
			int actual = RailMap.Instance.getDistance("Circle", "Glossop", "Westminster");
			Assert.AreEqual(expected, actual);
		}
	}
}