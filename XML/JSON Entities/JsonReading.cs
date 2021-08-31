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
                var result = JsonPropertySetter.CorrectWindows(elementLogin);
                string path = @$"Config\{result.Name}";

                Directory.CreateDirectory(path);

                var json = JsonConvert.SerializeObject(result);
                File.WriteAllText(@$"{path}\{result.Name}.json", json);
            }
        }
    }
}
