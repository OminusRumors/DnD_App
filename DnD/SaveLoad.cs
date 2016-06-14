using DnD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DnD
{
    public static class SaveLoad
    {
        public static void Serialize<T>(T serObject)
        {
            //serialize the character
            try
            {
                XmlDocument xmlCharacher = new XmlDocument();
                var xmlSerializer = new XmlSerializer(serObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    xmlSerializer.Serialize(stream, serObject);
                    stream.Position = 0;
                    xmlCharacher.Load(stream);
                    xmlCharacher.Save(serObject.ToString());
                    Console.WriteLine();
                    stream.Close();
                }

                string path = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\Characters";
                Directory.CreateDirectory(path);
                Console.Write("path to the file: {0}\n", path);
            }
            catch
            {

            }
        }
    }
}
