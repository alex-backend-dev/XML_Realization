using Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace XML
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoginManager loginManager = new LoginManager("Logins.xml");

            loginManager.CorrectLogin();

            loginManager.IncorrectLogin();  
        }
    }
}
