using System.IO;
using System.Linq;
using Xml;

namespace XML
{
    public class Program
    {
        static void Main(string[] args)
        {
            var filename = "Logins.xml";

            XmlHelper xmlHelper = new XmlHelper();

            var document = xmlHelper.GetFile(filename);

            var logins = xmlHelper.GetLogins(document).ToList();
            using (StreamWriter writetext = new StreamWriter("write.txt")) 
            {
                foreach (var loginReading in logins)
                {
                    writetext.WriteLine(loginReading);
                }
            }

            var correctLogins = xmlHelper.GetInCorrectLogins(logins);
            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                foreach (var incorrectLogin in correctLogins)
                {
                    writetext.WriteLine(incorrectLogin);
                }
            }


            JsonReading jsonReading = new JsonReading();

            jsonReading.MigrateToJson(logins);
        }
    }
}
