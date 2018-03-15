using System;
using System.Media;

using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
using CSSD_Transport.Accounts;

namespace CSSD_Transport.Equipment
{
    public class DigitalReader
	{
		private static int digitalReaderCount = 0;

		private const bool entryDenied = false;
		private const bool entryPermitted = true;

        private int digitalReaderID;
        private String readerType;
        private DateTime currentTime;
        private Location currentLocation;
        private GateController gate = new GateController();
        
        public DigitalReader(String aReaderType, string currentLocation)
        {
            if(aReaderType != "Bus" && aReaderType != "Train" || aReaderType == null)
            {
                throw new ArgumentException();
            }
            this.readerType = aReaderType;
			this.digitalReaderID = digitalReaderCount++;
            this.currentLocation = new Location(currentLocation);
        }

        /// <summary>Scanner into the transport - train station barrier/conductor's reader</summary> 
        /// <returns>EntryPermitted or EntryDenied</returns>
		/// <param name="id">The id of the token</param>
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
                if (aToken.getType() == TokenType.Ticket)
                {
                    Ticket t = (aToken as Ticket);

                    if (t.getStart().getLocation() == currentLocation.getLocation())
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
                else if (aToken.hasSufficientCredit())   // checks account has minimum credit to enter system  
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

        /// <summary>Scanner out of the transport - train station barrier/conductor's reader</summary> 
        /// <returns>Balance left on account, -1 means it has been denied, 0 is primarily for pre-paid tickets</returns>
        /// <param name="id">The id of the token</param>
        /// <param name="line">The name of the line on (circle/victoria)</param>
        public float readTokenAtExit(int id, string line)
        {
			Token exitToken = SetOfTokens.Instance.findToken(id);
			if (exitToken == null)
                throw new ArgumentException("Travel Token not valid!");
            //make sure token has been scanned on the way in
            if (exitToken.getScannedStatus())
			{
				switch(exitToken.getType())
				{
					case TokenType.SmartCard:
                        
                        Journey currentJourney = SetOfJourneys.Instance.findTokensMostRecentJourney(id);
                        int todaysJourneys = exitToken.getNumOfJourneys();
                        int dayPass = FareRules.Instance.getNumForDayPass();
                        bool alreadyPaid = exitToken.hasDiscount();
                        //check if theyve gone in and come out of the same location within 15mins and not to charge them
                        if (currentJourney.getStartLocation() == currentLocation.getLocation() && (currentTime.Subtract(currentJourney.getStartDate()).TotalMinutes< 15))
                        {
                            currentJourney.setEndDate(DateTime.Now);
                            currentJourney.setToLocation(currentLocation.getLocation());
                            exitToken.setScanned(false);
                            return exitToken.getAccount().getCreditAmount();
                        }
                        float cTripFare = FareRules.Instance.calculateFare(line, currentJourney.getStartLocation(), currentLocation.getLocation());
                        if (dayPass <= todaysJourneys && !alreadyPaid)
                        {
                            float dayPassCost = FareRules.Instance.calculateDiscount(todaysJourneys); //returns cost of day pass
                            //Day pass cost was put in to stop the system charging you for a day pass if you took lots of cheap
                            //trips that cost less than a day pass
                            float amount = SetOfJourneys.Instance.getAmountForAllJourneys(id); //get totalAmountPaid
                            //Refund you if youre ever charged more than a day pass. Should never happen due to the following checks
                            if (amount  > dayPassCost)
                            {
                                exitToken.getAccount().updateBalance(amount- dayPassCost); //refunds any cost over daypass
                                exitToken.setDiscounted(true); //applys day pass to account
                                currentJourney.setEndDate(DateTime.Now);
                                currentJourney.setToLocation(currentLocation.getLocation());
                                exitToken.setScanned(false); //sets token to have exited the system
                                //if this isnt done smart cards wouldnt be allowed to re-enter
                                return exitToken.getAccount().getCreditAmount();
                            }
                            else if((amount + cTripFare) > dayPassCost) //check wheather the amount of your current trip qualifys you for a day pass
                            {
                                //If you qualify it subtracts the amount youve currently paid from the day pass
                                //you are then only charge what is left of the day pass amount
                                currentJourney.setAmountPaid((dayPassCost - amount));
                                //checks if they can afford the remaining cost for day pass.
                                //If they cant afford this they couldnt afford the trip which would have been more expensive
                                if (currentJourney.getAmountPaid() > exitToken.getAccount().getCreditAmount())
                                    return -1; //insufficient credit.
                                exitToken.getAccount().updateBalance(-currentJourney.getAmountPaid());
                                //apply daypass
                                exitToken.setDiscounted(true);
                                currentJourney.setEndDate(DateTime.Now);
                                currentJourney.setToLocation(currentLocation.getLocation());
                                exitToken.setScanned(false);
                                //return remaining balance
                                return exitToken.getAccount().getCreditAmount();
                            }
                        }
                        //check if theyve qualified for day pass
                        if (alreadyPaid)
                        {
                            currentJourney.setEndDate(DateTime.Now);
                            currentJourney.setToLocation(currentLocation.getLocation());
                            //if day pass is active the cost of the trip is 0
                            currentJourney.setAmountPaid(0.0f);
                            exitToken.setScanned(false);
                            return exitToken.getAccount().getCreditAmount();
                        }
                        else
                        {
                            currentJourney.setAmountPaid(cTripFare);
                            if (currentJourney.getAmountPaid() > exitToken.getAccount().getCreditAmount())
                                return -1; //insufficient credit.
                            else
                            {
                                //Normal trip when you dont qualify for day pass
                                exitToken.getAccount().updateBalance(-currentJourney.getAmountPaid());
                                currentJourney.setEndDate(DateTime.Now);
                                currentJourney.setToLocation(currentLocation.getLocation());
                                exitToken.setScanned(false);
                                return exitToken.getAccount().getCreditAmount();
                            }
                        }
                    case TokenType.Ticket:  // if it's a ticket, just check the end location matches the current location
                        Ticket t = (exitToken as Ticket);
                        if (t.getEnd().getLocation() == currentLocation.getLocation())
                        {
                            return 0;   // entry allowed
                        }
                        else
                        {
                            return -1; // entry not allowed
                        }

				}
			}
            throw new ArgumentException("SmartCard never scanned on entry visit information helpdesk");
        }

        /// <summary>
        /// Getter for the type of digital reader
        /// </summary>
        /// <returns>
        /// String of type of reader, such as Train
        /// </returns>
        public String getReaderType()
        {
            return readerType;
        }

        /// <summary>
        /// Getter for current time according to reader
        /// </summary>   
        /// <returns>
        /// DateTime object of current time
        /// </returns>
        public DateTime getTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Getter for current date according to reader
        /// </summary>   
        /// <returns>
        /// DateTime object of current day
        /// </returns>
        public DateTime getDay()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Plays the windows tada! noise (cute as heck)
        /// </summary>   
        public void playAudio()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();
        }
        
        /// <summary>
        /// Creates a journey on entry and puts it into the SetOfJourneys (no destination as of yet)
        /// </summary>
        /// <param name="aToken">
        /// Token used for the journey
        /// </param>
        public void createJourney(Token aToken)
        {
            aToken.setScanned(true);
            String s = currentLocation.getLocation();
            DateTime t = getTime();
            Journey theJourney = new Journey(aToken, s, "", t, DateTime.MinValue, 0.00f);
            SetOfJourneys.Instance.addJourney(theJourney);
        }

        /// <summary>
        /// Used to update location of digital reader (for example if it's on a bus)
        /// </summary>
        /// <param name="aLocation">
        /// New location
        /// </param>
        public void setLocation(Location aLocation)
        {
            this.currentLocation = aLocation;
        }

        /// <summary>
        /// Used to update time of digital reader, used for simulation
        /// </summary>
        /// <param name="aDateTime">
        /// New date/time
        /// </param>
        public void setCurrentTime(DateTime aDateTime)
        {
            this.currentTime = aDateTime;
        }
	}
}
