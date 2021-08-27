using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XML
{
    public class Login
    {
        public string Name { get; }
        public List<Window> Windows { get; }

        public Login(string name, List<Window> windows)
        {
            Name = name;
            Windows = windows;
        }

        public bool IsCorrect()
        {
            return Windows.Any(x => x.IsCorrectWindow());
        }

        public override string ToString()
        {
            var outputString = new StringBuilder();
            outputString.AppendFormat($"Login: {Name}\n");
            foreach (var window in Windows)
            {
                outputString.AppendLine(window.ToString());
            }
            return outputString.ToString();
        }
    }
}
