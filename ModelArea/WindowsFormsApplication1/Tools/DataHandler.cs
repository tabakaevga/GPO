using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using ModelArea;

namespace WindowsFormsApplication1
{
    public class DataHandler
    {
        public static void SerializeBinary<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            var serializeFileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            formatter.Serialize(serializeFileStream, container);
            serializeFileStream.Close();
        }

        public static void DeserializeBinary<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            var deserializeFile = new FileStream(fileName, FileMode.OpenOrCreate);
            if (deserializeFile.Length > 0)
            {
                container = (T)formatter.Deserialize(deserializeFile);
            }
            deserializeFile.Close();
        }
    }
}
