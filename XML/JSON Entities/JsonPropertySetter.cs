using System.Collections.Generic;

namespace XML
{
    public static class JsonPropertySetter 
    {
        public static Login CorrectWindows(Login login)
        {
            List<Window> newWindows = new List<Window>();
            foreach (var element in login.Windows)
            {
                newWindows.Add(new Window {Top = element.Top ?? 0, Left = element.Left ?? 0, Width = element.Width ?? 400, Height = element.Height ?? 150 }); 
            }

            Login login1 = new Login(login.Name, newWindows);

            return login1;  
        }
    }
}
