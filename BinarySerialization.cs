using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    public class BinarySerialization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream("J:\\240\\FileIODemo\\FileIODemo\\DemoBinary.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream,sample);
        }
        public void DeSerialization()
        {
           
            FileStream fileStream = new FileStream("J:\\240\\FileIODemo\\FileIODemo\\DemoBinary.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampleDemo = (Demo)formatter.Deserialize(fileStream);

            Console.WriteLine(" Application Name : " + deserializedSampleDemo.ApplicationName + " Application Id : " + deserializedSampleDemo.ApplicationID);
        }

    }

    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serializae";

        public int ApplicationID { get; set; } = 1001;
    }
}
