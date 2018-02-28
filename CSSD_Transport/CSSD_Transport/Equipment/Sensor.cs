using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Equipment
{
	public class Sensor
	{
        private bool passengerOnSensor = false;

        public void scanArea()
        {
            passengerOnSensor = true;
        }

        public bool isPassengerOnSensor()
        {
            scanArea();
            bool temp = passengerOnSensor; // Cheeky little simulation for succesful sensor scan
            passengerOnSensor = false;
            return passengerOnSensor;
        }
	}
}
