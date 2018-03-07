using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
using CSSD_Transport.Accounts;

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
            Token aToken = tokenList.findToken(id);
            bool sufficientCredit = aToken.hasSufficientCredit();
            String tokenType = aToken.getType();    // TODO change to enum
            if (tokenType == "SmartCard")
            {
                SmartCard smartCard = (SmartCard)aToken;   // static casting to a smart card
                Account cardAccount = smartCard.getAccount();
                float minAmount = FareRules.Instance.getMinAmount();
                float cardAccountBalance = cardAccount.getBalance();
                // TODO - isn't all of this the same route as taken later on in here?
                if (cardAccountBalance < minAmount) // if lower than the minimum amount on the smartcard, do not allow
                    entryDenied();  
                    return;
            }

            String readerType = getReaderType();

            if (aToken != null && sufficientCredit)
            {
                if (readerType == "Bus")
                {
                    entryPermitted();
                    playAudio();
                }
                else
                {
                    gate.operateGate();
                }


                aToken.incrementJourney();
                createJourney(aToken);
            }

            // if reader is on a bus & there is not enough credit (or there is no token), entry is denied
            if ((aToken == null || !sufficientCredit) && readerType == "Bus")
            {
                entryDenied();
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
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();
        }

        public void entryPermitted()
        {
            // TODO JK Output to a form that entry is permitted?
        }

        public void createJourney(Token aToken)
        {
            aToken.setScanned(true);
            String s = currentLocation.getLocation();
            DateTime t = getTime();
            Journey theJourney = new Journey(aToken, s, "", t, DateTime.MinValue, 0.00f);
        }

        public void entryDenied()
        {
            // TODO JK Output to a form that entry has been denied?
        }
	}
}
