using System.Net;
using static System.Net.WebRequestMethods;
namespace Installer;

public static class Downloader
{
    public static void DownloadNode(string url, string filename)
    {
        string folderName = "Automation";
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string directory = Path.Combine(desktopPath, folderName);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        Uri uri = new Uri(url);
        using (var client = new WebClient())
        {
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadCompleted);
            client.DownloadFileAsync(new Uri(url), Path.Combine(directory, filename));
            Console.WriteLine("Downloading...");

            while (client.IsBusy)
            {
                Thread.Sleep(200);
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