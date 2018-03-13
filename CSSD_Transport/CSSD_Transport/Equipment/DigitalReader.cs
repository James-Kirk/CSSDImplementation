using System;
using System.Media;

using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
using CSSD_Transport.Accounts;

namespace CSSD_Transport.Equipment
{
    public class DigitalReader
	{
		private const bool entryDenied = false;
		private const bool entryPermitted = true;

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
            currentLocation = new Location("Baker Street");
        }

        // Scanner into the transport - train station barrier/conductor's reader
        public bool readTokenAtEntry(int id)
        {
            Token aToken = SetOfTokens.Instance.findToken(id);  // find a token based off of the scanned ID
            if (aToken == null) // if not found, they can't enter the system
            {
                return entryDenied;
            }
            else
            {
                String readerType = getReaderType();

                if (aToken.hasSufficientCredit())   // checks account has minimum credit to enter system  
                {
                    if (readerType == "Bus")
                    {
                        playAudio();    // TADA :D
                    }
                    else
                    {
                        gate.operateGate();     // opens the gate while user is standing on scanner, then closes
                        
                    }
                    aToken.incrementJourney();  // adds to total journeys on this token
                    createJourney(aToken);  // creates a journey and links this token
                    return entryPermitted;  // returns true to the UI for whatever handling required
                }

                // if reader is on a bus & there is not enough credit (or there is no token), entry is denied
                // Changed from sequence diagram check is redundant if they dont have sufficient credit entry always denied.
                return entryDenied;
            }
        }

        // this should return the current balance to be displayed on the UI (accountBalance left / you don't have enough moolah)
        // catch in UI, invalid token exception - BW
        // -1 is insufficient credit, otherwise current balance - BW
        public float readTokenAtExit(int id)
        {
			Token exitToken = SetOfTokens.Instance.findToken(id);
			if (exitToken == null)
                throw new ArgumentException("Parameter cannot be null", "original");
            if (exitToken.getScannedStatus())
			{
				switch(exitToken.getType())
				{
					case TokenType.SmartCard:
                        Journey a;
                        //get recent journey (not implemented)
                        //if(FareRules.Instance.getNumForDayPass() < exitToken.getNumOfJourneys())
                        int todaysJourneys = exitToken.getNumOfJourneys();
                        int dayPass = FareRules.Instance.getNumForDayPass();
                        bool alreadyPaid = exitToken.hasDiscount();
                        a.setAmountPaid(0.0f); // set journey cost at the start why would we do it after?
                        if (dayPass <= todaysJourneys && !alreadyPaid)
                        {
                            float dayPassCost = FareRules.Instance.calculateDiscount(todaysJourneys);
                            float amount = 20.0f; //get totalAmountPaid
                            //although actually putting in checks makes this entirely redundant so good job group b
                            //why would you ever refund when you can just stop it going above the amount.
                            if (amount > dayPassCost)
                            {
                                exitToken.getAccount().updateBalance(amount - dayPassCost); //refunds any cost over daypass
                                exitToken.setDiscounted(true);
                                //update journey
                                return exitToken.getAccount().getCreditAmount();
                            }
                            else if((amount + a.getAmountPaid()) > dayPassCost)
                            {
                                a.setAmountPaid((amount + a.getAmountPaid() - dayPassCost));
                                if (a.getAmountPaid() > exitToken.getAccount().getCreditAmount())
                                    return -1; //insufficient credit.
                                exitToken.getAccount().updateBalance(-a.getAmountPaid());
                                exitToken.setDiscounted(true);
                                //update journey 
                                //reutrn balance left
                            }
                        }
                        else
                        {
                            if (a.getAmountPaid() > exitToken.getAccount().getCreditAmount())
                                return -1; //insufficient credit.
                            else
                            {
                                exitToken.getAccount().updateBalance(-a.getAmountPaid());
                                //update journey 
                                return exitToken.getAccount().getCreditAmount();
                            }
                        }
						break;
				}
			}
			return false;
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

        public void createJourney(Token aToken)
        {
            aToken.setScanned(true);
            String s = currentLocation.getLocation();
            DateTime t = getTime();
            Journey theJourney = new Journey(aToken, s, "", t, DateTime.MinValue, 0.00f);
        }

        // this is entirely to simulate location updating for testing
        public void setLocation(Location aLocation)
        {
            this.currentLocation = aLocation;
        }

        // this is entirely to simulate current time updating for testing
        public void setCurrentTime(DateTime aDateTime)
        {
            this.currentTime = aDateTime;
        }
	}
}
