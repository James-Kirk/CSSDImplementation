using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;

namespace CSSD_Transport.Equipment
{
	public class DigitalReader
	{
        private int digitalReaderID;
        private String readerType;
        private DateTime currentTime;
        private Location currentLocation;
        private SetOfTokens tokenList;
        private GateController gate = new GateController();

        public void readTokenAtEntry(int id)
        {
            Token aT = tokenList.findToken(id);
            bool e = aT.hasSufficientCredit();
            String s = aT.getType();
            if (s == "SmartCard")
            {
                // do some stuff
            }

            if (aT != null && e)
            {
                String r = getReaderType();
                if (r == "Bus")
                {
                    entryPermitted();
                    playAudio();
                }
                else
                {
                    gate.operateGate();
                    aT.incrementJourney();
                    createJourney(aT);
                }
            }
        }

        public void readTokenAtExit(int id)
        {

        }

        public String getReaderType()
        {
            return readerType;
        }

        public DateTime getTime()
        {
            return currentTime;
        }

        public DateTime getDay()
        {
            return currentTime;
        }

        public void playAudio()
        {
            
        }

        public void entryPermitted()
        {

        }

        public void createJourney(Token aToken)
        {
            aToken.setScanned(true);
            String s = currentLocation.getLocation();
            DateTime t = getTime();
            Journey theJourney = new Journey(aToken, s, "", t, null, 0.00f);
        }

        public void entryDenied()
        {

        }
	}
}
