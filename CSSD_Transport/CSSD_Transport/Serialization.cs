using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CSSD_Transport.Accounts;

namespace CSSD_Transport
{
	public static class Serialization
	{
        public static void saveAll()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("config.bin",
                                            FileMode.Create,
                                            FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, SetOfAccounts.Instance);
            stream.Close();
        }

        public static void loadAll()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("config.bin",
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            SetOfAccounts.Instance = (SetOfAccounts)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
