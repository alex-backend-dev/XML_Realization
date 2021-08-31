using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XML;

namespace Xml
{
    public class XmlHelper
    {
        /// <summary>
        /// Load Xml file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns> New Xdocument from a file </returns>
        public XDocument GetFile(string filePath)
        {
            return XDocument.Load(filePath);
        }

        /// <summary>
        /// Makes reading of all doucemnt
        /// </summary>
        /// <param name="document"></param>
        /// <returns> The data list in formatted form</returns>
        public IEnumerable<Login> GetLogins(XDocument document)
        {
            return document
                .Descendants("login")
                .Select(x => new Login(
                        (string)x.Attribute("name"), // достаем значение атрибута name типа (Bob, Tom)
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

        /// <summary>
        /// Get correct logings with IEnumerable <string> type
        /// </summary>
        /// <param name="logins"></param>
        /// <returns> Correct logins </returns>
        public IEnumerable<string> GetInCorrectLogins(IEnumerable<Login> logins)
        {
            return logins
                .Where(x => !x.IsCorrect()) // выбираем только те элементы, которые корректны
                .Select(x => x.Name); // вытаскиваем только имена
        }
    }
}