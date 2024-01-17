using System;
using System.Diagnostics;

namespace ProcessExample
{
    class Program
    {
        // Opens the Internet Explorer application.
        void OpenApplication(string myFavoritesPath)
        {
            // Start Internet Explorer. Defaults to the home page.
            Process.Start("IExplore.exe");

            // Display the contents of the favorites folder in the browser.
            Process.Start(myFavoritesPath);
        }

        // Opens urls and .html documents using Internet Explorer.
        void OpenWithArguments()
        {
            // url's are not considered documents. They can only be opened
            // by passing them as arguments.
            Process.Start("IExplore.exe", "www.gnu.org");

            // Start a Web page using a browser associated with .html and .asp files.
            Process.Start("IExplore.exe", "D:\\Ray\\MyLabs\\html\\index.html");
        }

        // Uses the ProcessStartInfo class to start new processes,
        // both in a minimized mode.
        void OpenWithStartInfo()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            Process.Start(startInfo);

            startInfo.Arguments = "https://www.microsoft.com/zh-tw/";

            Process.Start(startInfo);
        }


        static void Main(string[] args)
        {
            // Get the path that stores favorite links.
            string myFavoritesPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

            Program myProcess = new Program();

            //myProcess.OpenApplication(myFavoritesPath); 
            //myProcess.OpenWithArguments();
            myProcess.OpenWithStartInfo();

            Console.ReadKey();
        }
    }
}
