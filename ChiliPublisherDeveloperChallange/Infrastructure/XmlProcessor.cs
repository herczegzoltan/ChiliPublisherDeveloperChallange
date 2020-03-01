using ChiliPublisherDeveloperChallange.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class XmlProcessor
    {
        public static RootObject GetXmlRootObjectCommands(string xmlFilePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RootObject));

            using (FileStream reader = new FileStream(@"" + xmlFilePath, FileMode.Open))
            {
                RootObject result = (RootObject)serializer.Deserialize(reader);

                return result;
            }
        }
    }
}
