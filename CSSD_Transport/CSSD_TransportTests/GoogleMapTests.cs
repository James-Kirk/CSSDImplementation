using GMap.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Util.Tests
{
    [TestClass()]
    public class GoogleMapTests
    {
        [TestMethod()]
        public void getCurrentLocationTest()
        {
            // Setup
            GoogleMap map = new GoogleMap("Westminster", null);
            PointLatLng expected = new PointLatLng(51.501320, -0.124836);

            // Method
            PointLatLng actual = map.getCurrentLocation();

            // Assertion
            Assert.AreEqual(expected, actual);
        }

        public void getDestinationTest()
        {
            // Setup
            GoogleMap map = new GoogleMap("Westminster", null);
            map.updateDestination("Victoria");
            PointLatLng expected = new PointLatLng(51.495210, -0.143898);

            // Method
            PointLatLng actual = map.getDestinationLocation();

            // Assertion
            Assert.AreEqual(expected, actual);
        }

        public void changeDestinationTest()
        {
            // Setup
            GoogleMap map = new GoogleMap("Victoria", null);
            map.updateDestination("Farringdon");
            map.updateDestination("Kings Cross");
            PointLatLng expected = new PointLatLng(51.531640, -0.124423);

            // Method
            PointLatLng actual = map.getDestinationLocation();

            // Assertion
            Assert.AreEqual(expected, actual);
        }
    }
}
