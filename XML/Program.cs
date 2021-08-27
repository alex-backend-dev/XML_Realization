using System.Linq;
using Xml;
using static System.Console;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = "Logins.xml";

            XmlHelper xmlHelper = new XmlHelper();

            var document = xmlHelper.GetFile(filename);

            WriteLine("Task 1. Display login: ");
            var logins = xmlHelper.GetLogins(document).ToList();
            foreach (var login in logins)
            {
                Write(login);
            }

            WriteLine("Task 3. Display incorrect logins: ");
            var correctLogins = xmlHelper.GetInCorrectLogins(logins);
            foreach (var correctLogin in correctLogins)
            {
                WriteLine(correctLogin);
            }

            ReadLine();
        }
    }
}
