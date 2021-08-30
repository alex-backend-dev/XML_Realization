using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace XML
{
    /// <summary>
    /// Class for working with JSON format
    /// </summary>
    public class JsonReading
    {
        /// <summary>
        /// Method for writing data to json
        /// </summary>
        /// <param name="logins"></param>
        public void MigrateToJson(List<Login> logins)
        {
            foreach(var elementLogin in logins)
            {
                elementLogin.Windows.ForEach(window => window.SetProperties());
                string path = @$"Config\{elementLogin.Name}";

                Directory.CreateDirectory(path);

                var json = JsonConvert.SerializeObject(elementLogin);
                File.WriteAllText(@$"{path}\{elementLogin.Name}.json", json);
            }
        }
    }
}
