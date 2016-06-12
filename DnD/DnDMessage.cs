using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DnD
{
    [Serializable]
    public class DnDMessage
    {
        public string Action;
        public Dictionary<string, string> Properties;

        public DnDMessage(string action)
        {
            this.Action = action;
        }

        public DnDMessage(string action, Dictionary<string, string> props)
        {
            this.Action = action;
            this.Properties = props;
        }

        // Convert a byte array to an Object
        public static DnDMessage createWithText(string text)
        {
            return new DnDMessage("text", new Dictionary<string, string> { { "value", text } });
        }

        // Convert an object to a byte array
        public byte[] ToByteArray()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, this);
                return ms.ToArray();
            }
        }

        // Convert a byte array to an Object
        public static DnDMessage createFromByteArray(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                DnDMessage obj = null;
                try
                {
                    obj = (DnDMessage)binForm.Deserialize(memStream);
                }
                catch (SerializationException)
                {
                    return new DnDMessage("error", new Dictionary<string, string> { { "value", "Invalid request" } });
                }
                return obj;
            }
        }

    }
}