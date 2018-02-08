﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

using CSSD_Transport.Accounts;

namespace CSSD_Transport.Token
{
	public class BiometricTicket : Token
	{
		private UInt32 fingerPrint;

		BiometricTicket(Account a)
		{
			using (MD5 md5 = MD5.Create())
			{
				byte[] buff = System.Text.Encoding.ASCII.GetBytes(a.getUsername());
				byte[] hashBytes = md5.ComputeHash(buff);

				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					sb.Append(hashBytes[i].ToString("X2"));
				}
				fingerPrint = UInt32.Parse(sb.ToString(), System.Globalization.NumberStyles.HexNumber);
			}
		}

		public UInt32 getFingerPrint() => fingerPrint;
	}
}
