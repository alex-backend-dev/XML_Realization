using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XML
{
    /// <summary>
    /// Wrapper for login description 
    /// </summary>
    public class Login
    {
        public string Name { get; }
        public List<Window> Windows { get; }

        /// <summary>
        /// Initialization property Name and List windows
        /// </summary>
        /// <param name="name"></param>
        /// <param name="windows"></param>
        public Login(string name, List<Window> windows)
        {
            Name = name;
            Windows = windows;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsCorrect()
        {
            return Windows.Any(x => x.IsCorrectWindow()); // если хотя бы одно окно не корректно, то true, если все корректны, то false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
