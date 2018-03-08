using System;
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
        private GateController gate = new GateController();

        // TODO Current location should probably be in the constructor here too
        public DigitalReader(String aReaderType, int aDigitalReaderID)
        {
            if(aReaderType == "Waffle Iron")
            {
                throw new ArgumentException();
            }
            this.readerType = aReaderType;
            this.digitalReaderID = aDigitalReaderID;
            currentLocation = new Location("Backend sucks");
        }

        public bool readTokenAtEntry(int id)
        {
            Token aToken = SetOfTokens.Instance.findToken(id);
            if (aToken == null)
            {
                return entryDenied();
            }
            else
            {
                bool sufficientCredit = aToken.hasSufficientCredit();
                String tokenType = aToken.getType();    // TODO change to enum
                if (tokenType == "SmartCard")
                { 
                    SmartCard smartCard = (SmartCard)aToken;   // static casting to a smart card
                    Account cardAccount = smartCard.getAccount();
                    float minAmount = FareRules.Instance.getMinAmount();
                    float cardAccountBalance = cardAccount.getBalance();
                    // TODO - isn't all of this the same route as taken later on in here?
                    // ASK MARK If we can make it not shit
                    if (cardAccountBalance < minAmount) // if lower than the minimum amount on the smartcard, do not allow
                        return entryDenied();
                }

                String readerType = getReaderType();

                if (sufficientCredit)
                {
                    if (readerType == "Bus")
                    {
                        playAudio();
                    }
                    else
                    {
                        gate.operateGate();
                        
                    }
                    aToken.incrementJourney();
                    createJourney(aToken);
                    return entryPermitted();
                }

                // if reader is on a bus & there is not enough credit (or there is no token), entry is denied
                //Changed from sequence diagram check is redundant if they dont have sufficient credit entry always denied.
                return entryDenied();
            }
        }

        public void readTokenAtExit(int id)
        {

        }

        public String getReaderType()
        {
            return readerType;
        }
           
        // Ben says get rid
        public DateTime getTime()
        {
            return currentTime;
        }

        // Ben says get rid
        public DateTime getDay()
        {
            return currentTime;
        }

        public void playAudio()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();
        }

        public bool entryPermitted()
        {
            return true;

        }

        public void createJourney(Token aToken)
        {
            aToken.setScanned(true);
            String s = currentLocation.getLocation();
            DateTime t = getTime();
            Journey theJourney = new Journey(aToken, s, "", t, DateTime.MinValue, 0.00f);
        }

        public bool entryDenied()
        {
            return false;
        }
	}
}
