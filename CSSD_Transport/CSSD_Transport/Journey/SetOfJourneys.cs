﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journey
{
	class SetOfJourneys : List<Journey>
	{
		public float getAmountForAllJourneys(int id)
		{
            //TODO: What the hell is the ID supposed to be for if
            //we're calculating ALL of the joruneys?
            throw new NotImplementedException();
        }

		public Journey findMostRecentJourney(int id)
		{
            //TODO: Same with this crap, whats the need for the id?
            throw new NotImplementedException();
        }
	}
}
