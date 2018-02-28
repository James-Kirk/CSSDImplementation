using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Equipment
{
	public class GateController
	{
        Sensor theSensor = new Sensor();

        public void closeGate()
        {

        }

        public void operateGate()
        {
            bool c = theSensor.isPassengerOnSensor();
            while (c == true)
            {
                liftGate();
                c = false; // IRL this would loop around until the sensor no longer picked up a person
            }

            closeGate();
        }

        public void contactStaff()
        {

        }

        public void liftGate()
        {

        }
	}
}
