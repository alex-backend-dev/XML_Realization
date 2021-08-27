using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XML;

namespace Xml
{
    public class XmlHelper
    {
        public XDocument GetFile(string filePath)
        {
            return XDocument.Load(filePath);
        }

        public IEnumerable<Login> GetLogins(XDocument document)
        {
            return document
                .Descendants("login")
                .Select(x => new Login(
                        (string)x.Attribute("name"),
                        x.Elements("window").Select(y => new Window
                        {
                            Title = (string)y.Attribute("title"),
                            Top = (int?)y.Element("top"),
                            Left = (int?)y.Element("left"),
                            Width = (int?)y.Element("width"),
                            Height = (int?)y.Element("height")
                        }).ToList()
                    )
                ).ToList();
        }

        public IEnumerable<string> GetInCorrectLogins(IEnumerable<Login> logins)
        {
            return logins
                .Where(x => !x.IsCorrect())
                .Select(x => x.Name);
        }
    }
}