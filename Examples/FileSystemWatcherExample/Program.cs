using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileSystemWatcherExample
{
    internal class Program
    {
        // [FileSystemWatcher Class](https://learn.microsoft.com/en-us/dotnet/api/system.io.filesystemwatcher?view=netframework-4.8)
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher(@"D:\Ray\MyLabs\FileSystemWatcher\");

            watcher.NotifyFilter = NotifyFilters.Attributes
                | NotifyFilters.CreationTime
                | NotifyFilters.DirectoryName
                | NotifyFilters.FileName;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if(e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Changed: {e.FullPath}");
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Created: {e.FullPath}");
        }
    }

}
