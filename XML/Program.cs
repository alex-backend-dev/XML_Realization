using System.IO;
using System.Linq;
using Xml;
using static System.Console;

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
            foreach (var login in logins)
            {
                File.WriteAllText("readingInfo.txt", login.ToString());
            }

            var correctLogins = xmlHelper.GetInCorrectLogins(logins);
            foreach (var correctLogin in correctLogins)
            {
                File.WriteAllText("incorrectLogins.txt", correctLogin.ToString());
            }

            ReadLine();
        }
    }
}
