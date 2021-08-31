using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xml;

namespace XML
{
    /// <summary>
    /// Wrapper for writing correctLogins and incorrectLogins
    /// </summary>
    public class LoginManager
    {
        private string filename;

        public LoginManager(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// Writing convert Xml in right format into file
        /// </summary>
        /// <param name="xmlHelper"></param>
        public void CorrectLogin(XmlHelper xmlHelper)
        {
            var document = xmlHelper.GetFile(filename);

            var logins = xmlHelper.GetLogins(document).ToList();
            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                foreach (var loginReading in logins)
                {
                    writetext.WriteLine(loginReading);
                }
            }
        }

        /// <summary>
        /// Writing incorrect logins into file
        /// </summary>
        /// <param name="logins"></param>
        /// <param name="xmlHelper"></param>
        public void InCorrectLogin(IEnumerable<Login> logins, XmlHelper xmlHelper)
        {
            var correctLogins = xmlHelper.GetInCorrectLogins(logins);
            using (StreamWriter writetext = new StreamWriter("Incorrect.txt"))
            {
                foreach (var incorrectLogin in correctLogins)
                {
                    writetext.WriteLine(incorrectLogin);
                }
            }
        }
    }
}
