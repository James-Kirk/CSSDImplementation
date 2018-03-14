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
        public DigitalReader(String aReaderType, int aDigitalReaderID, string currentLocation)
        {
            if(aReaderType == "Waffle Iron")
            {
                throw new ArgumentException();
            }
            this.readerType = aReaderType;
            this.digitalReaderID = aDigitalReaderID;
            this.currentLocation = new Location(currentLocation);
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
                else if(aToken.getType() == TokenType.Ticket)
                {
                    Ticket t = (aToken as Ticket);

                    if(t.getStart() == currentLocation)
                    {
                        if (readerType == "Bus")
                            playAudio();            // TADA :D
                        else
                            gate.operateGate();     // opens the gate while user is standing on scanner, then closes
                        aToken.incrementJourney();  // adds to total journeys on this token
                        createJourney(aToken);  // creates a journey and links this token
                        return entryPermitted;
                    }
                }

                // if reader is on a bus & there is not enough credit (or there is no token), entry is denied
                // Changed from sequence diagram check is redundant if they dont have sufficient credit entry always denied.
                return entryDenied;
            }
        }

        // this should return the current balance to be displayed on the UI (accountBalance left / you don't have enough moolah)
        // catch in UI, invalid token exception - BW
        // -1 is insufficient credit, otherwise current balance - BW
        public float readTokenAtExit(int id, string line)
        {
			Token exitToken = SetOfTokens.Instance.findToken(id);
			if (exitToken == null)
                throw new ArgumentException("Smart Card unregistered Visit information Helpdesk");
            if (exitToken.getScannedStatus())
			{
				switch(exitToken.getType())
				{
					case TokenType.SmartCard:
                        
                        Journey currentJourney = SetOfJourneys.Instance.findTokensMostRecentJourney(id);
                        int todaysJourneys = exitToken.getNumOfJourneys();
                        int dayPass = FareRules.Instance.getNumForDayPass();
                        bool alreadyPaid = exitToken.hasDiscount();
                        float cTripFare = FareRules.Instance.calculateFare(line, currentJourney.getStartLocation(), currentLocation.getLocation());
                        //currentJourney.setAmountPaid(FareRules.Instance.calculateFare(line, currentJourney.getStartLocation(), currentLocation.getLocation())); // set journey cost at the start why would we do it after?
                        if (dayPass <= todaysJourneys && !alreadyPaid)
                        {
                            float dayPassCost = FareRules.Instance.calculateDiscount(todaysJourneys);
                            float amount = SetOfJourneys.Instance.getAmountForAllJourneys(id); //get totalAmountPaid
                            //although actually putting in checks makes this entirely redundant so good job group b
                            //why would you ever refund when you can just stop it going above the amount.
                            if (amount  > dayPassCost)
                            {
                                exitToken.getAccount().updateBalance(amount- dayPassCost); //refunds any cost over daypass
                                exitToken.setDiscounted(true);
                                currentJourney.setEndDate(DateTime.Now);
                                currentJourney.setToLocation(currentLocation.getLocation());
                                return exitToken.getAccount().getCreditAmount();
                            }
                            else if((amount + cTripFare) > dayPassCost)
                            {
                                currentJourney.setAmountPaid((dayPassCost - amount));
                                if (currentJourney.getAmountPaid() > exitToken.getAccount().getCreditAmount())
                                    return -1; //insufficient credit.
                                exitToken.getAccount().updateBalance(-currentJourney.getAmountPaid());
                                exitToken.setDiscounted(true);
                                currentJourney.setEndDate(DateTime.Now);
                                currentJourney.setToLocation(currentLocation.getLocation());
                                return exitToken.getAccount().getCreditAmount();
                            }
                        }
                        if (alreadyPaid)
                        {
                            currentJourney.setEndDate(DateTime.Now);
                            currentJourney.setToLocation(currentLocation.getLocation());
                            return exitToken.getAccount().getCreditAmount();
                        }
                        else
                        {
                            if (currentJourney.getAmountPaid() > exitToken.getAccount().getCreditAmount())
                                return -1; //insufficient credit.
                            else
                            {
                                exitToken.getAccount().updateBalance(-currentJourney.getAmountPaid());
                                currentJourney.setEndDate(DateTime.Now);
                                currentJourney.setToLocation(currentLocation.getLocation());
                                return exitToken.getAccount().getCreditAmount();
                            }
                        }
				}
			}
            throw new ArgumentException("SmartCard never scanned on entry visit information helpdesk");
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
            SetOfJourneys.Instance.addJourney(theJourney);
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
