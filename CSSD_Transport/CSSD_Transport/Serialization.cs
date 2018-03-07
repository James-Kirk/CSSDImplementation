using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CSSD_Transport.Accounts;

namespace CSSD_Transport.Util
{
	public static class Serialization
	{
        private static string fileNameAccount = "accounts.bin";
        private static string fileNameStaff = "staffAccounts.bin";

        public static void saveAll()
        {
            IFormatter formatter = new BinaryFormatter();

            // save accounts
            Stream stream = new FileStream(fileNameAccount,
                                            FileMode.Create,
                                            FileAccess.Write,
                                            FileShare.None);
            formatter.Serialize(stream, SetOfAccounts.Instance);
            stream.Close();

            // save staff accounts
            stream = new FileStream(fileNameStaff,
                                            FileMode.Create,
                                            FileAccess.Write,
                                            FileShare.None);
            formatter.Serialize(stream, SetOfStaffAccounts.Instance);
            stream.Close();

        }

        public static void loadAll()
        {
            IFormatter formatter = new BinaryFormatter();
            // loading accounts
            //check file exists to avoid runtime error if it doesn't.
            if (File.Exists(fileNameAccount) != false)
            {
                Stream stream = new FileStream(fileNameAccount,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
                // file is empty so close stream
                if (stream.Length != 0)
                {
                    SetOfAccounts.Instance = (SetOfAccounts)formatter.Deserialize(stream);
                }
                stream.Close();
            };

            // loading staff accounts
            if (File.Exists(fileNameStaff) != false)
            {
                Stream stream = new FileStream(fileNameStaff,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
                if (stream.Length != 0)
                {
                    SetOfStaffAccounts.Instance = (SetOfStaffAccounts)formatter.Deserialize(stream);
                }
                stream.Close();
            };
        }
    }
}
