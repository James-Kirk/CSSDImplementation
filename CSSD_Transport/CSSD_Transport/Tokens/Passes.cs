using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Tokens
{
	public class Passes : Token
	{
		private DateTime startDate, expiryDate;
		private String passType;

		public Passes(DateTime startDate, DateTime expiryDate, string type)
		{
			this.startDate = startDate;
			this.expiryDate = expiryDate;
			passType = type;
		}

		public DateTime getStartDate() => startDate;
		public DateTime getExpiryDate() => expiryDate;
		public String getPassType() => passType;

		public void setStartDate(DateTime d) => this.startDate = d;
		public void setExpiryDate(DateTime d) => this.expiryDate = d;
		public void setStartDate(String s) => this.passType = s;
	}
}
