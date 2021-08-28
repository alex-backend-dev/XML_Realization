using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class JsonReading
    {
        public void MigrateToJson(List<Login> logins)
        {
            foreach(var elementLogin in logins)
            {
                string path = @$"C:\Users\sanch\Desktop\Clone XML\XML_Realization\XML\bin\Debug\net5.0\Config\{elementLogin.Name}";

                System.IO.Directory.CreateDirectory(path);

                var json = JsonConvert.SerializeObject(elementLogin);
                File.WriteAllText(@$"{path}\{elementLogin.Name}.json", json);
            }
        }
    }
}
