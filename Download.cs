using System;
using System.Net;
using System.Threading;
using System.Web;
namespace Installer;
public static class Downloader
{
    public static void Download()
    {
        string url = "https://nodejs.org/dist/v18.14.0/node-v18.14.0-x64.msi";
        string directory = "C:/Users/HP/Desktop/c#_testtt";

        Uri uri = new Uri(url);
        string filename = System.IO.Path.GetFileName(uri.LocalPath);

        using (var client = new WebClient())
        {
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadCompleted);
            client.DownloadFileAsync(new Uri(url), directory + "\\" + filename);
            Console.WriteLine("Downloading...");

            while (client.IsBusy)
            {
                Thread.Sleep(30);
            }
        }
    }

    public static object _lock = new object();
    public static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        lock (_lock)
        {
            Console.Write("\r{0}% complete.", e.ProgressPercentage);
            Console.Write("[");
            int progress = e.ProgressPercentage / 2;
            for (int i = 0; i < progress; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("#");
                Console.ForegroundColor = ConsoleColor.White;

            }
            for (int i = 0; i < 50 - progress; i++)
            {
                Console.Write(" ");
            }
            Console.Write("]");
        }
    }

    public static void DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nDownload completed!");
        Console.WriteLine();
    }
}