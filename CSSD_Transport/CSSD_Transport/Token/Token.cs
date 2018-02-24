﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;

namespace CSSD_Transport.Token
{
	public abstract class Token
	{
		protected int tokenID;
		protected Account tokenUser;
		protected string tokenType;
		protected bool scanned;
		protected int journeyCounter;
		protected bool discounted;


		public bool getScannedStatus() => scanned;

		public string getType() => tokenType;

		public int getNumOfJourneys() => journeyCounter;

		public int getID() => tokenID;

		public bool hasDiscount() => discounted;

		//TODO: wut?
		public bool hasSufficientCredit() => false;

		public void incrementJourney() => journeyCounter++;

		public void setScanned(bool s) => scanned = s;

	}
}
