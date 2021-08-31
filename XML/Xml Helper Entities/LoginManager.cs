using System;
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
        private List<Login> logins;

        public LoginManager(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("Ошибка! Не может быть пустым название!");
            }
            
            var document = XmlHelper.GetFile(fileName);
            logins = XmlHelper.GetLogins(document).ToList();
        }

        /// <summary>
        /// Writing convert Xml in right format into file
        /// </summary>
        /// <param name="xmlHelper"></param>
        public void CorrectLogin()
        {
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
        public void IncorrectLogin()
        {
            var correctLogins = XmlHelper.GetInCorrectLogins(logins);
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
